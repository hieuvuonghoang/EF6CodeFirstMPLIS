namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_LOAIBIENDONG
    {
        public DC_LOAIBIENDONG()
        {
            this.DC_BIENDONG = new HashSet<DC_BIENDONG>();
        }
    
        public string LOAIBIENDONGID { get; set; }
        public string MALOAIBIENDONG { get; set; }
        public string TENLOAIBIENDONG { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        
        public virtual ICollection<DC_BIENDONG> DC_BIENDONG { get; set; }
    }
}
