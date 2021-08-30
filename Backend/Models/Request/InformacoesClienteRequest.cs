using System;
using System.Collections;
using System.Collections.Generic;

namespace backend.Models.Request
{
    public class InformacoesClienteRequest
    {
        public string nome {get;set;}
        public DateTime nascimento {get;set;}
        public string cpf {get;set;}
        public string rg {get;set;}
        public string cartaocredito {get;set;}
        public string endereco {get;set;}
        public string telefone {get;set;}
    
    }
}
