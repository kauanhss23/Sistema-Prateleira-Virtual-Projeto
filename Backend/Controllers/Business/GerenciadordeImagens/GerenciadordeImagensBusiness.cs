using System;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace backend.Controllers.Business.GerenciadordeImagens
{
    public class GerenciadordeImagensBusiness
    {
        public string GerarNome(string arquivo)
        {
            string x  = Guid.NewGuid().ToString();
            x = x + Path.GetExtension(arquivo); 
            return arquivo;
        }   
        public void SalvarFoto(string arquivo,IFormFile imagem)
        {
            string direcaofoto = Path.Combine(AppContext.BaseDirectory,"Storage","Fotos",arquivo);
            using (FileStream fs = new FileStream(direcaofoto, FileMode.Create))
            {
                imagem.CopyTo(fs);
            }
        }
        public byte[] Lerfoto(string arquivo)
        {
            string direcaofoto = Path.Combine(AppContext.BaseDirectory,"Storage","Fotos",arquivo);
            byte[] foto = File.ReadAllBytes(direcaofoto);
            return foto;
        }
        public string GerarContnttype(string nome)
        {
            String extensao = Path.GetExtension(nome).Replace(".","");
            string x =  "application/" + extensao;
            return x;
        }
    }
}