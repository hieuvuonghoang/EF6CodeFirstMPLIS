namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CS_GIAYTOXACMINH
    {
        public string GIAYTOXACMINHID { get; set; }
        public string CHUKYSOID { get; set; }
        public Nullable<System.DateTime> THOIDIEMNOPXACMINH { get; set; }
        public byte[] FILESCAN { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string TENGIAYTO { get; set; }
    
        public virtual CS_CHUKYSO CS_CHUKYSO { get; set; }
    }
}
