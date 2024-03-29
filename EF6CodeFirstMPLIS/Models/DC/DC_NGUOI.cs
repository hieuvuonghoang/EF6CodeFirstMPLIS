namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_NGUOI
    {
        public DC_NGUOI()
        {
            this.DC_BD_CHU = new HashSet<DC_BD_CHU>();
            this.DC_DANGKY_NGUOI = new HashSet<DC_DANGKY_NGUOI>();
            this.DC_GCN_TILESH = new HashSet<DC_GCN_TILESH>();
            this.DC_GIAYCHUNGNHAN = new HashSet<DC_GIAYCHUNGNHAN>();
            this.DC_KHOANDUOCTRU = new HashSet<DC_KHOANDUOCTRU>();
            this.DC_MIENGIAMNVTC = new HashSet<DC_MIENGIAMNVTC>();
            this.DC_NGUOI_DIACHI = new HashSet<DC_NGUOI_DIACHI>();
            this.DC_NONVTC = new HashSet<DC_NONVTC>();
            this.DC_QUYENSOHUUTAISAN = new HashSet<DC_QUYENSOHUUTAISAN>();
            this.DC_QUYENSUDUNGDAT = new HashSet<DC_QUYENSUDUNGDAT>();
            this.DC_QUYENQUANLYDAT = new HashSet<DC_QUYENQUANLYDAT>();
        }
    
        public string NGUOIID { get; set; }
        public string CHITIETID { get; set; }
        public string LOAIDOITUONGID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string DOITUONGSUDUNGID { get; set; }
        public string MADINHDANH { get; set; }
        public string MASOTHUE { get; set; }
        
        public virtual ICollection<DC_BD_CHU> DC_BD_CHU { get; set; }
        public virtual ICollection<DC_DANGKY_NGUOI> DC_DANGKY_NGUOI { get; set; }
        public virtual ICollection<DC_GCN_TILESH> DC_GCN_TILESH { get; set; }
        public virtual ICollection<DC_GIAYCHUNGNHAN> DC_GIAYCHUNGNHAN { get; set; }
        public virtual ICollection<DC_KHOANDUOCTRU> DC_KHOANDUOCTRU { get; set; }
        public virtual ICollection<DC_MIENGIAMNVTC> DC_MIENGIAMNVTC { get; set; }
        public virtual ICollection<DC_NGUOI_DIACHI> DC_NGUOI_DIACHI { get; set; }
        public virtual DM_DOITUONGSUDUNG DM_DOITUONGSUDUNG { get; set; }
        public virtual ICollection<DC_NONVTC> DC_NONVTC { get; set; }
        public virtual ICollection<DC_QUYENSOHUUTAISAN> DC_QUYENSOHUUTAISAN { get; set; }
        public virtual ICollection<DC_QUYENSUDUNGDAT> DC_QUYENSUDUNGDAT { get; set; }
        public virtual ICollection<DC_QUYENQUANLYDAT> DC_QUYENQUANLYDAT { get; set; }
    }
}
