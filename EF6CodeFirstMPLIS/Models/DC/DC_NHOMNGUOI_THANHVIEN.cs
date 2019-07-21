namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_NHOMNGUOI_THANHVIEN
    {
        public string NHOMNGUOITHANHVIENID { get; set; }
        public string NHOMNGUOIID { get; set; }
        public string LOAIDOITUONG { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string THANHPHANID { get; set; }
    
        public virtual DC_NHOMNGUOI DC_NHOMNGUOI { get; set; }
    }
}
