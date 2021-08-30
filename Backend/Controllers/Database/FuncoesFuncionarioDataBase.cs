using System;
using System.Linq;

namespace backend.Controllers.Database
{
    public class FuncoesFuncionarioDataBase
    {
        Models.TccContext db = new Models.TccContext();
        public Models.TbLivro apagar(Models.TbLivro id)
        {
            Models.TbLivro RegistroLivro = db.TbLivro.First(x => x.IdLivro == id.IdLivro);
            db.TbLivro.Remove(RegistroLivro);
            db.SaveChanges();

            return RegistroLivro;
        }

        public Models.TbLivro alterarlivro(Models.Request.RequestFuncionario.RequestLivroAlterar req)
        {
            Models.TbLivro atual = db.TbLivro.First(x => x.IdLivro == req.idlivro);
            atual.NmAutor = req.autor;
            atual.NmEditora = req.editora;
            atual.NmLivro = req.livro;
            atual.NrPaginas = req.paginas;
            atual.NrSerie = req.numeroserie;
            atual.TpIdiomaOriginal = req.idiomaprimario;
            atual.VlPreco = req.preco;
            atual.DsEdicaoLivro = req.edicaolivro;
            atual.DsGenero = req.genero;
            atual.DsSinopse = req.sinopse;
            atual.DtPublicacao = req.publicacao;

            db.SaveChanges();
            return atual;
        }
        public Models.TbLivro inserir(Models.TbLivro req)
        {
            db.TbLivro.Add(req);
            db.SaveChanges();

            return req;
        }
    }
}