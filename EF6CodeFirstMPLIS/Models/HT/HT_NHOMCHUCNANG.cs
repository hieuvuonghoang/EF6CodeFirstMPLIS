namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HT_NHOMCHUCNANG
    {
        
        public HT_NHOMCHUCNANG()
        {
            this.HT_CHUCNANG_NHOMCHUCNANG = new HashSet<HT_CHUCNANG_NHOMCHUCNANG>();
            this.HT_NHOMCHUCNANG_MENU = new HashSet<HT_NHOMCHUCNANG_MENU>();
            this.HT_TOCHUC_NHOMCHUCNANG = new HashSet<HT_TOCHUC_NHOMCHUCNANG>();
        }
    
        public string NHOMCHUCNANGID { get; set; }
        public string UNGDUNGID { get; set; }
        public string URL { get; set; }
        public string TENNHOM { get; set; }
        public string MOTA { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    
        
        public virtual ICollection<HT_CHUCNANG_NHOMCHUCNANG> HT_CHUCNANG_NHOMCHUCNANG { get; set; }
        public virtual HT_UNGDUNG HT_UNGDUNG { get; set; }
        
        public virtual ICollection<HT_NHOMCHUCNANG_MENU> HT_NHOMCHUCNANG_MENU { get; set; }
        
        public virtual ICollection<HT_TOCHUC_NHOMCHUCNANG> HT_TOCHUC_NHOMCHUCNANG { get; set; }
    }
}
