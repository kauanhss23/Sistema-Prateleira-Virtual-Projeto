using System;
using System.Collections;

namespace backend.Controllers.Business.BusinessFuncionario
{
    public class VerificarParamentrosBusiness
    {
        public void ValidarAlteracaonomelivro (Models.Request.RequestFuncionario.RequestLivroAlterar request )
        {
            if(string.IsNullOrEmpty(request.livro))
                throw new ArgumentException("Necessario preencher o campo do livro");
        }
        
        public void ValidarAlteracaoautor (Models.Request.RequestFuncionario.RequestLivroAlterar request )
        {
            if(string.IsNullOrEmpty(request.autor))
                throw new ArgumentException("Necessario preencher o nome do autor");
        }
        
        public void ValidarAlteracaonomeeditora (Models.Request.RequestFuncionario.RequestLivroAlterar request )
        {
            if(string.IsNullOrEmpty(request.editora))
                throw new ArgumentException("Necessario preencher o campo da editora");
        }
        
        public void ValidarAlteracaogenero (Models.Request.RequestFuncionario.RequestLivroAlterar request )
        {
            if(string.IsNullOrEmpty(request.genero))
                throw new ArgumentException("Necessario preencher o campo genero");
        }

        public void ValidarAlteracaoedicaolivro (Models.Request.RequestFuncionario.RequestLivroAlterar request )
        {
            if(string.IsNullOrEmpty(request.edicaolivro))
                throw new ArgumentException("Necessario informar a edição do livro");
        }

        public void ValidarAlteracaopublicacaolivro (Models.Request.RequestFuncionario.RequestLivroAlterar request )
        {
            if(request.publicacao == null)
                throw new ArgumentException("Voce precisa preencher uma data de publicacao válida");
        }

        public void ValidarAlteracaonumeropaginas (Models.Request.RequestFuncionario.RequestLivroAlterar request )
        {
            if(request.paginas == 0 || request.paginas == null)
                throw new ArgumentException("Necessario colocar o numero de paginas");
        }

        public void ValidarAlteracaosinopse (Models.Request.RequestFuncionario.RequestLivroAlterar request )
        {
            if(string.IsNullOrEmpty(request.sinopse))
                throw new ArgumentException("Necessario colocar uma sinopse para o livro");
        }

        public void ValidarAlteracaoidioma (Models.Request.RequestFuncionario.RequestLivroAlterar request )
        {
            if(string.IsNullOrEmpty(request.idiomaprimario))
                throw new ArgumentException("Você precisa colocar o idioma original deste livro");
        }

        public void ValidarAlteracaopreco (Models.Request.RequestFuncionario.RequestLivroAlterar request )
        {
            if(request.preco == 0)
                throw new ArgumentException("Voce precisa definir um preço para esse livro");
        }

        public void ValidarAlteracaonumeroSerie (Models.Request.RequestFuncionario.RequestLivroAlterar request )
        {
            if(string.IsNullOrEmpty(request.numeroserie))
                throw new ArgumentException("Voce precisa colocar o numero de serie do livro");
        }
    }
}