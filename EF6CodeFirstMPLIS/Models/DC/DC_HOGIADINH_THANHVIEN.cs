namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_HOGIADINH_THANHVIEN
    {
        public string HOGIADINHTVID { get; set; }
        public string HOGIADINHID { get; set; }
        public string CANHANID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string QHVOICHUHOID { get; set; }
    
        public virtual DM_QHVOICHUHO DM_QHVOICHUHO { get; set; }
    }
}
