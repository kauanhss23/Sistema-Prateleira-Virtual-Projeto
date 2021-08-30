using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class TbEmpregado
    {
        public int IdEmpregado { get; set; }
        public string NmEmpregado { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string DsCpf { get; set; }
        public string DsCep { get; set; }
        public string DsRg { get; set; }
        public string DsCarteiraTrabalho { get; set; }
        public string DsCargo { get; set; }
        public string DsCargaHorariaSemanal { get; set; }
        public decimal? VlSalario { get; set; }
        public int? IdLogin { get; set; }

        public virtual TbLogin IdLoginNavigation { get; set; }
    }
}
