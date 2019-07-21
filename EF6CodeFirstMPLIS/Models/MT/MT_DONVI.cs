namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MT_DONVI
    {
        public string DONVIID { get; set; }
        public string TENLOAIDONVI { get; set; }
        public string TENDONVI { get; set; }
        public string DIACHI { get; set; }
        public string NGUOIDAIDIEN { get; set; }
        public string CHUCVU { get; set; }
        public string VAITRO { get; set; }
        public string EMAIL { get; set; }
        public string DIENTHOAI { get; set; }
        public string GHICHU { get; set; }
        public string MLANDDATAID { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    }
}
