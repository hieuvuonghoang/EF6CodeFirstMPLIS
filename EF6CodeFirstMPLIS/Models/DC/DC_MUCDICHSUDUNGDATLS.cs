namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_MUCDICHSUDUNGDATLS
    {
        public string MUCDICHSUDUNGDATLSID { get; set; }
        public string THUADATLSID { get; set; }
        public Nullable<decimal> SOTHUTUMDSD { get; set; }
        public string MUCDICHSUDUNGID { get; set; }
        public string MUCDICHSUDUNGQHID { get; set; }
        public Nullable<decimal> DIENTICH { get; set; }
        public Nullable<decimal> SUDUNGCHUNG { get; set; }
        public string THOIHANSUDUNG { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    }
}
