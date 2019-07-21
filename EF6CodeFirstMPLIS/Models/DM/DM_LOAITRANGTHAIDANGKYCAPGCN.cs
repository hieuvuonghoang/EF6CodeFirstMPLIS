namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAITRANGTHAIDANGKYCAPGCN
    {
        public string LOAITRANGTHAIDANGKYCAPGCNID { get; set; }
        public string MALOAITRANGTHAIDANGKYCAPGCN { get; set; }
        public string TENLOAITRANGTHAIDANGKYCAPGCN { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
