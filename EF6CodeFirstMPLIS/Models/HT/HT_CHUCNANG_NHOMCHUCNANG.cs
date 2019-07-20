namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HT_CHUCNANG_NHOMCHUCNANG
    {
        public string NHOMCHUCNANGID { get; set; }
        public string CHUCNANGID { get; set; }
        public string uId { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    
        public virtual HT_CHUCNANG HT_CHUCNANG { get; set; }
        public virtual HT_NHOMCHUCNANG HT_NHOMCHUCNANG { get; set; }
    }
}
