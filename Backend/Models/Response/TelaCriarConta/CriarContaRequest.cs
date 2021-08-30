using System;

namespace backend.Models.Response
{
    public class CriarContaRequest
    {
        public Models.Response.EmailResponse conta {get;set;}
        public Models.Response.InformacoesClienteResponse informacoesCliente{get;set;}
    }
}