namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAIKHUCHUCNANGCAPHUYEN
    {
        public string LOAIKHUCHUCNANGCAPHUYENID { get; set; }
        public string MALOAIKHUCHUCNANGCAPHUYEN { get; set; }
        public string TENLOAIKHUCHUCNANGCAPHUYEN { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
