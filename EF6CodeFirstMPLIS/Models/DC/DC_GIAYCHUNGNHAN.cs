namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_GIAYCHUNGNHAN
    {
        public DC_GIAYCHUNGNHAN()
        {
            this.DC_BD_GCN = new HashSet<DC_BD_GCN>();
            this.DC_BD_GCN_GCN = new HashSet<DC_BD_GCN_GCN>();
            this.DC_BD_GCN_GCN1 = new HashSet<DC_BD_GCN_GCN>();
            this.DC_BD_TREN_GCN = new HashSet<DC_BD_TREN_GCN>();
            this.DC_DANGKY_GCN = new HashSet<DC_DANGKY_GCN>();
            this.DC_GCN_TILESH = new HashSet<DC_GCN_TILESH>();
            this.DC_QUYENQUANLYDAT = new HashSet<DC_QUYENQUANLYDAT>();
            this.DC_QUYENSOHUUTAISAN = new HashSet<DC_QUYENSOHUUTAISAN>();
        }
    
        public string GIAYCHUNGNHANID { get; set; }
        public string SOPHATHANH { get; set; }
        public string MAVACH { get; set; }
        public string BANQUET { get; set; }
        public string NGUOIID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string DONDANGKYID { get; set; }
        public string SOVAOSO { get; set; }
        public Nullable<System.DateTime> NGAYCAP { get; set; }
        public string TRANGTHAIXULY { get; set; }
        public string TRANGTHAIPL { get; set; }
        public string MAXA { get; set; }
        public string HSKTFILEPATH { get; set; }
        public string GHICHU { get; set; }
        public string SOHUUCHUNGID { get; set; }
        public string TOCHUCID { get; set; }
        public string NONVTC { get; set; }
        
        public virtual ICollection<DC_BD_GCN> DC_BD_GCN { get; set; }
        public virtual ICollection<DC_BD_GCN_GCN> DC_BD_GCN_GCN { get; set; }
        public virtual ICollection<DC_BD_GCN_GCN> DC_BD_GCN_GCN1 { get; set; }
        public virtual ICollection<DC_BD_TREN_GCN> DC_BD_TREN_GCN { get; set; }
        public virtual ICollection<DC_DANGKY_GCN> DC_DANGKY_GCN { get; set; }
        public virtual ICollection<DC_GCN_TILESH> DC_GCN_TILESH { get; set; }
        public virtual ICollection<DC_QUYENQUANLYDAT> DC_QUYENQUANLYDAT { get; set; }
        public virtual DC_NGUOI DC_NGUOI { get; set; }
        public virtual ICollection<DC_QUYENSOHUUTAISAN> DC_QUYENSOHUUTAISAN { get; set; }
        public virtual HT_TOCHUC HT_TOCHUC { get; set; }
    }
}
