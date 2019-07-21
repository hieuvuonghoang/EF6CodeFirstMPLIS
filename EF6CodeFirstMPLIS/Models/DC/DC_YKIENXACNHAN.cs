namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_YKIENXACNHAN
    {
        public string YKIENXACNHANID { get; set; }
        public string XACNHANDONDANGKYID { get; set; }
        public string LOAIYKIEN { get; set; }
        public string NOIDUNGYKIEN { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    
        public virtual DC_XACNHANDONDANGKY DC_XACNHANDONDANGKY { get; set; }
    }
}
