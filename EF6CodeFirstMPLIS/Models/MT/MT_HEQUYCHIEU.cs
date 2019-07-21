namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class MT_HEQUYCHIEU
    {
        public string HEQUYCHIEUID { get; set; }
        public string TENHEQUYCHIEU { get; set; }
        public string MAHEQUYCHIEU { get; set; }
        public Nullable<System.DateTime> NGAYBANHANH { get; set; }
        public string MUICHIEU { get; set; }
        public string KINHTUYENTRUC { get; set; }
        public string MLANDDATAID { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    }
}
