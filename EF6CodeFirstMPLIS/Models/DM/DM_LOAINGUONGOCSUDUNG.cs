namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAINGUONGOCSUDUNG
    {
        public DM_LOAINGUONGOCSUDUNG()
        {
            this.DC_NGUONGOCSUDUNG = new HashSet<DC_NGUONGOCSUDUNG>();
        }
    
        public string LOAINGUONGOCSUDUNGID { get; set; }
        public string MANGUONGOCSUDUNG { get; set; }
        public string TENNGUONGOCSUDUNG { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        
        public virtual ICollection<DC_NGUONGOCSUDUNG> DC_NGUONGOCSUDUNG { get; set; }
    }
}
