namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAINHA
    {
        public DM_LOAINHA()
        {
            this.DC_NHARIENGLE = new HashSet<DC_NHARIENGLE>();
        }
    
        public string LOAINHAID { get; set; }
        public string MALOAINHA { get; set; }
        public string TENLOAINHA { get; set; }
        public string GHICHU { get; set; }

        public virtual ICollection<DC_NHARIENGLE> DC_NHARIENGLE { get; set; }
    }
}
