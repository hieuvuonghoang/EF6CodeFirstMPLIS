namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_QUYENSUDUNGDATSAUBD
    {
        public string QUYENSUDUNGDATSAUBDID { get; set; }
        public string NGUOIID { get; set; }
        public string THUADATID { get; set; }
        public string DAMUCDICHSUDUNGID { get; set; }
        public string NGHIAVUTAICHINHID { get; set; }
        public string HANCHEQUYENID { get; set; }
        public string GIAYCHUNGNHANID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string DONDANGKYID { get; set; }
        public string LAQUYENQUANLY { get; set; }
    }
}
