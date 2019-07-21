namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAIKHUVUCTONGHOP
    {
        public string LOAIKHUVUCTONGHOPID { get; set; }
        public string MALOAIKHUVUCTONGHOP { get; set; }
        public string TENLOAIKHUVUCTONGHOP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
