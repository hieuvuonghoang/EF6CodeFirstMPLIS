namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QH_CAPHUYEN
    {
        public string CAPHUYENID { get; set; }
        public string VUNGQUYHOACHCAPHUYENID { get; set; }
        public string MATINH { get; set; }
        public string MAHUYEN { get; set; }
        public string TENVUNGQUYHOACH { get; set; }
        public string MUCDICHSUDUNGQH { get; set; }
        public Nullable<decimal> NAMQUYHOACH { get; set; }
        public string QUYHOACHCAPHUYENID { get; set; }
    }
}
