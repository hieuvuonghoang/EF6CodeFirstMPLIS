namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LS_BD_THUA
    {
        public string BDTHUAID { get; set; }
        public string LICHSUTHUAID { get; set; }
        public string THUAHIENTAIID { get; set; }
        public string THUAID { get; set; }
        public string THUACHAID { get; set; }
        public Nullable<System.DateTime> NGAYPD { get; set; }
        public string BIENDONGID { get; set; }
        public string MAKVHC { get; set; }
    
        public virtual DC_BIENDONG DC_BIENDONG { get; set; }
    }
}
