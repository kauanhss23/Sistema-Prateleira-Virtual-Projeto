using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace backend.Utils.FuncoesFuncionarioUtils
{
    public class ListaLivrosUtils
    {
        public Models.Response.FuncionarioResponse.ModeloTbLivroResponse TbLivroparaLivroResponse(Models.TbLivro reg)
        {
            Models.Response.FuncionarioResponse.ModeloTbLivroResponse ctx = new Models.Response.FuncionarioResponse.ModeloTbLivroResponse();

            ctx.id = reg.IdLivro;
            ctx.livro = reg.NmLivro;
            ctx.autor = reg.NmAutor;
            ctx.publicacao = reg.DtPublicacao;
            ctx.sinopse = reg.DsSinopse;
            ctx.preco = reg.VlPreco;
            ctx.paginas = reg.NrPaginas;
            ctx.idiomaprimario = reg.TpIdiomaOriginal;
            ctx.genero = reg.DsGenero;

            return ctx;
        }

        public List<Models.Response.FuncionarioResponse.ModeloTbLivroResponse> ConverterlistaTbLivro(List<Models.TbLivro> registros)
        {
            List<Models.Response.FuncionarioResponse.ModeloTbLivroResponse> novalista = new List<Models.Response.FuncionarioResponse.ModeloTbLivroResponse>();

            foreach(Models.TbLivro livro in registros)
            {
                novalista.Add(TbLivroparaLivroResponse(livro));
            }
            return novalista;
        }

        public Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone TbLivroparaLivroResponseCompleto(Models.TbLivro request)
        {
            Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone response = new Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone();

            response.id = request.IdLivro;
            response.autor = request.NmAutor;
            response.livro = request.NmLivro;
            response.editora = request.NmEditora;
            response.paginas = request.NrPaginas;
            response.numeroserie = request.NrSerie;
            response.idiomaprimario = request.TpIdiomaOriginal;
            response.preco = request.VlPreco;
            response.edicaolivro = request.DsEdicaoLivro;
            response.genero = request.DsGenero;
            response.sinopse = request.DsSinopse;
            response.publicacao = request.DtPublicacao;
            response.nomeimagem = request.ImgImagem;
            response.nomearquivo = request.PdfLivro;

            return response;
        }
        public List<Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone> ListaCliente(List<Models.TbLivro> req){
            List<Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone> xx = new List<Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone>();

            foreach(Models.TbLivro item in req)
                xx.Add(TbLivroparaLivroResponseCompleto(item));

            return xx;
        }
        public List<Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone> filtrador(List<Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone> request,Models.Request.RequestFuncionario.Modeloparafiltrar req)
        {
            List<Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone> ctx = new List<Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone>();

            

            if(req.genero == "" && req.publicacao != 0)
                ctx = request.Where(x => x.publicacao.Year == req.publicacao).ToList();
            
            else if(req.genero != "" && req.publicacao == 0)
                ctx = request.Where(x => x.genero == req.genero).ToList();
            
            else if(req.genero != "" && req.publicacao != 0)
                ctx = request.Where(x => x.genero == req.genero && x.publicacao.Year == req.publicacao).ToList();
            
            else
                ctx = request;

            return ctx;
        }
        public Models.TbLivro RequestTblivroparaTbLivro(Models.Request.RequestFuncionario.RequestLivro req){
            
            Models.TbLivro ctx = new Models.TbLivro();
            ctx.NmAutor = req.autor;
            ctx.NmEditora = req.editora;
            ctx.NmLivro = req.livro;
            ctx.NrPaginas = req.paginas;
            ctx.NrSerie = req.numeroserie;
            ctx.TpIdiomaOriginal = req.idiomaprimario;
            ctx.VlPreco = req.preco;
            ctx.DsGenero = req.genero;
            ctx.DsEdicaoLivro = req.edicaolivro;
            ctx.DsSinopse = req.sinopse;
            ctx.DtPublicacao = req.publicacao;
        
            return ctx;
        }
    }
}