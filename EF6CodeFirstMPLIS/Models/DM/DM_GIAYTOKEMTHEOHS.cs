namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_GIAYTOKEMTHEOHS
    {
        public string GIAYTOKEMTHEOHSID { get; set; }
        public string TENGIAYTOKEMTHEOHS { get; set; }
        public byte[] MAUGIAYTO { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string KYHIEU { get; set; }
    }
}
