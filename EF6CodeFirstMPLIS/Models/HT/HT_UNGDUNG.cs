namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HT_UNGDUNG
    {
        
        public HT_UNGDUNG()
        {
            this.HT_NHOMCHUCNANG = new HashSet<HT_NHOMCHUCNANG>();
        }
    
        public string UNGDUNGID { get; set; }
        public string TENUNGDUNG { get; set; }
        public string MOTA { get; set; }
        public byte[] ICON { get; set; }
        public string CHOPHEPSUDUNG { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string URL { get; set; }
        public string MAUNGDUNG { get; set; }
    
        
        public virtual ICollection<HT_NHOMCHUCNANG> HT_NHOMCHUCNANG { get; set; }
    }
}
