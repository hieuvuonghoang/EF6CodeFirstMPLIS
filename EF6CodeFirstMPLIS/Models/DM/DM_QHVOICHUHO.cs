namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_QHVOICHUHO
    {
        public DM_QHVOICHUHO()
        {
            this.DC_HOGIADINH_THANHVIEN = new HashSet<DC_HOGIADINH_THANHVIEN>();
        }
    
        public string QHVOICHUHOID { get; set; }
        public string TENQUANHE { get; set; }
        public string GHICHU { get; set; }
        public Nullable<decimal> STT { get; set; }
        
        public virtual ICollection<DC_HOGIADINH_THANHVIEN> DC_HOGIADINH_THANHVIEN { get; set; }
    }
}
