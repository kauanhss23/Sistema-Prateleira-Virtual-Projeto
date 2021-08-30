using System;

namespace backend.Utils.FuncoesFuncionarioUtils
{
    public class RegistroLivroUtils
    {
        public Models.Response.ResponsedoFuncionario.RegistroLivroResponse registrolivroapagado (Models.TbLivro reg)
        {
            Models.Response.ResponsedoFuncionario.RegistroLivroResponse x = new Models.Response.ResponsedoFuncionario.RegistroLivroResponse();

            x.id = reg.IdLivro;
            x.livro = reg.NmLivro;
            x.autor = reg.NmAutor;
            x.genero = reg.DsGenero;
            x.preco = reg.VlPreco;

            return x;
        }
    }
}