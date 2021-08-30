using System;

namespace backend.Models.Response.GerenteResponse
{
    public class TopMelhoresProdutosResponse
    {
        public string nomeproduto {get;set;}
        public int qtdvendidos {get;set;}
        public decimal? lucrogeral {get;set;}
    }
}