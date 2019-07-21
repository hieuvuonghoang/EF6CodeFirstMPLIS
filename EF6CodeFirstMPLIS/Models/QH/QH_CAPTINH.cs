namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QH_CAPTINH
    {
        public string CAPTINHID { get; set; }
        public string VUNGQUYHOACHCAPTINHID { get; set; }
        public string MATINH { get; set; }
        public string TENVUNGQUYHOACH { get; set; }
        public string MUCDICHSUDUNGQH { get; set; }
        public Nullable<decimal> NAMQUYHOACH { get; set; }
        public string QUYHOACHCAPTINHID { get; set; }
    }
}
