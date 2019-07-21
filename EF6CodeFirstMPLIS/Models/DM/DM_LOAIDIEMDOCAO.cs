namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAIDIEMDOCAO
    {
        public string LOAIDIEMDOCAOID { get; set; }
        public string MALOAIDIEMDOCAO { get; set; }
        public string TENLOAIDIEMDOCAO { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
