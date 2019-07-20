namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HT_NGUOIDUNG_QUYEN
    {
        public string NGUOIDUNGQUYENID { get; set; }
        public string NGUOIDUNGID { get; set; }
        public string QUYENID { get; set; }
        public Nullable<bool> KICHHOATQUYEN { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    
        public virtual HT_NGUOIDUNG HT_NGUOIDUNG { get; set; }
        public virtual HT_QUYEN HT_QUYEN { get; set; }
    }
}
