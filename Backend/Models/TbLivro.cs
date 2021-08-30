using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class TbLivro
    {
        public TbLivro()
        {
            TbCompraLivro = new HashSet<TbCompraLivro>();
        }

        public int IdLivro { get; set; }
        public string NmLivro { get; set; }
        public string NmAutor { get; set; }
        public string NrSerie { get; set; }
        public string NmEditora { get; set; }
        public int? NrPaginas { get; set; }
        public string DsSinopse { get; set; }
        public DateTime DtPublicacao { get; set; }
        public string TpIdiomaOriginal { get; set; }
        public string DsEdicaoLivro { get; set; }
        public string DsGenero { get; set; }
        public decimal VlPreco { get; set; }
        public string ImgImagem { get; set; }
        public string PdfLivro { get; set; }

        public virtual ICollection<TbCompraLivro> TbCompraLivro { get; set; }
    }
}
