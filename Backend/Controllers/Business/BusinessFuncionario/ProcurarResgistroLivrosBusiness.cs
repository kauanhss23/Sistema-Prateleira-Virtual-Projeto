using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace backend.Controllers.Business.BusinessFuncionario
{
    public class ProcurarResgistroLivrosBusiness
    {
        public List<Models.TbLivro> buscarlivros()
        {
            Database.ListagemTbDatabase listadelivros = new Database.ListagemTbDatabase();

            List<Models.TbLivro> livros = listadelivros.consultarTbLivros();

            if(livros.Count == 0)
                throw new ArgumentException("Não possuem Resgitros no Banco de Dados");

            return livros;
        }
    }
}