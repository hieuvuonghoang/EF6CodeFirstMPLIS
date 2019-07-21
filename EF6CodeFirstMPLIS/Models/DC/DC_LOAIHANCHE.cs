namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_LOAIHANCHE
    {
        public DC_LOAIHANCHE()
        {
            this.DC_HANCHE = new HashSet<DC_HANCHE>();
        }
    
        public string LOAIHANCHEID { get; set; }
        public string TENLOAIHANCHE { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        
        public virtual ICollection<DC_HANCHE> DC_HANCHE { get; set; }
    }
}
