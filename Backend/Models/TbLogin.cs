using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class TbLogin
    {
        public TbLogin()
        {
            TbCliente = new HashSet<TbCliente>();
            TbEmpregado = new HashSet<TbEmpregado>();
        }

        public int IdLogin { get; set; }
        public string DsEmail { get; set; }
        public string DsSenha { get; set; }
        public string DsPerfil { get; set; }

        public virtual ICollection<TbCliente> TbCliente { get; set; }
        public virtual ICollection<TbEmpregado> TbEmpregado { get; set; }
    }
}
