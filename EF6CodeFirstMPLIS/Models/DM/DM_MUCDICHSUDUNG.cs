namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_MUCDICHSUDUNG
    {
        public DM_MUCDICHSUDUNG()
        {
            this.DC_BD_CHUYENMDSDD = new HashSet<DC_BD_CHUYENMDSDD>();
            this.DC_MUCDICHSUDUNGDAT = new HashSet<DC_MUCDICHSUDUNGDAT>();
            this.DC_THUEDAT = new HashSet<DC_THUEDAT>();
        }
    
        public string MUCDICHSUDUNGID { get; set; }
        public string KHOACHAID { get; set; }
        public string MAMUCDICHSUDUNG { get; set; }
        public string TENMUCDICHSUDUNG { get; set; }
        public string THUTUSAPXEP { get; set; }
        public Nullable<byte> THOIHANMACDINH { get; set; }
        public string CANCUPHAPLY { get; set; }
        public string PHIENBAN { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<bool> CHITIET { get; set; }
        
        public virtual ICollection<DC_BD_CHUYENMDSDD> DC_BD_CHUYENMDSDD { get; set; }
        public virtual ICollection<DC_MUCDICHSUDUNGDAT> DC_MUCDICHSUDUNGDAT { get; set; }
        public virtual ICollection<DC_THUEDAT> DC_THUEDAT { get; set; }
    }
}
