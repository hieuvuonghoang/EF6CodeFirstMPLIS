namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class HS_TC_CHU
    {
        public string TCCHUID { get; set; }
        public string TENCHU { get; set; }
        public string DIACHI { get; set; }
        public string CHUID { get; set; }
        public string SOGIAYTOXM { get; set; }
        public string HOSOID { get; set; }
    
        public virtual HS_HOSO HS_HOSO { get; set; }
    }
}
