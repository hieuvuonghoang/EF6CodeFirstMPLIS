namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MT_GIOIHAN
    {
        public string GIOIHANID { get; set; }
        public string LOAIGIOIHAN { get; set; }
        public string TENGIOIHAN { get; set; }
        public string GIOIHANDONG { get; set; }
        public string GIOIHANTAY { get; set; }
        public string GIOIHANNAM { get; set; }
        public string GIOIHANBAC { get; set; }
        public string GIOIHANKHAC { get; set; }
        public string MLANDDATAID { get; set; }
        public string MCHATLUONGID { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    }
}
