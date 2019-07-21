namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_BIENDONG
    {
        public DC_BIENDONG()
        {
            this.DC_BD_CHU = new HashSet<DC_BD_CHU>();
            this.DC_BD_CHUYENHTSDD = new HashSet<DC_BD_CHUYENHTSDD>();
            this.DC_BD_CHUYENMDSDD = new HashSet<DC_BD_CHUYENMDSDD>();
            this.DC_BD_GCN = new HashSet<DC_BD_GCN>();
            this.DC_BD_THECHAP = new HashSet<DC_BD_THECHAP>();
            this.DC_BD_THUA = new HashSet<DC_BD_THUA>();
            this.DC_BD_TREN_GCN = new HashSet<DC_BD_TREN_GCN>();
            this.DC_THUEDAT = new HashSet<DC_THUEDAT>();
            this.LS_BD_GCN = new HashSet<LS_BD_GCN>();
            this.LS_BD_THUA = new HashSet<LS_BD_THUA>();
            this.LS_BOHOSO = new HashSet<LS_BOHOSO>();
        }
    
        public string BIENDONGID { get; set; }
        public string LOAIBIENDONGID { get; set; }
        public Nullable<System.DateTime> THOIDIEMBIENDONG { get; set; }
        public string MACOQUANTHUCHIEN { get; set; }
        public Nullable<decimal> SOTHUTU { get; set; }
        public string MABIENDONG { get; set; }
        public string NOIDUNGBIENDONG { get; set; }
        public string SOHOPDONG { get; set; }
        public Nullable<System.DateTime> NGAYHOPDONG { get; set; }
        public string NOIDUNGHOPDONG { get; set; }
        public string SOCONGCHUNG { get; set; }
        public string QUYENCONGCHUNG { get; set; }
        public Nullable<System.DateTime> NGAYCONGCHUNG { get; set; }
        public string NOICONGCHUNGID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string QUYETDINHID { get; set; }
        public string HOSOTIEPNHANID { get; set; }
        public string COTHUAXULY { get; set; }
        public Nullable<decimal> SOTHUTUBIENDONG { get; set; }
        public string MAHSTTDANGKY { get; set; }
        public Nullable<System.DateTime> NGAYTRUOCBA { get; set; }
        public string LYDOBIENDONG { get; set; }
        public string MAHOSOTHUTUCDANGKY { get; set; }
        public string NOICONGCHUNG { get; set; }
        public string MAKVHC { get; set; }
        
        public virtual ICollection<DC_BD_CHU> DC_BD_CHU { get; set; }
        public virtual ICollection<DC_BD_CHUYENHTSDD> DC_BD_CHUYENHTSDD { get; set; }
        public virtual ICollection<DC_BD_CHUYENMDSDD> DC_BD_CHUYENMDSDD { get; set; }
        public virtual ICollection<DC_BD_GCN> DC_BD_GCN { get; set; }
        public virtual ICollection<DC_BD_THECHAP> DC_BD_THECHAP { get; set; }
        public virtual ICollection<DC_BD_THUA> DC_BD_THUA { get; set; }
        public virtual ICollection<DC_BD_TREN_GCN> DC_BD_TREN_GCN { get; set; }
        public virtual DC_LOAIBIENDONG DC_LOAIBIENDONG { get; set; }
        public virtual DC_NOICONGCHUNG DC_NOICONGCHUNG { get; set; }
        public virtual ICollection<DC_THUEDAT> DC_THUEDAT { get; set; }
        public virtual ICollection<LS_BD_GCN> LS_BD_GCN { get; set; }
        public virtual ICollection<LS_BD_THUA> LS_BD_THUA { get; set; }
        public virtual ICollection<LS_BOHOSO> LS_BOHOSO { get; set; }
    }
}
