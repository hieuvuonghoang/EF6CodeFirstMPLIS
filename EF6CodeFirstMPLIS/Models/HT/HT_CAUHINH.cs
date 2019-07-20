namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HT_CAUHINH
    {
        public string CAUHINHID { get; set; }
        public string TENCAUHINH { get; set; }
        public string GIATRI { get; set; }
        public Nullable<byte> CAP { get; set; }
        public string MADONVIHANHCHINHID { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    }
}
