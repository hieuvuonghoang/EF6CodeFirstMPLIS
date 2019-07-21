namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAICAPHANG
    {
        public DM_LOAICAPHANG()
        {
            this.DC_NHARIENGLE = new HashSet<DC_NHARIENGLE>();
        }
    
        public string LOAICAPHANGID { get; set; }
        public string MALOAICAPHANG { get; set; }
        public string TENLOAICAPHANG { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        
        public virtual ICollection<DC_NHARIENGLE> DC_NHARIENGLE { get; set; }
    }
}
