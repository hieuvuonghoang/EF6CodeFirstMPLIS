namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_BD_THUA
    {
        public string BDTHUAID { get; set; }
        public string THUADATID { get; set; }
        public string LOAITHUABD { get; set; }
        public string LADULIEULS { get; set; }
        public string BIENDONGID { get; set; }
    
        public virtual DC_BIENDONG DC_BIENDONG { get; set; }
        public virtual DC_THUADAT DC_THUADAT { get; set; }
    }
}
