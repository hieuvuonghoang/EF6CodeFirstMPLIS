namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_TRANHCHAP
    {
        public string TRANHCHAPID { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<System.DateTime> NGAYPHATSINH { get; set; }
        public string CONTRANHCHAP { get; set; }
        public string GHICHU { get; set; }
        public string THUADATID { get; set; }
    
        public virtual DC_THUADAT DC_THUADAT { get; set; }
    }
}
