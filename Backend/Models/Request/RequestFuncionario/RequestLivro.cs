using System;
using Microsoft.AspNetCore.Http;
namespace backend.Models.Request.RequestFuncionario
{
    public class RequestLivro
    {
        public string livro {get;set;}
        public string autor {get;set;}
        public string genero {get;set;}
        public decimal preco {get;set;}
        public int? paginas {get;set;}
        public string idiomaprimario {get;set;}
        public string sinopse {get;set;}
        public DateTime publicacao {get;set;}
        public string editora {get;set;}
        public string numeroserie {get;set;}
        public string edicaolivro {get;set;}
        public IFormFile imagem {get;set;}
        public IFormFile arquivolivro {get;set;}
    }
}