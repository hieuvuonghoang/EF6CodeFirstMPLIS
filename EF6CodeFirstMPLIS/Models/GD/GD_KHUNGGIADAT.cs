namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class GD_KHUNGGIADAT
    {
        public string KHUNGGIADATID { get; set; }
        public string SOQUYETDINH { get; set; }
        public Nullable<System.DateTime> NGAYBANHANH { get; set; }
        public string FILEDINHKEM { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string uId { get; set; }
        public string TENFILE { get; set; }
        public string NOIDUNGTOMTAT { get; set; }
        public Nullable<decimal> MUCGIATOITHIEU { get; set; }
        public Nullable<decimal> MUCGIATOIDA { get; set; }
    }
}
