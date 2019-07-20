namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_BD_GCN
    {
        public string BDGCNID { get; set; }
        public string GIAYCHUNGNHANID { get; set; }
        public string BIENDONGID { get; set; }
        public string LAGCNVAO { get; set; }
    
        public virtual DC_BIENDONG DC_BIENDONG { get; set; }
        public virtual DC_GIAYCHUNGNHAN DC_GIAYCHUNGNHAN { get; set; }
    }
}
