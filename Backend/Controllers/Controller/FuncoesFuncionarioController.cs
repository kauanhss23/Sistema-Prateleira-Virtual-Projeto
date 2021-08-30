using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class FuncoesFuncionarioController : ControllerBase
    {

        [HttpGet("consultarlivros")]
        public ActionResult<List<Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone>> consultarlivro()
        {
            try{
            Business.BusinessFuncionario.ProcurarResgistroLivrosBusiness buscar = new Business.BusinessFuncionario.ProcurarResgistroLivrosBusiness();
            Utils.FuncoesFuncionarioUtils.ListaLivrosUtils convertertblivro = new Utils.FuncoesFuncionarioUtils.ListaLivrosUtils();

            List<Models.TbLivro> ModeloTb = buscar.buscarlivros();
            List<Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone> ModeloPersonalizado = convertertblivro.ListaCliente(ModeloTb);
            return ModeloPersonalizado;
            }
            catch(System.Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErroResponse(ex,400)
                );
            }
        }

        [HttpPut("alterarlivro")]
        public ActionResult<Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone> AlterarLivro (Models.Request.RequestFuncionario.RequestLivroAlterar novasinformacoes )
        {   
            try{
            Utils.FuncoesFuncionarioUtils.ListaLivrosUtils AlterarModelo = new Utils.FuncoesFuncionarioUtils.ListaLivrosUtils();
            Business.BusinessFuncionario.ValidarAlteracaoLivroParte2 validacao = new Business.BusinessFuncionario.ValidarAlteracaoLivroParte2();

            Models.TbLivro atual =  validacao.UltimaParteParaAlterar(novasinformacoes);

            Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone AlteradoComSucesso = AlterarModelo.TbLivroparaLivroResponseCompleto(atual);
            return AlteradoComSucesso;
            }
            catch(System.Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErroResponse(ex, 400)
                );
            }
        }

        [HttpPost("NovoLivro")]
        public ActionResult<Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone> inserirnovolivro([FromForm] Models.Request.RequestFuncionario.RequestLivro req)
        {
            try{
            Utils.FuncoesFuncionarioUtils.ListaLivrosUtils converter = new Utils.FuncoesFuncionarioUtils.ListaLivrosUtils();
            Business.GerenciadordeImagens.GerenciadordeImagensBusiness gerenciarimg = new Business.GerenciadordeImagens.GerenciadordeImagensBusiness();
            Business.BusinessFuncionario.inserirNovoLivroVerificar verificar = new Business.BusinessFuncionario.inserirNovoLivroVerificar();

            Models.TbLivro modelotb = converter.RequestTblivroparaTbLivro(req);
            modelotb.ImgImagem = gerenciarimg.GerarNome(req.imagem.FileName);
            modelotb.PdfLivro = gerenciarimg.GerarNome(req.arquivolivro.FileName);

            Models.TbLivro x = verificar.verificarparametros(modelotb);
            gerenciarimg.SalvarFoto(modelotb.ImgImagem, req.imagem);
            gerenciarimg.SalvarFoto(modelotb.PdfLivro,req.arquivolivro);

            Models.Response.FuncionarioResponse.ModeloCompletoLivroRespone result = converter.TbLivroparaLivroResponseCompleto(modelotb);
            return result;
            }
            catch(System.Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErroResponse(ex,400)
                );
            }
        }
        [HttpGet("buscarimagem/{foto}")]
        public ActionResult buscarfoto(string foto)
        {
            Business.GerenciadordeImagens.GerenciadordeImagensBusiness gerenciarfoto = new Business.GerenciadordeImagens.GerenciadordeImagensBusiness();

            byte[] x = gerenciarfoto.Lerfoto(foto);
            string xx = gerenciarfoto.GerarContnttype(foto);
            return File(x,xx);
        }
    }
}