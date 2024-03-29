namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_MUCDICHSUDUNGQH
    {
        public DM_MUCDICHSUDUNGQH()
        {
            this.DC_MUCDICHSUDUNGDAT = new HashSet<DC_MUCDICHSUDUNGDAT>();
        }
    
        public string MUCDICHSUDUNGQHID { get; set; }
        public string KHOACHAID { get; set; }
        public string MAMUCDICHSUDUNGQH { get; set; }
        public string TENMUCDICHSUDUNGQH { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string CANCUPHAPLY { get; set; }
        public string PHIENBAN { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<bool> CHITIET { get; set; }
        
        public virtual ICollection<DC_MUCDICHSUDUNGDAT> DC_MUCDICHSUDUNGDAT { get; set; }
    }
}
