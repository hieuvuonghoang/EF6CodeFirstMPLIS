namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_TAISANGANLIENVOIDAT
    {
        public DC_TAISANGANLIENVOIDAT()
        {
            this.DC_QUYENSOHUUTAISAN = new HashSet<DC_QUYENSOHUUTAISAN>();
            this.DC_TAISAN_DIACHI = new HashSet<DC_TAISAN_DIACHI>();
            this.DC_THUATAISAN = new HashSet<DC_THUATAISAN>();
        }
    
        public string TAISANGANLIENVOIDATID { get; set; }
        public string TAISANID { get; set; }
        public string LOAITAISAN { get; set; }
        public string TENTAISAN { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string TRANGTHAI { get; set; }
        public string TAISANGOCID { get; set; }
        public Nullable<decimal> SOLANCAPQUYEN { get; set; }
        
        public virtual ICollection<DC_QUYENSOHUUTAISAN> DC_QUYENSOHUUTAISAN { get; set; }
        public virtual ICollection<DC_TAISAN_DIACHI> DC_TAISAN_DIACHI { get; set; }
        public virtual ICollection<DC_THUATAISAN> DC_THUATAISAN { get; set; }
    }
}
