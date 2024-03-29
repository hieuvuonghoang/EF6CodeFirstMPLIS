namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_DONDANGKY
    {
        public DC_DONDANGKY()
        {
            this.DC_DANGKY_GCN = new HashSet<DC_DANGKY_GCN>();
            this.DC_DANGKY_NGUOI = new HashSet<DC_DANGKY_NGUOI>();
            this.DC_DANGKY_THUA = new HashSet<DC_DANGKY_THUA>();
            this.DC_XACNHANDONDANGKY = new HashSet<DC_XACNHANDONDANGKY>();
        }
    
        public string DONDANGKYID { get; set; }
        public string MADON { get; set; }
        public Nullable<System.DateTime> NGAYDANGKY { get; set; }
        public string GHICHU { get; set; }
        public string DACAPGIAY { get; set; }
        public string CANCUPHAPLY { get; set; }
        public string SOVAOSO { get; set; }
        public Nullable<System.DateTime> NGAYCAP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string HOSOTIEPNHANID { get; set; }
        
        public virtual ICollection<DC_DANGKY_GCN> DC_DANGKY_GCN { get; set; }
        public virtual ICollection<DC_DANGKY_NGUOI> DC_DANGKY_NGUOI { get; set; }
        public virtual ICollection<DC_DANGKY_THUA> DC_DANGKY_THUA { get; set; }
        public virtual ICollection<DC_XACNHANDONDANGKY> DC_XACNHANDONDANGKY { get; set; }
    }
}
