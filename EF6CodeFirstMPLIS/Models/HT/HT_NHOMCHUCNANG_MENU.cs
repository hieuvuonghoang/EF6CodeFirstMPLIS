namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class HT_NHOMCHUCNANG_MENU
    {
        public string NHOMCHUCNANGMENUID { get; set; }
        public string MENUID { get; set; }
        public string NHOMCHUCNANGID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    
        public virtual HT_MENU HT_MENU { get; set; }
        public virtual HT_NHOMCHUCNANG HT_NHOMCHUCNANG { get; set; }
    }
}
