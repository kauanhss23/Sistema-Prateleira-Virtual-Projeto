using System;

namespace backend.Models.Response.GerenteResponse
{
    public class ListarFuncResponse
    {
        public string       nome         { get; set; }
        public string email {get;set;}
        public string senha {get;set;}
        public string cep {get;set;}
        public string rg {get;set;}
        public DateTime? nascimento {get;set;}
        public string carga {get;set;}
        public string       cpf          { get; set; }
        public decimal?      salario      { get; set; }
        public string       carteira     { get; set; }
        public int idconta {get;set;}
        public int? idlogin {get;set;}
    }
}
