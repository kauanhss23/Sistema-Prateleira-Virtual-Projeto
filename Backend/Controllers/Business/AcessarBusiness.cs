using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace backend.Controllers.Business.TelaCriarConta
{
    public class AcessarBusiness
    {
        public Models.TbLogin verificarcontaexistente(Models.Request.EmailRequest req)
        {
            Database.TabelasdoModeloDataBase tabelas = new Database.TabelasdoModeloDataBase();

            if(string.IsNullOrEmpty(req.email))
                throw new ArgumentException("é necessario preencher o campo do email");

            if(string.IsNullOrEmpty(req.senha))
                throw new ArgumentException("é necessario preencher o campo da senha");

            Models.TbLogin x = tabelas.VerificarExistenciaTbLogin(req);
            
            if(x == null)
                throw new ArgumentException("Esse usuario não existe");
            
            return x;
        }
    }
}