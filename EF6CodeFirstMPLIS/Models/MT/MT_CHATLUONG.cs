namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class MT_CHATLUONG
    {
        public string MCHATLUONGID { get; set; }
        public string MUCCHATLUONG { get; set; }
        public string MOTA { get; set; }
        public string NGUONGOCDULIEU { get; set; }
        public string LOAIPHUONGPHAPDANHGIA { get; set; }
        public string PHUONGPHAPKIEMTRA { get; set; }
        public string KETLUANKIEMTRA { get; set; }
        public string MOTAKIEMTRA { get; set; }
        public string GIAITHICHKIEMTRA { get; set; }
        public string MLANDDATAID { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    }
}
