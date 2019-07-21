namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_THUADAT
    {
        public DC_THUADAT()
        {
            this.DC_BD_THUA = new HashSet<DC_BD_THUA>();
            this.DC_BD_THUA_THUA = new HashSet<DC_BD_THUA_THUA>();
            this.DC_BD_THUA_THUA1 = new HashSet<DC_BD_THUA_THUA>();
            this.DC_THUADAT_TAILIEUDODAC = new HashSet<DC_THUADAT_TAILIEUDODAC>();
            this.DC_THUADAT_TAISAN = new HashSet<DC_THUADAT_TAISAN>();
            this.DC_TRANHCHAP = new HashSet<DC_TRANHCHAP>();
            this.GD_GIATHUADAT = new HashSet<GD_GIATHUADAT>();
            this.DC_THUATAISAN = new HashSet<DC_THUATAISAN>();
        }
    
        public string THUADATID { get; set; }
        public string KVHCID { get; set; }
        public Nullable<decimal> SOHIEUTOBANDO { get; set; }
        public Nullable<decimal> SOTHUTUTHUA { get; set; }
        public string SOHIEUTOBANDOCU { get; set; }
        public string SOTHUTUTHUACU { get; set; }
        public Nullable<decimal> DIENTICH { get; set; }
        public Nullable<decimal> DIENTICHPHAPLY { get; set; }
        public string TAILIEUDODACID { get; set; }
        public Nullable<decimal> LADOITUONGCHIEMDAT { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string DIACHITHUADAT { get; set; }
        public string XAID { get; set; }
        public string DANGTRANHCHAP { get; set; }
        public string GEOMETRY { get; set; }
        public string TRANGTHAI { get; set; }
        public string THUAGOCID { get; set; }
        public string LOAITHUADAT { get; set; }
        public string HSKTFILEPATH { get; set; }
        public string GTQUYENSDD { get; set; }
        public string DOANDUONGID { get; set; }
        public string KHUVUCID { get; set; }
        
        public virtual ICollection<DC_BD_THUA> DC_BD_THUA { get; set; }
        public virtual ICollection<DC_BD_THUA_THUA> DC_BD_THUA_THUA { get; set; }
        public virtual ICollection<DC_BD_THUA_THUA> DC_BD_THUA_THUA1 { get; set; }
        public virtual DC_DOANDUONG DC_DOANDUONG { get; set; }
        public virtual DC_KHUVUC DC_KHUVUC { get; set; }
        public virtual DC_TAILIEUDODAC DC_TAILIEUDODAC { get; set; }
        public virtual HC_DMKVHC HC_DMKVHC { get; set; }
        public virtual ICollection<DC_THUADAT_TAILIEUDODAC> DC_THUADAT_TAILIEUDODAC { get; set; }
        public virtual ICollection<DC_THUADAT_TAISAN> DC_THUADAT_TAISAN { get; set; }
        public virtual ICollection<DC_TRANHCHAP> DC_TRANHCHAP { get; set; }
        public virtual ICollection<GD_GIATHUADAT> GD_GIATHUADAT { get; set; }
        public virtual ICollection<DC_THUATAISAN> DC_THUATAISAN { get; set; }
    }
}
