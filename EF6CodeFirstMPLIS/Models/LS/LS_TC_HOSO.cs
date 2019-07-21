namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class LS_TC_HOSO
    {
        public string TCHOSOID { get; set; }
        public string SOBIENNHAN { get; set; }
        public string NGUOINOPHOSO { get; set; }
        public string DIACHI { get; set; }
        public string HOSOID { get; set; }
        public string BOHOSOID { get; set; }
        public string MAKVHC { get; set; }
        public Nullable<System.DateTime> NGAYNHANHOSO { get; set; }
        public Nullable<System.DateTime> NGAYTRAKETQUA { get; set; }
    
        public virtual LS_BOHOSO LS_BOHOSO { get; set; }
    }
}
