using System;

namespace backend.Controllers.Business.BusinessFuncionario
{
    public class InserirNovoLivroParte1
    {
        public void campovaziolivro(Models.TbLivro req)
        {
            if(string.IsNullOrEmpty(req.NmLivro))
                throw new ArgumentException("Voce precisa inserir o nome do livro");
                
            if(string.IsNullOrEmpty(req.NmAutor))
                throw new ArgumentException("Voce precisa inserir o nome do autor do livro");
        
            if(req.VlPreco == 0)
                throw new ArgumentException("Voce precisa definir um preço para o livro");
        
        
            if(string.IsNullOrEmpty(req.NmEditora))
                throw new ArgumentException("Voce precisa colocar o nome da editora do livro");
        
            if(req.NrPaginas == 0)
                throw new ArgumentException("Voce precisa inserir o nome do livro");
    
            if(string.IsNullOrEmpty(req.DsSinopse))
                throw new ArgumentException("Voce precisa inserir a sinopse do livro");
        
            if(req.DtPublicacao == null)
                throw new ArgumentException("Voce precisa inserir a data de publicacao do livro");
        
            if(string.IsNullOrEmpty(req.TpIdiomaOriginal))
                throw new ArgumentException("Voce precisa inserir o idioma do livro");
    
            if(string.IsNullOrEmpty(req.DsEdicaoLivro))
                throw new ArgumentException("Voce precisa inserir a edição do livro");
        
            if(string.IsNullOrEmpty(req.DsGenero))
                throw new ArgumentException("Voce precisa definir o genero do livro");

            if(string.IsNullOrEmpty(req.ImgImagem))
                throw new ArgumentException("imagem nao encontrada");

            if(string.IsNullOrEmpty(req.DsEdicaoLivro))
                throw new ArgumentException("Voce precisa Inserir a Edição do livro");

            if(string.IsNullOrEmpty(req.NrSerie))
                throw new ArgumentException("Voce Precisa colocar o numéro de serie do livro");
        }
    }

}
