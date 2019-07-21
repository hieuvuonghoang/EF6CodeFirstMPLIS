namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class QH_MDSD_CT
    {
        public string MDSDCTID { get; set; }
        public string MDSDID { get; set; }
        public string MAMDSD { get; set; }
        public Nullable<decimal> DIENTICH { get; set; }
        public string BIEUBANGCAPTINHID { get; set; }
    }
}
