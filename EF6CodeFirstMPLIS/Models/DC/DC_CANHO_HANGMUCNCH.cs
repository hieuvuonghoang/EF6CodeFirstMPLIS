namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_CANHO_HANGMUCNCH
    {
        public string CANHOHANGMUCNCHID { get; set; }
        public string HANGMUCSOHUUCHUNGID { get; set; }
        public string CANHOID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    
        public virtual DC_CANHO DC_CANHO { get; set; }
        public virtual DC_HANGMUCNGOAICANHO DC_HANGMUCNGOAICANHO { get; set; }
    }
}
