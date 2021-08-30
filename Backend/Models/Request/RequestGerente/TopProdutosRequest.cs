using System;

namespace backend.Models.Request
{
    public class TopProdutosRequest
    {
        public string nomeproduto {get;set;}
        public int qtdpedidos {get;set;}
        public decimal lucroproduto {get;set;}
    }
}