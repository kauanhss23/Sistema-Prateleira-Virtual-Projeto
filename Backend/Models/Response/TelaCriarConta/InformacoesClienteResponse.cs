using System;
using System.Collections;

namespace backend.Models.Response
{
    public class InformacoesClienteResponse
    {
        public int idcliente {get;set;}
        public string nome {get;set;}
        public DateTime? nascimento {get;set;}
        public string cpf {get;set;}
        public string rg {get;set;}
        public string cartaocredito {get;set;}
        public int? codigoseguranca {get;set;}
        public DateTime? vencimentocartao {get;set;}
        public string endereco {get;set;}
        public string telefone {get;set;}

        public int?  idlogin  {get;set;}   
    }
}