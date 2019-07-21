namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_QUOCTICH
    {
        public DM_QUOCTICH()
        {
            this.DC_CANHAN = new HashSet<DC_CANHAN>();
        }
    
        public string QUOCTICHID { get; set; }
        public string MAQUOCGIA { get; set; }
        public string TENQUOCGIATV { get; set; }
        public string TENQUOCGIAQT { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        
        public virtual ICollection<DC_CANHAN> DC_CANHAN { get; set; }
    }
}
