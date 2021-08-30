using System;

namespace backend.Models.Response.ResponsedoFuncionario
{
    public class RegistroLivroResponse
    {
        public int id {get;set;}
        public string livro {get;set;}
        public string autor {get;set;}
        public string genero {get;set;}
        public decimal? preco {get;set;}
    }
}