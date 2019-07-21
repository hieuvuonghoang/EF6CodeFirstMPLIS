namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_VOCHONG
    {
        public string VOCHONGID { get; set; }
        public string CHONG { get; set; }
        public string VO { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string DIACHI { get; set; }
        public string CMTCHONG { get; set; }
        public string CMTVO { get; set; }
    }
}
