namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class HT_QUYEN
    {
        public HT_QUYEN()
        {
            this.HT_NGUOIDUNG_QUYEN = new HashSet<HT_NGUOIDUNG_QUYEN>();
        }
    
        public string QUYENID { get; set; }
        public string CHUCNANGID { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string CONTROLLERNAME { get; set; }
        public string ACTIONNAME { get; set; }
        public string MOTA { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    
        public virtual HT_CHUCNANG HT_CHUCNANG { get; set; }
        public virtual ICollection<HT_NGUOIDUNG_QUYEN> HT_NGUOIDUNG_QUYEN { get; set; }
    }
}
