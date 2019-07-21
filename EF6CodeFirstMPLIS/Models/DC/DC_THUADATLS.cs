namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_THUADATLS
    {
        public string THUADATLSID { get; set; }
        public string MAXA { get; set; }
        public Nullable<decimal> SOHIEUTOBANDO { get; set; }
        public Nullable<decimal> SOTHUTUTHUA { get; set; }
        public string SOHIEUTOBANDOCU { get; set; }
        public string SOTHUTUTHUACU { get; set; }
        public Nullable<decimal> DIENTICH { get; set; }
        public Nullable<decimal> DIENTICHPHAPLY { get; set; }
        public string TAILIEUDODACID { get; set; }
        public Nullable<decimal> LADOITUONGCHIEMDAT { get; set; }
        public string DIACHIID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string DIACHI { get; set; }
    }
}
