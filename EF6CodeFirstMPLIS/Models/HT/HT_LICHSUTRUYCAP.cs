namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HT_LICHSUTRUYCAP
    {
        public string LICHSUTRUYCAPID { get; set; }
        public string NGUOIDUNGID { get; set; }
        public Nullable<short> NAM { get; set; }
        public string LOAIHANHDONG { get; set; }
        public string MOTA { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    
        public virtual HT_NGUOIDUNG HT_NGUOIDUNG { get; set; }
    }
}
