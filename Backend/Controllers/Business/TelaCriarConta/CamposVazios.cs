using System;

namespace backend.Controllers.Business
{
    public class CamposVazios
    {
        public void CampoNome(Models.Request.InformacoesClienteRequest req)
        {
            if(string.IsNullOrEmpty(req.nome))
            throw new ArgumentException ("Necessario preencher o campo do nome");
        }

        public void CampoCpf(Models.Request.InformacoesClienteRequest req)
        {
            if(string.IsNullOrEmpty(req.cpf))
            throw new ArgumentException ("Voce precisa inserir o seu cpf");
        }
        public void CampoRg(Models.Request.InformacoesClienteRequest req)
        {
            if(string.IsNullOrEmpty(req.rg))
            throw new ArgumentException ("Necessario preencher o campo do rg");           
        }

        public void CampoCartaoCredito(Models.Request.InformacoesClienteRequest req)
        {
            if(string.IsNullOrEmpty(req.cartaocredito))
            throw new ArgumentException ("Para criar a conta necessitamos do numero do seu cartão de crédito");
        }

        public void CampoTelefone(Models.Request.InformacoesClienteRequest req)
        {
            if(string.IsNullOrEmpty(req.telefone))
            throw new ArgumentException ("Voce precisa inserir o seu numero de telefone");
        }

        public void CampoEndereco(Models.Request.InformacoesClienteRequest req)
        {
            if(string.IsNullOrEmpty(req.endereco))
            throw new ArgumentException ("Voce precisa inserir o seu endereço");
        }

    }
}