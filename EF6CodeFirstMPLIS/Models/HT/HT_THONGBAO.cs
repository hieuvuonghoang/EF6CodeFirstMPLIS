namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HT_THONGBAO
    {
        public string ID { get; set; }
        public string NGUOIDUNGID { get; set; }
        public string NOIDUNG { get; set; }
        public string LINK { get; set; }
        public decimal DAXEM { get; set; }
        public System.DateTime NGAYNHAN { get; set; }
        public System.DateTime NGAYXEM { get; set; }
        public string TIEUDE { get; set; }
        public decimal VOHIEUHOA { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
    }
}
