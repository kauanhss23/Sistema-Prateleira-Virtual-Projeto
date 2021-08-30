using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace backend.Utils.FuncoesClienteUtils
{
    public class HistoricoCompraUtils
    {
        public Models.Response.ClienteResponse.ModeloHistóricoCompra converterhistorico(Models.TbCompraLivro tb)
        {
            Models.Response.ClienteResponse.ModeloHistóricoCompra ctx = new Models.Response.ClienteResponse.ModeloHistóricoCompra();

            ctx.idcliente = tb.IdCompraNavigation.IdCliente;
            ctx.idlivro = tb.IdLivroNavigation.IdLivro;
            ctx.livro = tb.IdLivroNavigation.NmLivro;
            ctx.autor = tb.IdLivroNavigation.NmAutor;
            ctx.serie = tb.IdLivroNavigation.NrSerie;
            ctx.preco = tb.IdLivroNavigation.VlPreco;
            ctx.datacompra = tb.IdCompraNavigation.DtCompra;
            ctx.nomearquivo = tb.IdLivroNavigation.PdfLivro;

            return ctx;
        }

        public List<Models.Response.ClienteResponse.ModeloHistóricoCompra> returntcompra(List<Models.TbCompraLivro> db)
        {
            List<Models.Response.ClienteResponse.ModeloHistóricoCompra> ctx = new List<Models.Response.ClienteResponse.ModeloHistóricoCompra>();

            foreach(Models.TbCompraLivro item in db)
            {
                ctx.Add(converterhistorico(item));
            }
            
            return ctx;
        }      

        public Models.Response.ClienteResponse.FazerCompra convertcompra(Models.TbLivro req)
        {
            Models.Response.ClienteResponse.FazerCompra ctx = new Models.Response.ClienteResponse.FazerCompra();

            ctx.idlivro = req.IdLivro;
            ctx.autor = req.NmAutor;
            ctx.livro = req.NmLivro;
            ctx.original = req.TpIdiomaOriginal;
            ctx.paginas = req.NrPaginas;
            ctx.preco = req.VlPreco;
            ctx.publicacao = req.DtPublicacao;
            ctx.serie = req.NrSerie;
            ctx.edicaolivro = req.DsEdicaoLivro;
            ctx.sinopse = req.DsSinopse;
            ctx.editora = req.NmEditora;
            ctx.genero = req.DsGenero;
            ctx.nomeimg = req.ImgImagem;
            ctx.nomearquivo = req.PdfLivro;
            
            return ctx;
        }
        
        public List<Models.Response.ClienteResponse.FazerCompra> convertcompralist(List<Models.TbLivro> req)
        {
            List<Models.Response.ClienteResponse.FazerCompra> ctx = new List<Models.Response.ClienteResponse.FazerCompra>();

            foreach(Models.TbLivro item in req)
            {
                ctx.Add(convertcompra(item));
            }

            return ctx;
        }

        public Models.Response.ClienteResponse.PerfilResponse convertperfil(Models.TbCliente req)
        {
            Models.Response.ClienteResponse.PerfilResponse ctx = new Models.Response.ClienteResponse.PerfilResponse();

            ctx.cliente = req.NmCliente;
            ctx.nascimento = req.DtNascimento;
            ctx.cpf = req.DsCpf;
            ctx.rg = req.DsRg;
            ctx.cartaocredito = req.DsCartaoCredito;
            ctx.endereco = req.DsEndereco;
            ctx.telefone = req.DsTelefone;

            return ctx;
            
        }
        public Models.Request.RequestCliente.FazerCompraRequest convertfazercompra(int? a, decimal b, DateTime c)
        {
            Models.Request.RequestCliente.FazerCompraRequest x = new Models.Request.RequestCliente.FazerCompraRequest();

            x.compra = c;
            x.preco = b;
            x.idcliente = a;

            return x;
        }
        public Models.TbCompra convertfazercompratb(Models.Request.RequestCliente.FazerCompraRequest req)
        {
            Models.TbCompra x = new Models.TbCompra();

            x.IdCliente = req.idcliente;
            x.VlTotal = req.preco;
            x.DtCompra = req.compra;
            return x;
        }
        public Models.TbCompraLivro converttbcompralivro(Models.TbCompra req1, Models.TbLivro req2)
        {
            Models.TbCompraLivro ctx = new Models.TbCompraLivro();

            ctx.IdCompra = req1.IdCompra;
            ctx.IdLivro = req2.IdLivro;

            return ctx;
        }
    
    }
}