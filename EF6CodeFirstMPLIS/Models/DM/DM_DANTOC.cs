namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_DANTOC
    {
        public DM_DANTOC()
        {
            this.DC_CANHAN = new HashSet<DC_CANHAN>();
        }
    
        public string DANTOCID { get; set; }
        public string TENDANTOC { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string TENGOIKHAC { get; set; }
        
        public virtual ICollection<DC_CANHAN> DC_CANHAN { get; set; }
    }
}
