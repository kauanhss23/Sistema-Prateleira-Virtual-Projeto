using System;

namespace backend.Models.Response.ClienteResponse
{
    public class ModeloHistóricoCompra
    {
        public int? idcliente {get;set;}
        public int? idlivro {get;set;}
        public string livro {get;set;}
        public string autor {get;set;}
        public string serie {get;set;}
        public decimal? preco {get;set;}
        public DateTime? datacompra {get;set;}
        public string nomearquivo {get;set;}
    }
}