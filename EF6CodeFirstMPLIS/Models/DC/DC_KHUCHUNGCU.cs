namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_KHUCHUNGCU
    {
        public DC_KHUCHUNGCU()
        {
            this.DC_NHACHUNGCU = new HashSet<DC_NHACHUNGCU>();
        }
    
        public string KHUCHUNGCUID { get; set; }
        public string MAXA { get; set; }
        public string TENKHU { get; set; }
        public Nullable<decimal> DIENTICHKHU { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string DIACHI { get; set; }
        
        public virtual ICollection<DC_NHACHUNGCU> DC_NHACHUNGCU { get; set; }
    }
}
