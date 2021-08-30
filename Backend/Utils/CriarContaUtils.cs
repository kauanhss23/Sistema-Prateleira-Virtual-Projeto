using System;
using System.Collections;

namespace backend.Utils
{
    public class CriarContaUtils
    {
        public Models.TbLogin loginparatb(Models.Request.CriarContaRequest req)
        {
            Models.TbLogin ctx = new Models.TbLogin();

            ctx.DsEmail = req.conta.email;
            ctx.DsSenha = req.conta.senha;
            ctx.DsPerfil = "cliente";

            return ctx;
        
        }

        public Models.Response.EmailResponse TbEmailParaEmailRes(Models.TbLogin tb)
        {
            Models.Response.EmailResponse ctx = new Models.Response.EmailResponse();

            ctx.idlogin = tb.IdLogin;
            ctx.email = tb.DsEmail;
            ctx.senha = tb.DsSenha;
            ctx.perfil = tb.DsPerfil;

            return ctx;
        }

        public Models.TbLogin LogigReqForTbLogin(Models.Request.EmailRequest login)
        {
            Models.TbLogin x = new Models.TbLogin();

            x.DsEmail = login.email;
            x.DsSenha = login.senha;
            x.DsPerfil = "cliente";

            return x;
        }
  
        public Models.TbCliente clienteparatb(Models.Request.CriarContaRequest req, Models.TbLogin conta)
        {
            Models.TbCliente ctx = new Models.TbCliente();

            ctx.NmCliente = req.InformacoesCliente.nome;
            ctx.DtNascimento = req.InformacoesCliente.nascimento;
            ctx.DsCpf = req.InformacoesCliente.cpf;
            ctx.DsRg = req.InformacoesCliente.rg;
            ctx.DsCartaoCredito = req.InformacoesCliente.cartaocredito;
            ctx.DsEndereco = req.InformacoesCliente.endereco;
            ctx.DsTelefone = req.InformacoesCliente.telefone;
            ctx.IdLogin = conta.IdLogin;

            return ctx;
        }

        public Models.Response.InformacoesClienteResponse TbClienteparaClienteRes(Models.TbCliente tb)
        {
            Models.Response.InformacoesClienteResponse ctx = new Models.Response.InformacoesClienteResponse();

            ctx.idcliente = tb.IdCliente;
            ctx.nome = tb.NmCliente;
            ctx.nascimento = tb.DtNascimento;
            ctx.cpf = tb.DsCpf;
            ctx.rg = tb.DsRg;
            ctx.cartaocredito = tb.DsCartaoCredito;
            ctx.endereco = tb.DsEndereco;
            ctx.telefone = tb.DsTelefone;
            ctx.idlogin = tb.IdLogin;

            return ctx;
        }

        public Models.TbCliente ClienteReqForTbCliente(Models.Request.InformacoesClienteRequest req, Models.TbLogin conta)
        {
            Models.TbCliente x = new Models.TbCliente();

            x.NmCliente = req.nome;
            x.DtNascimento = req.nascimento;
            x.DsCpf = req.cpf;
            x.DsRg = req.rg;
            x.DsCartaoCredito = req.cartaocredito;
            x.DsEndereco = req.endereco;
            x.DsTelefone = req.telefone;
            x.IdLogin = conta.IdLogin;

            return x;
        }
    }
}