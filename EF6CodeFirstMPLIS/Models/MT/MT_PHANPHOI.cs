namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class MT_PHANPHOI
    {
        public string PHANPHOIID { get; set; }
        public string TENTEP { get; set; }
        public string PHIENBAN { get; set; }
        public string MOTA { get; set; }
        public string GHICHU { get; set; }
        public string DUONGDANPHANPHOI { get; set; }
        public string MLANDDATAID { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    }
}
