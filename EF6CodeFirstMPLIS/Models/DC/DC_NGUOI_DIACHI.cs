namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_NGUOI_DIACHI
    {
        public string NGUOIDIACHIID { get; set; }
        public string NGUOIID { get; set; }
        public string DIACHIID { get; set; }
        public string MOTA { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPPHATID { get; set; }
        public string uId { get; set; }
    
        public virtual DC_DIACHI DC_DIACHI { get; set; }
        public virtual DC_NGUOI DC_NGUOI { get; set; }
    }
}
