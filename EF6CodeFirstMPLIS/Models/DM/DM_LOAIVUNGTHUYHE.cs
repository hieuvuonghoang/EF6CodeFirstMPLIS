namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAIVUNGTHUYHE
    {
        public string LOAIVUNGTHUYHEID { get; set; }
        public string MALOAIVUNGTHUYHE { get; set; }
        public string TENLOAIVUNGTHUYHE { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
