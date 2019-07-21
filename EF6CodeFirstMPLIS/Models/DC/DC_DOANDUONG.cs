namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_DOANDUONG
    {
        public DC_DOANDUONG()
        {
            this.DC_THUADAT = new HashSet<DC_THUADAT>();
        }
    
        public string DOANDUONGID { get; set; }
        public string TENDUONGID { get; set; }
        public string TINHID { get; set; }
        public string HUYENID { get; set; }
        public string MADOANDUONG { get; set; }
        public string MADOANDUONG_THUE { get; set; }
        public string TENDOANDUONG { get; set; }
        public Nullable<decimal> NAMBATDAU { get; set; }
        public Nullable<decimal> NAMKETTHUC { get; set; }
        public Nullable<bool> TRANGTHAI { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }

        public virtual ICollection<DC_THUADAT> DC_THUADAT { get; set; }
    }
}
