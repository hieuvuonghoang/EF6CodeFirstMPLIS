namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LS_TC_THUA
    {
        public string TCTHUAID { get; set; }
        public string SHTOBD { get; set; }
        public string STTTHUA { get; set; }
        public string MAKVHC { get; set; }
        public string BOHOSOID { get; set; }
        public string THUAID { get; set; }
        public string XAID { get; set; }
    
        public virtual LS_BOHOSO LS_BOHOSO { get; set; }
    }
}
