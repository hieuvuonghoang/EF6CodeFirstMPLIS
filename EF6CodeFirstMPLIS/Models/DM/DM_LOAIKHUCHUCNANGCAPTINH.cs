namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAIKHUCHUCNANGCAPTINH
    {
        public string LOAIKHUCHUCNANGCAPTINHID { get; set; }
        public string MALOAIKHUCHUCNANGCAPTINH { get; set; }
        public string TENLOAIKHUCHUCNANGCAPTINH { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
