namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class GD_HSDCGIADAT
    {
        public string HSDCGIADATID { get; set; }
        public string SOQUYETDINH { get; set; }
        public Nullable<System.DateTime> NGAYBANHANH { get; set; }
        public Nullable<decimal> HESODIEUCHINH { get; set; }
        public Nullable<System.DateTime> NGAYHIEULUC { get; set; }
        public string FILEQUYETDINH { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string uId { get; set; }
        public string TENFILE { get; set; }
        public string NOIDUNGTOMTAT { get; set; }
    }
}
