
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;


namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CriarContaController
    {
        Business.VerificarContaBusiness verificacoes = new Business.VerificarContaBusiness();
        Models.TccContext db = new Models.TccContext();
        Utils.CriarContaUtils converter = new Utils.CriarContaUtils();


       [HttpPost("Criarnovaconta")]
        public ActionResult<Models.Response.CriarContaRequest> CriarNovaConta(Models.Request.CriarContaRequest req)
        {
            try{
            Models.Response.CriarContaRequest result = verificacoes.verificarparametroscliente(req);
            return result;
            }
            catch(System.Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErroResponse(ex,404)
                );
            }
        }

        [HttpPost("acessar")]
        public ActionResult<Models.Response.EmailPerfilResponse> acessar (Models.Request.EmailRequest login)
        {
            try{
            Utils.TelaCriarConta.AcessarUtils acesso = new Utils.TelaCriarConta.AcessarUtils();
            Business.TelaCriarConta.AcessarBusiness verificarexistencia = new Business.TelaCriarConta.AcessarBusiness();

            Models.TbLogin parte1 = verificarexistencia.verificarcontaexistente(login);
            Models.Response.EmailPerfilResponse parte2 = acesso.TbLoginParaLoginResponse(parte1);

            return parte2;
            }
            catch(System.Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErroResponse(ex,400)
                );
            }
        }
        
    }
}