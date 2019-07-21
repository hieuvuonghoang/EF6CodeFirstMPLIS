namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_MUCDICHSUDUNGDAT
    {
        public DC_MUCDICHSUDUNGDAT()
        {
            this.DC_VITRITHUADAT = new HashSet<DC_VITRITHUADAT>();
            this.DC_NGUONGOCSUDUNG = new HashSet<DC_NGUONGOCSUDUNG>();
            this.DC_QUYENQUANLYDAT = new HashSet<DC_QUYENQUANLYDAT>();
            this.DC_QUYENSUDUNGDAT = new HashSet<DC_QUYENSUDUNGDAT>();
        }
    
        public string MUCDICHSUDUNGDATID { get; set; }
        public string THUADATID { get; set; }
        public Nullable<decimal> SOTHUTUMDSD { get; set; }
        public string MUCDICHSUDUNGID { get; set; }
        public string MUCDICHSUDUNGQHID { get; set; }
        public Nullable<decimal> DIENTICH { get; set; }
        public Nullable<decimal> SUDUNGCHUNG { get; set; }
        public string THOIHANSUDUNG { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<bool> LAMUCDICHCHINH { get; set; }
        public string MDSDGOCID { get; set; }
        public string DACAPQUYEN { get; set; }
        public string LOAITHOIHANSUDUNG { get; set; }
        public Nullable<System.DateTime> TUNGAY { get; set; }
        public Nullable<System.DateTime> DENNGAY { get; set; }
        public Nullable<decimal> DIENTICHPHAINOPTIEN { get; set; }
        public Nullable<decimal> DIENTICHKHONGPHAINOPTIEN { get; set; }
        public Nullable<decimal> SOLANCAPQUYEN { get; set; }
        public string NGUONGOCSDTH { get; set; }
        public string HINHTHUCSUDUNGID { get; set; }
    
        public virtual DM_MUCDICHSUDUNGQH DM_MUCDICHSUDUNGQH { get; set; }
        public virtual ICollection<DC_VITRITHUADAT> DC_VITRITHUADAT { get; set; }
        public virtual DM_MUCDICHSUDUNG DM_MUCDICHSUDUNG { get; set; }
        public virtual ICollection<DC_NGUONGOCSUDUNG> DC_NGUONGOCSUDUNG { get; set; }
        public virtual ICollection<DC_QUYENQUANLYDAT> DC_QUYENQUANLYDAT { get; set; }
        public virtual ICollection<DC_QUYENSUDUNGDAT> DC_QUYENSUDUNGDAT { get; set; }
        public virtual DM_HINHTHUCSUDUNGDAT DM_HINHTHUCSUDUNGDAT { get; set; }
    }
}
