namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_NGANCHANNGUOI
    {
        public string NGANCHANNGUOIID { get; set; }
        public string THONGTINNGANCHANID { get; set; }
        public string NGUOIID { get; set; }
        public string HOVATEN { get; set; }
        public string SOGIAYTO { get; set; }
        public string DAICHI { get; set; }
        public string GHICHU { get; set; }
        public string QUOCTICHID { get; set; }
        public string DVHCID { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
    }
}
