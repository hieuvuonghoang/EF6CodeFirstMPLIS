namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_DIACHI
    {
        public DC_DIACHI()
        {
            this.DC_NGUOI_DIACHI = new HashSet<DC_NGUOI_DIACHI>();
            this.DC_TAISAN_DIACHI = new HashSet<DC_TAISAN_DIACHI>();
        }
    
        public string DIACHIID { get; set; }
        public string MAXA { get; set; }
        public string DIACHICHITIET { get; set; }
        public string TENDUONGPHO { get; set; }
        public string TENTODANPHO { get; set; }
        public string TENXA { get; set; }
        public string TENHUYEN { get; set; }
        public string TENTINH { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string DIACHIDAYDU { get; set; }
        
        public virtual ICollection<DC_NGUOI_DIACHI> DC_NGUOI_DIACHI { get; set; }
        public virtual ICollection<DC_TAISAN_DIACHI> DC_TAISAN_DIACHI { get; set; }
    }
}
