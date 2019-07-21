namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_GCN_TILESH
    {
        public string GCNTILESHID { get; set; }
        public Nullable<decimal> TILESOHUU { get; set; }
        public string GIAYCHUNGNHANID { get; set; }
        public string NGUOIID { get; set; }
        public string THANHVIENID { get; set; }
        public string LOAIDTMIENGIAMID { get; set; }
    
        public virtual DC_GIAYCHUNGNHAN DC_GIAYCHUNGNHAN { get; set; }
        public virtual DC_NGUOI DC_NGUOI { get; set; }
        public virtual DM_LOAIDTMIENGIAM DM_LOAIDTMIENGIAM { get; set; }
    }
}
