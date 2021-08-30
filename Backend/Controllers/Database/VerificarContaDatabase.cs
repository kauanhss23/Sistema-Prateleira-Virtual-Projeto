using System;
using System.Collections;

namespace backend.Controllers.Database
{
    public class VerificarContaDatabase
    {
        Models.TccContext db = new Models.TccContext();
        Utils.CriarContaUtils converter = new Utils.CriarContaUtils();
        Utils.MiniConversorCriarConta miniconversor = new Utils.MiniConversorCriarConta();
        public Models.Response.CriarContaRequest inserirnovaconta (Models.Request.CriarContaRequest conta)
        {
            Models.TbLogin parte1 = converter.LogigReqForTbLogin(conta.conta);
            db.TbLogin.Add(parte1);
            db.SaveChanges();

            Models.TbCliente parte2 = converter.ClienteReqForTbCliente(conta.InformacoesCliente,parte1);
            db.TbCliente.Add(parte2);
            db.SaveChanges();

            Models.Response.CriarContaRequest parte3 = miniconversor.copiar(parte1,parte2);
            return parte3;
        }
    }
}