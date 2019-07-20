namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_BD_CHUYENHTSDD
    {
        public string BDCHUYENHTSDDID { get; set; }
        public string HINHTHUCSUDUNGID { get; set; }
        public string BIENDONGID { get; set; }
        public string LAHTSDDTRUOCKHICHUYEN { get; set; }
    
        public virtual DC_BIENDONG DC_BIENDONG { get; set; }
        public virtual DM_HINHTHUCSUDUNGDAT DM_HINHTHUCSUDUNGDAT { get; set; }
    }
}
