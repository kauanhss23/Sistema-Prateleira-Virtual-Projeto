using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace backend.Controllers.Database
{
    public class TabelasdoModeloDataBase
    {
        Models.TccContext db = new Models.TccContext();
        public Models.TbLogin VerificarExistenciaTbLogin(Models.Request.EmailRequest req)
        {
            Models.TbLogin x = db.TbLogin.FirstOrDefault(x => x.DsEmail == req.email && x.DsSenha == req.senha);
            return x;
        }

        public Models.TbLivro VerificarExistenciaTbLivro(int id)
        {
            Models.TbLivro x = db.TbLivro.FirstOrDefault(x => x.IdLivro == id);
            return x;
        }

    
    }
}