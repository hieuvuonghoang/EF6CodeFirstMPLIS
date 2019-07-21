namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_TAISAN_DIACHI
    {
        public string TAISANDIACHIID { get; set; }
        public string DIACHIID { get; set; }
        public string MOTA { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string TAISANGANLIENVOIDATID { get; set; }
    
        public virtual DC_DIACHI DC_DIACHI { get; set; }
        public virtual DC_TAISANGANLIENVOIDAT DC_TAISANGANLIENVOIDAT { get; set; }
    }
}
