using System;

namespace backend.Models.Response.FuncionarioResponse
{
    public class ModeloTbLivroResponse
    {
        public int id {get;set;}
        public string livro {get;set;}
        public string autor {get;set;}
        public string genero {get;set;}
        public decimal? preco {get;set;}
        public int? paginas {get;set;}
        public string idiomaprimario {get;set;}
        public string sinopse {get;set;}
        public DateTime? publicacao {get;set;}

    }
}