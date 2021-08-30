using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class TbCompraLivro
    {
        public int IdCompraLivro { get; set; }
        public int? IdLivro { get; set; }
        public int? IdCompra { get; set; }

        public virtual TbCompra IdCompraNavigation { get; set; }
        public virtual TbLivro IdLivroNavigation { get; set; }
    }
}
