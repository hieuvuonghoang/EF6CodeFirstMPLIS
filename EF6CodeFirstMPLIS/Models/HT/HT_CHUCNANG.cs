namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class HT_CHUCNANG
    {
        public HT_CHUCNANG()
        {
            this.HT_CHUCNANG1 = new HashSet<HT_CHUCNANG>();
            this.HT_CHUCNANG_NHOMCHUCNANG = new HashSet<HT_CHUCNANG_NHOMCHUCNANG>();
            this.HT_QUYEN = new HashSet<HT_QUYEN>();
        }
    
        public string CHUCNANGID { get; set; }
        public string KHOACHAID { get; set; }
        public string MACHUCNANG { get; set; }
        public string TENCHUCNANG { get; set; }
        public string URL { get; set; }
        public string MOTA { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string CHOPHEPSUDUNG { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<bool> THUCHIENTHUCONG { get; set; }
        public string CACBIENDAUVAO { get; set; }
        public string CACBIENDAURA { get; set; }
    
        public virtual ICollection<HT_CHUCNANG> HT_CHUCNANG1 { get; set; }
        public virtual HT_CHUCNANG HT_CHUCNANG2 { get; set; }
        public virtual ICollection<HT_CHUCNANG_NHOMCHUCNANG> HT_CHUCNANG_NHOMCHUCNANG { get; set; }
        public virtual ICollection<HT_QUYEN> HT_QUYEN { get; set; }
    }
}
