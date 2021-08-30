using System;

namespace backend.Utils
{
    public class MiniConversorCriarConta
    {
        Utils.CriarContaUtils converter = new CriarContaUtils();
        public Models.Response.CriarContaRequest copiar(Models.TbLogin login, Models.TbCliente cliente)
        {
            Models.Response.CriarContaRequest retorno = new Models.Response.CriarContaRequest();

            Models.Response.EmailResponse ContacomId = converter.TbEmailParaEmailRes(login);
            Models.Response.InformacoesClienteResponse ClientecomID = converter.TbClienteparaClienteRes(cliente);

            retorno.conta = ContacomId;
            retorno.informacoesCliente = ClientecomID;
            return retorno;
        }
    }
}