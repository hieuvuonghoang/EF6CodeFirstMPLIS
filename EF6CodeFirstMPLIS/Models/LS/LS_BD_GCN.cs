namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class LS_BD_GCN
    {
        public string LSBDGCNID { get; set; }
        public string GCNHIENTAIID { get; set; }
        public string GCNID { get; set; }
        public string GCNCHAID { get; set; }
        public Nullable<System.DateTime> NGAYPD { get; set; }
        public string BIENDONGID { get; set; }
        public string MAKVHC { get; set; }
    
        public virtual DC_BIENDONG DC_BIENDONG { get; set; }
    }
}
