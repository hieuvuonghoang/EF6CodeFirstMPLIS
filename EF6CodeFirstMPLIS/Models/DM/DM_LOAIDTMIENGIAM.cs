namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAIDTMIENGIAM
    {
        public DM_LOAIDTMIENGIAM()
        {
            this.DC_GCN_TILESH = new HashSet<DC_GCN_TILESH>();
            this.DC_MIENGIAMNVTC = new HashSet<DC_MIENGIAMNVTC>();
        }
    
        public string LOAIDTMIENGIAMID { get; set; }
        public string TENLOAIDOITUONG { get; set; }
        public string GHICHU { get; set; }
        
        public virtual ICollection<DC_GCN_TILESH> DC_GCN_TILESH { get; set; }
        public virtual ICollection<DC_MIENGIAMNVTC> DC_MIENGIAMNVTC { get; set; }
    }
}
