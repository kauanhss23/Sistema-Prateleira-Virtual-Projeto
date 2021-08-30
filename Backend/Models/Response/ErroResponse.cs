using System;

namespace backend.Models.Response
{
    public class ErroResponse 
    {
        public int codigo {get;set;}
        public string motivo {get;set;}

        public ErroResponse(Exception motivos,int erro)
        {
            codigo = erro;
            motivo = motivos.Message;
        }
    }
}