namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HT_TOCHUC_NGUOIDUNG
    {
        public string TOCHUCNGUOIDUNGID { get; set; }
        public string TOCHUCID { get; set; }
        public string NGUOIDUNGID { get; set; }
        public string CHUCVU { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    
        public virtual HT_NGUOIDUNG HT_NGUOIDUNG { get; set; }
        public virtual HT_TOCHUC HT_TOCHUC { get; set; }
    }
}
