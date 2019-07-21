namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class QH_BIEUBANGCAPHUYEN
    {
        public string BIEUBANGID { get; set; }
        public string TENBIEU { get; set; }
        public string TENCHITIET { get; set; }
        public Nullable<decimal> NAM { get; set; }
        public string QUYHOACHCAPHUYENID { get; set; }
    }
}
