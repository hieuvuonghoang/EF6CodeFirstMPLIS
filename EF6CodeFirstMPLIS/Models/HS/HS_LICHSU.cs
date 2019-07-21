namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class HS_LICHSU
    {
        public string LICHSUHOSOID { get; set; }
        public string KVHCID { get; set; }
        public string XAID { get; set; }
        public string HOSOID { get; set; }
        public string HOSOTRUOCID { get; set; }
        public string HOSOSAUID { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string OID { get; set; }
    
        public virtual HC_DMKVHC HC_DMKVHC { get; set; }
        public virtual HS_HOSO HS_HOSO { get; set; }
    }
}
