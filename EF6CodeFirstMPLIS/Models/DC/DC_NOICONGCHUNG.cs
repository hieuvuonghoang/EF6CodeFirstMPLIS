namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_NOICONGCHUNG
    {
        public DC_NOICONGCHUNG()
        {
            this.DC_BIENDONG = new HashSet<DC_BIENDONG>();
        }
    
        public string NOICONGCHUNGID { get; set; }
        public string TENNOICONGCHUNG { get; set; }
        public string DIACHI { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        
        public virtual ICollection<DC_BIENDONG> DC_BIENDONG { get; set; }
    }
}
