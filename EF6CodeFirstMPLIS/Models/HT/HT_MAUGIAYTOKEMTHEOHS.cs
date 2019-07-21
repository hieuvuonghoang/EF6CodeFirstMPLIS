namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class HT_MAUGIAYTOKEMTHEOHS
    {
        public string MAUGIAYTOKEMTHEOHSID { get; set; }
        public string GIAYTOKEMTHEOHSID { get; set; }
        public Nullable<byte> CAP { get; set; }
        public string MADONVIHANHCHINHID { get; set; }
        public byte[] TEMPLATE { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    }
}
