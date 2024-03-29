namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_HOGIADINH
    {
        public string HOGIADINHID { get; set; }
        public string CHUHO { get; set; }
        public string VOCHONG { get; set; }
        public string DIACHI { get; set; }
        public string DIACHIID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string CMTCHUHO { get; set; }
        public string CMTVOCHONG { get; set; }
    }
}
