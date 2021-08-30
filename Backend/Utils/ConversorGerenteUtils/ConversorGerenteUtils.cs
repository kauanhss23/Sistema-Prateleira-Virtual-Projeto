using System;
using System.Collections;
using System.Collections.Generic;

namespace backend.Utils.ConversorGerenteUtils
{
    public class ConversorGerenteUtils
    {
        public Models.TbEmpregado ConvertReqparaTbEmpregado(Models.Request.RequestGerente.RequestGerente req, Models.TbLogin req2)
        {
            Models.TbEmpregado ctx = new Models.TbEmpregado();

            ctx.NmEmpregado = req.nomefuncionario;
            ctx.DtNascimento = req.nascimentofuncionario;
            ctx.DsCpf = req.cpf;
            ctx.DsCep = req.cep;
            ctx.DsRg = req.rg;
            ctx.DsCarteiraTrabalho = req.carteiratrabalho;
            ctx.DsCargo = "funcionario";
            ctx.DsCargaHorariaSemanal = req.cargahorariasemanal;
            ctx.VlSalario = req.salario;
            ctx.IdLogin = req2.IdLogin;

            return ctx;
        }
        public Models.Response.GerenteResponse.FuncionarioGerenteResponse ConverttbparaResponse(Models.TbEmpregado req)
        {
            Models.Response.GerenteResponse.FuncionarioGerenteResponse ctx = new Models.Response.GerenteResponse.FuncionarioGerenteResponse();

            ctx.idfuncionario = req.IdEmpregado;
            ctx.nomefuncionario = req.NmEmpregado;
            ctx.nascimentofuncionario = req.DtNascimento;
            ctx.cpf = req.DsCpf;
            ctx.cep = req.DsCep;
            ctx.rg = req.DsRg;
            ctx.carteiratrabalho = req.DsCarteiraTrabalho;
            ctx.cargo = req.DsCargo;
            ctx.cargahorariasemanal = req.DsCargaHorariaSemanal;
            ctx.salario = req.VlSalario;
            ctx.idnovaconta = req.IdLogin;

            return ctx;
        }
        
        public Models.Response.GerenteResponse.ListarFuncResponse ConverterttoResponse(Models.TbEmpregado empregados)
        {
            Models.Response.GerenteResponse.ListarFuncResponse aaa = new Models.Response.GerenteResponse.ListarFuncResponse();

            aaa.cpf = empregados.DsCpf;
            aaa.nome = empregados.NmEmpregado;
            aaa.salario = empregados.VlSalario;
            aaa.carteira = empregados.DsCarteiraTrabalho;
            aaa.idconta = empregados.IdEmpregado;
            aaa.idlogin = empregados.IdLogin;
            aaa.nascimento = empregados.DtNascimento;
            aaa.rg = empregados.DsRg;
            aaa.cep = empregados.DsCep;
            aaa.carga = empregados.DsCargaHorariaSemanal;
            aaa.email = empregados.IdLoginNavigation.DsEmail;
            aaa.senha = empregados.IdLoginNavigation.DsSenha;

            return aaa;
        }

        public List<Models.Response.GerenteResponse.ListarFuncResponse> lists(List<Models.TbEmpregado> emp)
        {
            List<Models.Response.GerenteResponse.ListarFuncResponse> listar = new List<Models.Response.GerenteResponse.ListarFuncResponse>();
            foreach ( Models.TbEmpregado cadaum in emp)
            {
                listar.Add(ConverterttoResponse(cadaum));                
            }

            return listar;
        }

    }
}
