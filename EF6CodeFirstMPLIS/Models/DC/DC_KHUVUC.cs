namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_KHUVUC
    {
        public DC_KHUVUC()
        {
            this.DC_THUADAT = new HashSet<DC_THUADAT>();
        }
    
        public string KHUVUCID { get; set; }
        public string TENKHUVUC { get; set; }
        public string XAID { get; set; }
        public string KVHCID { get; set; }

        public virtual ICollection<DC_THUADAT> DC_THUADAT { get; set; }
        public virtual HC_DMKVHC HC_DMKVHC { get; set; }
    }
}
