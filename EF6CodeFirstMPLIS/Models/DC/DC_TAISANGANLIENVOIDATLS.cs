namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_TAISANGANLIENVOIDATLS
    {
        public string TAISANGANLIENVOIDATLSID { get; set; }
        public string TAISANLSID { get; set; }
        public string LOAITAISAN { get; set; }
        public string TENTAISAN { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
