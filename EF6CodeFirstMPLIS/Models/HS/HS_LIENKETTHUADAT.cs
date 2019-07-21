namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class HS_LIENKETTHUADAT
    {
        public string LIENKETTHUADATID { get; set; }
        public string KVHCID { get; set; }
        public string TOTHUAID { get; set; }
        public string HOSOID { get; set; }
        public string SOTO { get; set; }
        public string SOTHUA { get; set; }
        public string MOTA { get; set; }
        public string XAID { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string THUAID { get; set; }
    
        public virtual HC_DMKVHC HC_DMKVHC { get; set; }
        public virtual HS_HOSO HS_HOSO { get; set; }
    }
}
