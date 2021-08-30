using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace backend.Models.Response.ClienteResponse
{
    public class FazerCompra
    {
        public int idlivro {get;set;}
        public string livro {get;set;}
        public string autor {get;set;}
        public string serie {get;set;}
        public string editora {get;set;}
        public int? paginas {get;set;}
        public string sinopse {get;set;}
        public DateTime? publicacao {get;set;}
        public string original {get;set;}
        public string edicaolivro {get;set;}
        public string genero {get;set;}
        public decimal? preco {get;set;}
        public string nomeimg {get;set;}
        public string nomearquivo {get;set;}
    }
}