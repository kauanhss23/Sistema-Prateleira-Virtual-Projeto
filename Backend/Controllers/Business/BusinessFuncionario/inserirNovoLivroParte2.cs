using System;
using System.Collections;

namespace backend.Controllers.Business.BusinessFuncionario
{
    public class inserirNovoLivroVerificar
    {
        InserirNovoLivroParte1 camposvazios = new InserirNovoLivroParte1();
        Database.FuncoesFuncionarioDataBase inserir = new Database.FuncoesFuncionarioDataBase();
        public Models.TbLivro verificarparametros(Models.TbLivro tb)
        {
            camposvazios.campovaziolivro(tb);

            Models.TbLivro x = inserir.inserir(tb);
            return x;
        }
    }
}