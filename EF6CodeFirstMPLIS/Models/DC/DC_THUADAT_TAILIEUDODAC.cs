namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_THUADAT_TAILIEUDODAC
    {
        public string THUADATTAILIEUDODACID { get; set; }
        public string THUADATID { get; set; }
        public string TAILIEUDODACID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    
        public virtual DC_TAILIEUDODAC DC_TAILIEUDODAC { get; set; }
        public virtual DC_THUADAT DC_THUADAT { get; set; }
    }
}
