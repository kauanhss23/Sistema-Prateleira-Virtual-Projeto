using System;

namespace backend.Models.Response.ClienteResponse
{
    public class PerfilResponse
    {
        public string cliente {get;set;}
        public DateTime? nascimento {get;set;}
        public string cpf {get;set;}
        public string rg{get;set;}
        public string cartaocredito {get;set;}
        public int? codigoseguranca {get;set;}
        public DateTime? vencimentocartao {get;set;}
        public string endereco {get;set;}
        public string telefone {get;set;}

    }
}