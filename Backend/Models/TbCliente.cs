using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbCompra = new HashSet<TbCompra>();
        }

        public int IdCliente { get; set; }
        public string NmCliente { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string DsCpf { get; set; }
        public string DsRg { get; set; }
        public string DsCartaoCredito { get; set; }
        public string DsEndereco { get; set; }
        public string DsTelefone { get; set; }
        public int? IdLogin { get; set; }

        public virtual TbLogin IdLoginNavigation { get; set; }
        public virtual ICollection<TbCompra> TbCompra { get; set; }
    }
}
