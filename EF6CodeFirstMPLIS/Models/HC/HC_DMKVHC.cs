namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HC_DMKVHC
    {
        public HC_DMKVHC()
        {
            this.DC_KHUVUC = new HashSet<DC_KHUVUC>();
            this.DC_TAILIEUDODAC = new HashSet<DC_TAILIEUDODAC>();
            this.DC_THUADAT = new HashSet<DC_THUADAT>();
            this.QT_BUOCQT_CAUHINH = new HashSet<QT_BUOCQT_CAUHINH>();
            this.HS_HOSO = new HashSet<HS_HOSO>();
            this.HS_LIENKETTHUADAT = new HashSet<HS_LIENKETTHUADAT>();
            this.HS_LICHSU = new HashSet<HS_LICHSU>();
            this.HT_XA_NGUOIDUNG = new HashSet<HT_XA_NGUOIDUNG>();
            this.HT_XA_TOCHUC = new HashSet<HT_XA_TOCHUC>();
        }
    
        public string KVHCID { get; set; }
        public string HUYENID { get; set; }
        public string MAXA { get; set; }
        public string TENKVHC { get; set; }
        public string PHANLOAI { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string MAKVHC { get; set; }
        
        public virtual ICollection<DC_KHUVUC> DC_KHUVUC { get; set; }
        public virtual ICollection<DC_TAILIEUDODAC> DC_TAILIEUDODAC { get; set; }
        public virtual ICollection<DC_THUADAT> DC_THUADAT { get; set; }
        public virtual HC_HUYEN HC_HUYEN { get; set; }
        public virtual ICollection<QT_BUOCQT_CAUHINH> QT_BUOCQT_CAUHINH { get; set; }
        public virtual ICollection<HS_HOSO> HS_HOSO { get; set; }
        public virtual ICollection<HS_LIENKETTHUADAT> HS_LIENKETTHUADAT { get; set; }
        public virtual ICollection<HS_LICHSU> HS_LICHSU { get; set; }
        public virtual ICollection<HT_XA_NGUOIDUNG> HT_XA_NGUOIDUNG { get; set; }
        public virtual ICollection<HT_XA_TOCHUC> HT_XA_TOCHUC { get; set; }
    }
}
