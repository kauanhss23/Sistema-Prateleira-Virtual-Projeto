using System;
using System.Collections;

namespace backend.Models.Request.RequestGerente
{
    public class RequestGerente
    {
        public string nomefuncionario {get;set;}
        public DateTime nascimentofuncionario {get;set;}
        public string cpf {get;set;}
        public string cep {get;set;}
        public string rg {get;set;}
        public string carteiratrabalho {get;set;}
        public string cargahorariasemanal {get;set;}
        public decimal salario {get;set;}
    }
}