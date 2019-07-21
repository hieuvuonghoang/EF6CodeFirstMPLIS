namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_CONGTRINHNGAM
    {
        public string CONGTRINHNGAMID { get; set; }
        public string MAXA { get; set; }
        public string TENCONGTRINH { get; set; }
        public string LOAICONGTRINHNGAM { get; set; }
        public Nullable<decimal> DIENTICHCONGTRINH { get; set; }
        public Nullable<decimal> DOSAUTOIDA { get; set; }
        public string VITRIDAUNOI { get; set; }
        public Nullable<decimal> NAMXAYDUNG { get; set; }
        public Nullable<decimal> NAMHOANTHANH { get; set; }
        public string THOIHANSOHUU { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string HINHTHUCSOHUU { get; set; }
        public string DIACHI { get; set; }
    }
}
