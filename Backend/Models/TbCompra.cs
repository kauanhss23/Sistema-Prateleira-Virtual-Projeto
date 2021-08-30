using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class TbCompra
    {
        public TbCompra()
        {
            TbCompraLivro = new HashSet<TbCompraLivro>();
        }

        public int IdCompra { get; set; }
        public DateTime DtCompra { get; set; }
        public decimal VlTotal { get; set; }
        public int? IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; }
        public virtual ICollection<TbCompraLivro> TbCompraLivro { get; set; }
    }
}
