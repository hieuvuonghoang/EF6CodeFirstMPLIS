namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_DANGKY_THUA
    {
        public string DANGKYTHUAID { get; set; }
        public string DONDANGKYID { get; set; }
        public string MOTATOMTAT { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<decimal> HINHTHUCSUDUNG { get; set; }
        public string THOIHANSUDUNG { get; set; }
        public string QUYENHANCHE { get; set; }
        public string THOIDIEMSUDUNGDAT { get; set; }
        public Nullable<decimal> DUDIEUKIENCAPGIAY { get; set; }
        public string LYDOKHONGDUDIEUKIEN { get; set; }
        public string THUADATID { get; set; }
        public Nullable<decimal> SOTHUTHUTHUA { get; set; }
        public Nullable<decimal> SOHIEUTOBANDO { get; set; }
        public string XAID { get; set; }
        public string MUCDICHSUDUNGDATID { get; set; }
    
        public virtual DC_DONDANGKY DC_DONDANGKY { get; set; }
    }
}
