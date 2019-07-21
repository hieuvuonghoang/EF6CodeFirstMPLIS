namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QH_DINHKEMKCNCAPHUYEN
    {
        public string DINHKEMKCNCAPHUYENID { get; set; }
        public string KHUCHUCNANGCAPHUYENID { get; set; }
        public string TENFILE { get; set; }
        public Nullable<System.DateTime> NGAYTAOFILE { get; set; }
        public string NGUOICAPHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string GHICHU { get; set; }
    
        public virtual QH_KHUCHUCNANGCAPHUYEN QH_KHUCHUCNANGCAPHUYEN { get; set; }
    }
}
