namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_BD_THECHAP
    {
        
        public DC_BD_THECHAP()
        {
            this.DC_QUYENQUANLYDAT = new HashSet<DC_QUYENQUANLYDAT>();
            this.DC_QUYENSOHUUTAISAN = new HashSet<DC_QUYENSOHUUTAISAN>();
            this.DC_QUYENSUDUNGDAT = new HashSet<DC_QUYENSUDUNGDAT>();
        }
    
        public string BDTHECHAPID { get; set; }
        public Nullable<System.DateTime> NGAYNHANHS { get; set; }
        public Nullable<System.DateTime> NGAYTHECHAP { get; set; }
        public string QUYENSO { get; set; }
        public Nullable<decimal> SOTHUTU { get; set; }
        public Nullable<decimal> SODANGKY { get; set; }
        public Nullable<System.DateTime> NGAYBATDAU { get; set; }
        public Nullable<System.DateTime> NGAYKETTHUC { get; set; }
        public string BIENDONGID { get; set; }
    
        
        public virtual ICollection<DC_QUYENQUANLYDAT> DC_QUYENQUANLYDAT { get; set; }
        public virtual DC_BIENDONG DC_BIENDONG { get; set; }
        
        public virtual ICollection<DC_QUYENSOHUUTAISAN> DC_QUYENSOHUUTAISAN { get; set; }
        
        public virtual ICollection<DC_QUYENSUDUNGDAT> DC_QUYENSUDUNGDAT { get; set; }
    }
}
