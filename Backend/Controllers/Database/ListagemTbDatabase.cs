using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace backend.Controllers.Database
{
    public class ListagemTbDatabase
    {
        Models.TccContext db = new Models.TccContext();
        public List<Models.TbLivro> consultarTbLivros()
        {
            List<Models.TbLivro> livros = db.TbLivro.ToList();
            return livros;
        }
        public Models.TbLivro Procurarlivro(int id)
        {
            Models.TbLivro x = db.TbLivro.FirstOrDefault(x => x.IdLivro == id);
            return x;
        }
        public List<Models.TbCompra> ProcurarcomprasMes()
        {
            DateTime agr = DateTime.Now;
            List<Models.TbCompra> compras = db.TbCompra.Where(x => x.DtCompra.Month == agr.Month).ToList();
            return compras;
        }
        public List<Models.TbEmpregado> ProcurarFuncionarios()
        {
            List<Models.TbEmpregado> funcionarios = db.TbEmpregado.Where(x => x.DsCargo == "funcionario").ToList();
            return funcionarios;
        }
        public List<Models.TbCompraLivro> Procurarcompralivro()
        {
            List<Models.TbCompraLivro> compraslivro = db.TbCompraLivro.ToList();
            return compraslivro;
        }
    
    }
}