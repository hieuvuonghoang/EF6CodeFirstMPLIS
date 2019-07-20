namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HC_HUYEN
    {
        
        public HC_HUYEN()
        {
            this.HC_DMKVHC = new HashSet<HC_DMKVHC>();
        }
    
        public string HUYENID { get; set; }
        public string TINHID { get; set; }
        public string MAHUYEN { get; set; }
        public string TENHUYEN { get; set; }
        public string PHANLOAI { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string MAKVHC { get; set; }
        
        public virtual ICollection<HC_DMKVHC> HC_DMKVHC { get; set; }
        public virtual HC_TINH HC_TINH { get; set; }
    }
}
