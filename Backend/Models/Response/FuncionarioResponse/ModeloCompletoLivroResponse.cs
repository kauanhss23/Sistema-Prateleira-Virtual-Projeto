using System;

namespace backend.Models.Response.FuncionarioResponse
{
    public class ModeloCompletoLivroRespone
    {
        public int id{get;set;}
        public string livro {get;set;}
        public string autor {get;set;}
        public string genero {get;set;}
        public decimal? preco {get;set;}
        public int? paginas {get;set;}
        public string idiomaprimario {get;set;}
        public string sinopse {get;set;}
        public DateTime publicacao {get;set;}
        public string editora {get;set;}
        public string numeroserie {get;set;}
        public string edicaolivro {get;set;}
        public string nomeimagem {get;set;}
        public string nomearquivo {get;set;}
    }
}