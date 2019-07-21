namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_SODIACHINHDIENTU_THUADAT
    {
        public string SODIACHINHTHUADATID { get; set; }
        public string THUADATID { get; set; }
        public string SOTHUA { get; set; }
        public string SOTOBANDO { get; set; }
        public string MADVHC { get; set; }
        public Nullable<System.DateTime> NGAYTAO { get; set; }
        public string FILEPATH { get; set; }
        public Nullable<System.DateTime> THOIDIEMKY { get; set; }
        public string NGUOIKY { get; set; }
        public string TINHTRANG { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string XAID { get; set; }
    }
}
