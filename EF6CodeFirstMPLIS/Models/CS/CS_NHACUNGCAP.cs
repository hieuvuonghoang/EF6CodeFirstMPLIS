namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CS_NHACUNGCAP
    {
        public CS_NHACUNGCAP()
        {
            this.CS_CHUKYSO = new HashSet<CS_CHUKYSO>();
        }
    
        public string NHACUNGCAPID { get; set; }
        public string TENNHACUNGCAP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string ROOTCA { get; set; }
        
        public virtual ICollection<CS_CHUKYSO> CS_CHUKYSO { get; set; }
    }
}
