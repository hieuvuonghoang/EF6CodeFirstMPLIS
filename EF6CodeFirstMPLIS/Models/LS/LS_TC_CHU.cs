namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class LS_TC_CHU
    {
        public string TCCHUID { get; set; }
        public string TENCHU { get; set; }
        public string DIACHI { get; set; }
        public string BOHOSOID { get; set; }
        public string CHUID { get; set; }
        public string SOGIAYTOXM { get; set; }
        public string MAKVHC { get; set; }
    
        public virtual LS_BOHOSO LS_BOHOSO { get; set; }
    }
}
