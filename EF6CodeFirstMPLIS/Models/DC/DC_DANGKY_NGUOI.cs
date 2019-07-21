namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_DANGKY_NGUOI
    {
        public string DANGKYNGUOIID { get; set; }
        public string DONDANGKYID { get; set; }
        public string NGUOIID { get; set; }
        public string MOTATOMTAT { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<decimal> LOAI { get; set; }
        public Nullable<decimal> DENGHIDANGKY { get; set; }
        public Nullable<bool> CONHUCAUGHINONVTC { get; set; }
        public string DENGHIKHAC { get; set; }
    
        public virtual DC_DONDANGKY DC_DONDANGKY { get; set; }
        public virtual DC_NGUOI DC_NGUOI { get; set; }
    }
}
