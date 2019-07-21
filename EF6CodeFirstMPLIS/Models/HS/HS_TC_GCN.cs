namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HS_TC_GCN
    {
        public string TCGCNID { get; set; }
        public string SOPHATHANH { get; set; }
        public string SOVAOSO { get; set; }
        public string MAVACH { get; set; }
        public string GCNID { get; set; }
        public string MAKVHC { get; set; }
        public string HOSOID { get; set; }
    
        public virtual HS_HOSO HS_HOSO { get; set; }
    }
}
