namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class HS_THANHPHANHOSO
    {
        public string THANHPHANHOSOID { get; set; }
        public string HOSOID { get; set; }
        public string GIAYTOKEMTHEOHSID { get; set; }
        public string TENTEPDULIEU { get; set; }
        public Nullable<decimal> KICHTHUOC { get; set; }
        public string DUONGDAN { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string OID { get; set; }
        public string SOBIENNHAN { get; set; }
    
        public virtual HS_HOSO HS_HOSO { get; set; }
    }
}
