namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class HS_HOSO
    {
        public HS_HOSO()
        {
            this.HS_TC_CHU = new HashSet<HS_TC_CHU>();
            this.HS_TC_GCN = new HashSet<HS_TC_GCN>();
            this.HS_LICHSU = new HashSet<HS_LICHSU>();
            this.HS_THANHPHANHOSO = new HashSet<HS_THANHPHANHOSO>();
            this.HS_LIENKETTHUADAT = new HashSet<HS_LIENKETTHUADAT>();
        }
    
        public string HOSOID { get; set; }
        public string KVHCID { get; set; }
        public string XAID { get; set; }
        public string MAHOSO { get; set; }
        public string MAHOSO_ST { get; set; }
        public string MAHOSO_MB { get; set; }
        public string MAHOSO_TB { get; set; }
        public string MAHOSO_TAM { get; set; }
        public string TENHOSO { get; set; }
        public string SOTODAIDIEN { get; set; }
        public string SOTHUADAIDIEN { get; set; }
        public Nullable<System.DateTime> NGAYHOSO { get; set; }
        public string PHONG { get; set; }
        public string KE { get; set; }
        public string NGAN { get; set; }
        public string HOP { get; set; }
        public string TENHOP { get; set; }
        public string GHICHU { get; set; }
        public Nullable<bool> DALIENKETCSDL_KG { get; set; }
        public Nullable<bool> DALIENKETCSDL_TT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string OID { get; set; }
        public string HOSOTIEPNHANID { get; set; }
    
        public virtual HC_DMKVHC HC_DMKVHC { get; set; }
        public virtual ICollection<HS_TC_CHU> HS_TC_CHU { get; set; }
        public virtual ICollection<HS_TC_GCN> HS_TC_GCN { get; set; }
        public virtual ICollection<HS_LICHSU> HS_LICHSU { get; set; }
        public virtual ICollection<HS_THANHPHANHOSO> HS_THANHPHANHOSO { get; set; }
        public virtual ICollection<HS_LIENKETTHUADAT> HS_LIENKETTHUADAT { get; set; }
        public virtual QT_HOSOTIEPNHAN QT_HOSOTIEPNHAN { get; set; }
    }
}
