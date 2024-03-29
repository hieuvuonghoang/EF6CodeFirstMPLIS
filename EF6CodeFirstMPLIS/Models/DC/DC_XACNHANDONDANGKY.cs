namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_XACNHANDONDANGKY
    {
        public DC_XACNHANDONDANGKY()
        {
            this.DC_YKIENXACNHAN = new HashSet<DC_YKIENXACNHAN>();
        }
    
        public string XACNHANDONDANGKYID { get; set; }
        public string DONDANGKYID { get; set; }
        public Nullable<decimal> CAPXACNHAN { get; set; }
        public string DONVIHANHCHINHID { get; set; }
        public string TENCOQUANXACNHAN { get; set; }
        public string CANBOYKIENID { get; set; }
        public string CANBOKIEMTRAID { get; set; }
        public string CANBOPHEDUYETID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    
        public virtual DC_DONDANGKY DC_DONDANGKY { get; set; }
        public virtual ICollection<DC_YKIENXACNHAN> DC_YKIENXACNHAN { get; set; }
    }
}
