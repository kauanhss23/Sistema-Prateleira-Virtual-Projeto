using System;

namespace backend.Models.Response.GerenteResponse
{
    public class topMelhoresClienteResponse
    {
        public string nome {get;set;}
        public string email {get;set;}
        public string telefone {get;set;}
        public int qtdpedidos {get;set;}
        public decimal? totaldegastos {get;set;}
    }
}