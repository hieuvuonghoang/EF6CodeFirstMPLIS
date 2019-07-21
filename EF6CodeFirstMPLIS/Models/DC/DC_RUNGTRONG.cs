namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_RUNGTRONG
    {
        public string RUNGTRONGID { get; set; }
        public string TENRUNG { get; set; }
        public string LOAICAYRUNG { get; set; }
        public Nullable<decimal> DIENTICH { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string THOIHANSOHUU { get; set; }
        public string HINHTHUCSOHUU { get; set; }
        public string DIACHI { get; set; }
    }
}
