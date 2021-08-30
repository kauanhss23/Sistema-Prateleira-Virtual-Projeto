using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace backend.Controllers.Business
{
    public class ClienteBusiness
    {
        public List<Models.Response.ClienteResponse.ModeloHistóricoCompra> VerificarExistencia(List<Models.Response.ClienteResponse.ModeloHistóricoCompra> db, Models.TbCliente idcliente)
        {
            List<Models.Response.ClienteResponse.ModeloHistóricoCompra> ctx = db.Where(x =>x.idcliente == idcliente.IdCliente).ToList();
            if(ctx.Count == 0)
                throw new ArgumentException("Voce não comprou nenhum livro");

            return ctx;
        }
        public Models.TbCliente VerificarConta(int idlogin)
        {
            Models.TccContext bd = new Models.TccContext();

            Models.TbLogin login = bd.TbLogin.FirstOrDefault(x =>x.IdLogin == idlogin);
            Models.TbCliente verificarconta = bd.TbCliente.FirstOrDefault(x => x.IdLogin == idlogin);

            if(login == null)
                throw new ArgumentException("Essa conta não existe");
            
            else if(login.DsPerfil != "cliente")
                throw new ArgumentException("Voce não é um usuário comum do sistema");
        
            else if(verificarconta == null)
                throw new ArgumentException("Este Usuário não existe");
            
            return verificarconta;
        }
        public void verificarsecomprou(int idlivro, int idcliente)
        {
            Models.TccContext db = new Models.TccContext();

            List<Models.TbCompraLivro> compras = db.TbCompraLivro.ToList();
            foreach(Models.TbCompraLivro item in compras)
            {
                if(item.IdLivro == idlivro && item.IdCompraNavigation.IdCliente == idcliente)
                    throw new ArgumentException("Você não pode comprar o mesmo livro >:C");
            } 
            
        }
    }
}