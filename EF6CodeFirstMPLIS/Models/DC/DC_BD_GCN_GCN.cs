namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_BD_GCN_GCN
    {
        public string BDGCNGCNID { get; set; }
        public string GCNCHAID { get; set; }
        public string GIAYCHUNGNHANID { get; set; }
    
        public virtual DC_GIAYCHUNGNHAN DC_GIAYCHUNGNHAN { get; set; }
        public virtual DC_GIAYCHUNGNHAN DC_GIAYCHUNGNHAN1 { get; set; }
    }
}
