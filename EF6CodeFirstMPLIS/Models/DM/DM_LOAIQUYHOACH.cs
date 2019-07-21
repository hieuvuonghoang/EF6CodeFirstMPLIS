namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_LOAIQUYHOACH
    {
        public string LOAIQUYHOACHID { get; set; }
        public string MALOAIQUYHOACH { get; set; }
        public string TENLOAIQUYHOACH { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
