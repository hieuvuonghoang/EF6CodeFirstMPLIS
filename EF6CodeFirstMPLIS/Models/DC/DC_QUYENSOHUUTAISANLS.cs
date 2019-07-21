namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_QUYENSOHUUTAISANLS
    {
        public string QUYENSOHUUTAISANLSID { get; set; }
        public string BIENDONGID { get; set; }
        public Nullable<decimal> TRUOCBIENDONG { get; set; }
        public string NGUOILSID { get; set; }
        public string TAISANGANLIENVOIDATLSID { get; set; }
        public string NGHIAVUTAICHINHLSID { get; set; }
        public string GIAYCHUNGNHANLSID { get; set; }
        public string HANCHEQUYENSOHUULSID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string DONDANGKYID { get; set; }
    }
}
