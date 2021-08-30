using System;

namespace backend.Controllers.Business
{
    public class RequisitosMinimos
    {
        public void CaracteresMinimoSenha(Models.Request.EmailRequest req)
        {
            if(req.senha.Length < 8)
                throw new ArgumentException("Necessario uma senha com mais de 8 caracteres");
        }

        public void VerificarEmail(Models.Request.EmailRequest req)
        {
            if(!req.email.Contains("@gmail.com"))
                throw new ArgumentException("tipo do email inserido invalido, tente outro");

        }

        public void CaracteresMinimosCpf(Models.Request.InformacoesClienteRequest req)
        {
            if(req.cpf.Length < 11)
                throw new ArgumentException("Numeros de caracteres do Cpf inválido");
        }

        public void CaracteresMinimosRg(Models.Request.InformacoesClienteRequest req)
        {
            if(req.rg.Length < 9)
                throw new ArgumentException("Numeros de caracteres do Rg inváldo");
        }

        public void CaracteresCartaodeCredito(Models.Request.InformacoesClienteRequest req)
        {
            if(req.cartaocredito.Length < 16)
                throw new ArgumentException("Quantidades de caracteres do cartão inválida, tente novamente");
        }

    }
}