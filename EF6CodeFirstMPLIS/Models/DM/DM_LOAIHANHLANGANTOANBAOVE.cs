namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_LOAIHANHLANGANTOANBAOVE
    {
        public string LOAIHANHLANGANTOANBAOVEID { get; set; }
        public string MALOAIHANHLANGANTOANBAOVE { get; set; }
        public string TENLOAIHANHLANGANTOANBAOVE { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
