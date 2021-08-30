using System;

namespace backend.Models.Response.GerenteResponse
{
    public class FuncionarioGerenteResponse
    {
        public int idfuncionario {get;set;}
        public string nomefuncionario {get;set;}
        public DateTime? nascimentofuncionario {get;set;}
        public string cpf {get;set;}
        public string cep {get;set;}
        public string rg {get;set;}
        public string carteiratrabalho {get;set;}
        public string cargo {get;set;}
        public string cargahorariasemanal {get;set;}
        public decimal? salario {get;set;}
        public int? idnovaconta {get;set;}
    }
}