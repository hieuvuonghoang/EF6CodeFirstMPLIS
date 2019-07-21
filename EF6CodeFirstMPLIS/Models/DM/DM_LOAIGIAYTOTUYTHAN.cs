namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_LOAIGIAYTOTUYTHAN
    {
        public string LOAIGIAYTOTUYTHANID { get; set; }
        public string MALOAIGIAYTOTUYTHAN { get; set; }
        public string TENLOAIGIAYTOTUYTHAN { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
