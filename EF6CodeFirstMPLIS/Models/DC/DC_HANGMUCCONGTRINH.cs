namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_HANGMUCCONGTRINH
    {
        public string HANGMUCCONGTRINHID { get; set; }
        public string CONGTRINHXAYDUNGID { get; set; }
        public string TENHANGMUC { get; set; }
        public string CONGNANG { get; set; }
        public Nullable<decimal> DIENTICHXAYDUNG { get; set; }
        public Nullable<decimal> DIENTICHSAN { get; set; }
        public string SOTANG { get; set; }
        public Nullable<decimal> SOTANGHAM { get; set; }
        public string KETCAU { get; set; }
        public Nullable<decimal> NAMXAYDUNG { get; set; }
        public Nullable<decimal> NAMHOANTHANH { get; set; }
        public string THOIHANSOHUU { get; set; }
        public string CAPHANG { get; set; }
        public string DIACHIID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    
        public virtual DC_CONGTRINHXAYDUNG DC_CONGTRINHXAYDUNG { get; set; }
    }
}
