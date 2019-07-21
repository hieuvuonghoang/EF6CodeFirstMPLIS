namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_LOAITAISANGANLIENVOIDAT
    {
        public string LOAITAISANGANLIENVOIDATID { get; set; }
        public string MALOAITAISANGANLIENVOIDAT { get; set; }
        public string TENLOAITAISANGANLIENVOIDAT { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
