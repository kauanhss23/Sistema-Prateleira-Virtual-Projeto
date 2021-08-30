using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace backend.Utils.TelaCriarConta
{
    public class AcessarUtils
    {
        public Models.Response.EmailPerfilResponse emailPerfil(Models.Request.EmailRequest req)
        {
            Models.TccContext db = new Models.TccContext();
            Models.TbLogin x = db.TbLogin.First(x=> x.DsEmail == req.email && x.DsSenha == req.senha);
        
            Models.Response.EmailPerfilResponse retorno = new Models.Response.EmailPerfilResponse();
            retorno.id = x.IdLogin;
            retorno.email = x.DsEmail;
            retorno.perfil = x.DsPerfil;

            return retorno;
        }

        public Models.Response.EmailPerfilResponse TbLoginParaLoginResponse(Models.TbLogin req)
        {
            Models.Response.EmailPerfilResponse x = new Models.Response.EmailPerfilResponse();
            
            x.id = req.IdLogin;
            x.email = req.DsEmail;
            x.perfil = req.DsPerfil;

            return x;
        }
    }
}