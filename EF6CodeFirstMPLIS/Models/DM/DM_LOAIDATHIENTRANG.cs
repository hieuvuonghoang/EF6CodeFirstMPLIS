namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAIDATHIENTRANG
    {
        public string LOAIDATHIENTRANGID { get; set; }
        public string KHOACHAID { get; set; }
        public string MALOAIDATHIENTRANG { get; set; }
        public string TENLOAIDATHIENTRANG { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string CANCUPHAPLY { get; set; }
        public string PHIENBAN { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<bool> CHITIET { get; set; }
    }
}
