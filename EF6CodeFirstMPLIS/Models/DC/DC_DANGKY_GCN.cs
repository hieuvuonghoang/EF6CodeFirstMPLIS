namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_DANGKY_GCN
    {
        public string DONDANGKYID { get; set; }
        public string GIAYCHUNGNHANID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string uId { get; set; }
        public string DANGKYGCNID { get; set; }
    
        public virtual DC_DONDANGKY DC_DONDANGKY { get; set; }
        public virtual DC_GIAYCHUNGNHAN DC_GIAYCHUNGNHAN { get; set; }
    }
}
