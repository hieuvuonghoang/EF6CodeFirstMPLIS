namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_GIAYTOTUYTHAN
    {
        public string GIAYTOTUYTHANID { get; set; }
        public string LOAIGIAYTOTUYTHANID { get; set; }
        public string CANHANID { get; set; }
        public string SOGIAYTO { get; set; }
        public Nullable<System.DateTime> NGAYCAP { get; set; }
        public string NOICAP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<bool> LAGIAYTOINGCN { get; set; }
    }
}
