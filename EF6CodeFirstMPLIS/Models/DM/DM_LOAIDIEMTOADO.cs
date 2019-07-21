namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAIDIEMTOADO
    {
        public string LOAIDIEMTOADOID { get; set; }
        public string MALOAIDIEMTOADO { get; set; }
        public string TENLOAIDIEMTOADO { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
