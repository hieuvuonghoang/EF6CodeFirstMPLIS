namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAIBIENDONG
    {
        public string LOAIBIENDONGID { get; set; }
        public string MABIENDONG { get; set; }
        public string TENLOAIBIENDONG { get; set; }
        public string NGUOISUDUNG { get; set; }
        public string TRANGTHAI { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string uid { get; set; }
        public string VAITROCHUVAO { get; set; }
        public string VAITROCHURA { get; set; }
        public string TENBANGDULIEU { get; set; }
    }
}
