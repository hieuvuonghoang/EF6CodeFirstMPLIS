namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class LOAIHOSO_DONVIAPDUNG
    {
        public string LOAIHOSODONVIAPDUNGID { get; set; }
        public string NHOMNGUOIDUNGID { get; set; }
        public string LOAIHOSOID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    }
}
