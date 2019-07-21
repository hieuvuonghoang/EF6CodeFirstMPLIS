namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_BD_THUA_THUA
    {
        public string BDTHUATHUAID { get; set; }
        public string THUACHAID { get; set; }
        public string THUADATID { get; set; }
    
        public virtual DC_THUADAT DC_THUADAT { get; set; }
        public virtual DC_THUADAT DC_THUADAT1 { get; set; }
    }
}
