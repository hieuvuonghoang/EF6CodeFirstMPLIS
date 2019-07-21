namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_NGANCHANGIAYCHUNGNHAN
    {
        public string NGANCHANGIAYID { get; set; }
        public string THONGTINNGANCHANID { get; set; }
        public string GIAYCHUNGNHANID { get; set; }
        public string SOHIEUGIAYCHUNGNHAN { get; set; }
        public string SOHOSOGOC { get; set; }
        public string SOVAOSO { get; set; }
        public string CANCUCAPGIAY { get; set; }
        public Nullable<System.DateTime> NGAYCAPGIAYCHUNGNHAN { get; set; }
        public string GHICHU { get; set; }
        public string DVHCID { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    }
}
