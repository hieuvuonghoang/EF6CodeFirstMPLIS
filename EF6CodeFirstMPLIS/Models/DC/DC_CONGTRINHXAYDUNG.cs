namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_CONGTRINHXAYDUNG
    {
        public DC_CONGTRINHXAYDUNG()
        {
            this.DC_HANGMUCCONGTRINH = new HashSet<DC_HANGMUCCONGTRINH>();
        }
    
        public string CONGTRINHXAYDUNGID { get; set; }
        public string MAXA { get; set; }
        public string TENCONGTRINH { get; set; }
        public Nullable<decimal> DIENTICHXAYDUNG { get; set; }
        public Nullable<decimal> DIENTICHSAN { get; set; }
        public string SOTANG { get; set; }
        public Nullable<decimal> SOTANGHAM { get; set; }
        public Nullable<decimal> NAMXAYDUNG { get; set; }
        public Nullable<decimal> NAMHOANTHANH { get; set; }
        public string THOIHANSOHUU { get; set; }
        public string CAPHANG { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string HINHTHUCSOHUU { get; set; }
        public string DIACHI { get; set; }
        
        public virtual ICollection<DC_HANGMUCCONGTRINH> DC_HANGMUCCONGTRINH { get; set; }
    }
}
