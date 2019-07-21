namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_NHACHUNGCU
    {
        public DC_NHACHUNGCU()
        {
            this.DC_CANHO = new HashSet<DC_CANHO>();
            this.DC_HANGMUCNGOAICANHO = new HashSet<DC_HANGMUCNGOAICANHO>();
        }
    
        public string NHACHUNGCUID { get; set; }
        public string KHUCHUNGCUID { get; set; }
        public string TENCHUNGCU { get; set; }
        public Nullable<decimal> DIENTICHXAYDUNG { get; set; }
        public Nullable<decimal> DIENTICHSAN { get; set; }
        public Nullable<decimal> TONGSOCAN { get; set; }
        public Nullable<decimal> SOTANG { get; set; }
        public Nullable<decimal> SOTANGHAM { get; set; }
        public Nullable<decimal> NAMXAYDUNG { get; set; }
        public Nullable<decimal> NAMHOANTHANH { get; set; }
        public string THOIHANSOHUU { get; set; }
        public string CAPHANG { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string MAXA { get; set; }
        public string DIACHI { get; set; }
    
        
        public virtual ICollection<DC_CANHO> DC_CANHO { get; set; }
        public virtual ICollection<DC_HANGMUCNGOAICANHO> DC_HANGMUCNGOAICANHO { get; set; }
        public virtual DC_KHUCHUNGCU DC_KHUCHUNGCU { get; set; }
    }
}
