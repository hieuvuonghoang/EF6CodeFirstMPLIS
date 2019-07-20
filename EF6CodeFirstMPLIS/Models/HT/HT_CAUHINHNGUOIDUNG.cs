namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HT_CAUHINHNGUOIDUNG
    {
        public string CAUHINHNGUOIDUNGID { get; set; }
        public string NGUOIDUNGID { get; set; }
        public string TENCAUHINH { get; set; }
        public string GIATRI { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    
        public virtual HT_NGUOIDUNG HT_NGUOIDUNG { get; set; }
    }
}
