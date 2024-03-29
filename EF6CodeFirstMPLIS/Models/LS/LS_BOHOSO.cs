namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class LS_BOHOSO
    {
        public LS_BOHOSO()
        {
            this.LS_TC_CHU = new HashSet<LS_TC_CHU>();
            this.LS_TC_GCN = new HashSet<LS_TC_GCN>();
            this.LS_TC_HOSO = new HashSet<LS_TC_HOSO>();
            this.LS_TC_THUA = new HashSet<LS_TC_THUA>();
        }
    
        public string BOHOSOID { get; set; }
        public string DATA { get; set; }
        public string BIENDONGID { get; set; }
        public Nullable<System.DateTime> NGAYPD { get; set; }
        public string MAKVHC { get; set; }
    
        public virtual DC_BIENDONG DC_BIENDONG { get; set; }
        public virtual ICollection<LS_TC_CHU> LS_TC_CHU { get; set; }
        public virtual ICollection<LS_TC_GCN> LS_TC_GCN { get; set; }
        public virtual ICollection<LS_TC_HOSO> LS_TC_HOSO { get; set; }
        public virtual ICollection<LS_TC_THUA> LS_TC_THUA { get; set; }
    }
}
