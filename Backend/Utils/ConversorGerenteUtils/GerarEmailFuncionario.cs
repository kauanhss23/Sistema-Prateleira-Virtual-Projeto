using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace backend.Utils.ConversorGerenteUtils
{
    public class GerarEmailFuncionario
    {
        public Models.TbLogin criaremailfunc(Models.Request.RequestGerente.RequestGerente req)
        {
            Models.TbLogin conta = new Models.TbLogin();

            string primeironome = req.nomefuncionario.Substring(0, req.nomefuncionario.IndexOf(" "));
            int qtd = req.nomefuncionario.IndexOf(" ") + 1;
            string segundonome = req.nomefuncionario.Substring(req.nomefuncionario.LastIndexOf(" "));

            
            string email = primeironome + segundonome + "@gmail.com";
            string espacos = email.Replace(" ","_");

            int requestdia = req.nascimentofuncionario.Day;
            string dia = "";
            int requestmes = req.nascimentofuncionario.Month;
            string mes = "";

            if(requestdia < 10)
                dia = "0" + req.nascimentofuncionario.Day.ToString();
            else
                dia = req.nascimentofuncionario.Day.ToString();

            if(requestmes < 10)
                mes = "0" + req.nascimentofuncionario.Month.ToString();
            else
                mes = req.nascimentofuncionario.Month.ToString();

            string senha = dia + mes + req.nascimentofuncionario.Year.ToString();

            conta.DsEmail = espacos;
            conta.DsSenha = senha;
            conta.DsPerfil = "funcionario";

            return conta;
        }
    }
}