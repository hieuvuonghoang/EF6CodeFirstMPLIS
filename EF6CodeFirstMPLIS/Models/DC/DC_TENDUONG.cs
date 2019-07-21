namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_TENDUONG
    {
        public string TENDUONGID { get; set; }
        public string TINHID { get; set; }
        public string HUYENID { get; set; }
        public Nullable<decimal> LOAIDUONG { get; set; }
        public string MADUONG { get; set; }
        public string MADUONG_THUE { get; set; }
        public string TENDUONG { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
