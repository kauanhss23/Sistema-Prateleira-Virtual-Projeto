using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

namespace backend.Utils.ConversorGerenteUtils
{
    public class ConversordoRelatorioUtils
    {
        public Models.Response.GerenteResponse.VendasdoDiaResponse vendasdodiautils(Models.TbCompra req)
        {
            Models.Response.GerenteResponse.VendasdoDiaResponse ctx = new Models.Response.GerenteResponse.VendasdoDiaResponse();
            
            ctx.cliente = req.IdClienteNavigation.NmCliente;
            ctx.dia = req.DtCompra.Day;
            ctx.valortotal = req.VlTotal;

            return ctx;
        }
        public List<Models.Response.GerenteResponse.VendasdoDiaResponse> ListaVendasdiaUtils(List<Models.TbCompra> req)
        {
            List<Models.Response.GerenteResponse.VendasdoDiaResponse> ctx = new List<Models.Response.GerenteResponse.VendasdoDiaResponse>();

            foreach(Models.TbCompra item in req)
            {
                ctx.Add(vendasdodiautils(item));
            }
            return ctx;
        }
        public Models.Response.GerenteResponse.VendasdoMesResponse ConvertVendasdoMes(int mes)
        {
            Models.Response.GerenteResponse.VendasdoMesResponse ctx = new Models.Response.GerenteResponse.VendasdoMesResponse();
            Utils.ConversorparaMesesUtils convert = new Utils.ConversorparaMesesUtils();
            Models.TccContext db = new Models.TccContext();

            List<Models.TbCompra> compras = db.TbCompra.ToList();
            List<decimal?> valor = new List<decimal?>();
            foreach(Models.TbCompra item in compras.Where(x => x.DtCompra.Month == mes))
            {
                valor.Add(item.VlTotal);
            }
            decimal? valortotal = valor.Sum();
            int? qtdvendas = valor.Count();
            string mesresponse = convert.mesescolhido(mes);

            ctx.mes = mesresponse;
            ctx.lucromensal = valortotal;
            ctx.qtdvendas = qtdvendas;

            return ctx;
        }
        public List<Models.Response.GerenteResponse.VendasdoMesResponse> convertvendasmes()
        {
            List<Models.Response.GerenteResponse.VendasdoMesResponse> result = new List<Models.Response.GerenteResponse.VendasdoMesResponse>();

            for(int meses = 1;meses <= 12; meses++)
            {
                result.Add(ConvertVendasdoMes(meses));
            }
            return result;
        }
        public Models.Response.GerenteResponse.topMelhoresClienteResponse melhoresCliente(Models.TbCompra req)
        {
            Models.TccContext db = new Models.TccContext();
            List<Models.TbCliente> clientes = db.TbCliente.Include(x => x.IdLoginNavigation).ToList();

            Models.TbCliente infocliente = clientes.First(x => x.IdCliente == req.IdCliente);
            List<Models.TbCompra> infocompras = db.TbCompra.Where(x => x.IdCliente == infocliente.IdCliente).ToList();
            List<decimal> valortotal = new List<decimal>();

            Models.Response.GerenteResponse.topMelhoresClienteResponse response = new Models.Response.GerenteResponse.topMelhoresClienteResponse();

            response.email = infocliente.IdLoginNavigation.DsEmail;
            response.nome = infocliente.NmCliente;
            response.telefone = infocliente.DsTelefone;
            response.qtdpedidos = infocompras.Count();

            foreach(Models.TbCompra ii in infocompras)
                valortotal.Add(ii.VlTotal);

            response.totaldegastos = valortotal.Sum();
            return response;
        }
        public Models.Response.GerenteResponse.TopMelhoresProdutosResponse adicionarprodutos(Models.TbCompraLivro req)
        {
            Models.TccContext db = new Models.TccContext();
            Models.Response.GerenteResponse.TopMelhoresProdutosResponse item = new Models.Response.GerenteResponse.TopMelhoresProdutosResponse();
            
            List<Models.TbCompraLivro> compraslivros = db.TbCompraLivro.Where(x => x.IdLivro == req.IdLivro).Include(x => x.IdLivroNavigation).ToList();
            Models.TbLivro infolivro = db.TbLivro.First(x => x.IdLivro == req.IdLivro);

            item.qtdvendidos = compraslivros.Count();
            
            item.nomeproduto = req.IdLivroNavigation.NmLivro;
            item.lucrogeral = infolivro.VlPreco * item.qtdvendidos;

            return item;
        }
        public Models.Response.GerenteResponse.LIstamelhoresGenerosReponse pegarmelhroes(Models.TbCompraLivro req)
        {
            Models.TccContext db = new Models.TccContext();
            List<Models.TbCompraLivro> compras = db.TbCompraLivro.ToList();
            Models.Response.GerenteResponse.LIstamelhoresGenerosReponse ctx = new Models.Response.GerenteResponse.LIstamelhoresGenerosReponse();

            Models.TbLivro livro = db.TbLivro.First(x => x.IdLivro == req.IdLivro);
            
            string nmlivro = livro.NmLivro;
            string gen = livro.DsGenero;
            int vendas = 0;

            foreach(Models.TbCompraLivro i in compras)
            {
                if(i.IdLivro == livro.IdLivro)
                    vendas++;
                else
                    continue;
            }
            ctx.nomelivro = nmlivro;
            ctx.genero = gen;
            ctx.qtdvendas = vendas;
            return ctx;
        }

    }
}