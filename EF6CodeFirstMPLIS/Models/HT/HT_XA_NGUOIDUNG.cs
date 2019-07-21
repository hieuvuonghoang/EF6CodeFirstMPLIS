namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HT_XA_NGUOIDUNG
    {
        public string XANGUOIDUNGID { get; set; }
        public string KVHCID { get; set; }
        public string NGUOIDUNGID { get; set; }
        public string XAID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    
        public virtual HC_DMKVHC HC_DMKVHC { get; set; }
        public virtual HT_NGUOIDUNG HT_NGUOIDUNG { get; set; }
    }
}
