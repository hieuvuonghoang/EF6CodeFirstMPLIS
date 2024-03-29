namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_HINHTHUCSUDUNGDAT
    {
        public DM_HINHTHUCSUDUNGDAT()
        {
            this.DC_BD_CHUYENHTSDD = new HashSet<DC_BD_CHUYENHTSDD>();
            this.DC_MUCDICHSUDUNGDAT = new HashSet<DC_MUCDICHSUDUNGDAT>();
        }
    
        public string HINHTHUCSUDUNGID { get; set; }
        public string TENHINHTHUCSUDUNG { get; set; }
        public string GHICHU { get; set; }
        public Nullable<decimal> STT { get; set; }
        
        public virtual ICollection<DC_BD_CHUYENHTSDD> DC_BD_CHUYENHTSDD { get; set; }
        public virtual ICollection<DC_MUCDICHSUDUNGDAT> DC_MUCDICHSUDUNGDAT { get; set; }
    }
}
