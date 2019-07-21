namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QH_DINHKEMKCNCAPTINH
    {
        public string DINHKEMKCNCAPTINHID { get; set; }
        public string KHUCHUCNANGCAPTINHID { get; set; }
        public string TENFILE { get; set; }
        public Nullable<System.DateTime> NGAYTAOFILE { get; set; }
        public string NGUOICAPHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string GHICHU { get; set; }
    
        public virtual QH_KHUCHUCNANGCAPTINH QH_KHUCHUCNANGCAPTINH { get; set; }
    }
}
