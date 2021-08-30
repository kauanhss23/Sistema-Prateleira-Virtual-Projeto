using System;
using System.Collections;

namespace backend.Controllers.Business.BusinessFuncionario
{
    public class ValidarAlteracaoLivroParte2
    {
        BusinessFuncionario.VerificarParamentrosBusiness requisitos = new VerificarParamentrosBusiness();
        Database.FuncoesFuncionarioDataBase salvaralteracao = new Database.FuncoesFuncionarioDataBase();

        public Models.TbLivro UltimaParteParaAlterar(Models.Request.RequestFuncionario.RequestLivroAlterar req)
        {
            requisitos.ValidarAlteracaoautor(req);
            requisitos.ValidarAlteracaoedicaolivro(req);
            requisitos.ValidarAlteracaogenero(req);
            requisitos.ValidarAlteracaoidioma(req);
            requisitos.ValidarAlteracaonomeeditora(req);
            requisitos.ValidarAlteracaonomelivro(req);
            requisitos.ValidarAlteracaonumeropaginas(req);
            requisitos.ValidarAlteracaonumeroSerie(req);
            requisitos.ValidarAlteracaopreco(req);
            requisitos.ValidarAlteracaopublicacaolivro(req);
            requisitos.ValidarAlteracaosinopse(req);

            Models.TbLivro x = salvaralteracao.alterarlivro(req);
            return x;
        }
    }
}