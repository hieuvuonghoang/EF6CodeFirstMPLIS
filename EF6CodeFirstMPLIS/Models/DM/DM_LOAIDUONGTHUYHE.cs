namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_LOAIDUONGTHUYHE
    {
        public string LOAIDUONGTHUYHEID { get; set; }
        public string MALOAIDUONGTHUYHE { get; set; }
        public string TENLOAIDUONGTHUYHE { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
