namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QH_BIEUBANG
    {
        public string BIEUBANGID { get; set; }
        public string TENBIEU { get; set; }
        public string TENCHITIET { get; set; }
        public Nullable<decimal> NAM { get; set; }
        public string QUYHOACHID { get; set; }
        public Nullable<decimal> CAPQUYHOACH { get; set; }
    }
}
