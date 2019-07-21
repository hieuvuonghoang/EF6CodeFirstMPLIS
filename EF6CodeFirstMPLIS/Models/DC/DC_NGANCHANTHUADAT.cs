namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_NGANCHANTHUADAT
    {
        public string NGANCHANTHUADATID { get; set; }
        public string THONGTINNGANCHANID { get; set; }
        public string THUADATID { get; set; }
        public string DVHCID { get; set; }
        public Nullable<decimal> SOTHUA { get; set; }
        public Nullable<decimal> SOTOBANDO { get; set; }
        public string DIACHITHUADAT { get; set; }
        public string SOTHUATAM { get; set; }
        public string SOTOBANDOTAM { get; set; }
        public string GHICHU { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
    }
}
