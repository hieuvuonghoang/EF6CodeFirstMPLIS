namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class QH_QUYHOACHCAPHUYEN
    {
        public QH_QUYHOACHCAPHUYEN()
        {
            this.QH_DINHKEMQUYHOACHCAPHUYEN = new HashSet<QH_DINHKEMQUYHOACHCAPHUYEN>();
        }
    
        public string QUYHOACHCAPHUYENID { get; set; }
        public string MATINH { get; set; }
        public string MAHUYEN { get; set; }
        public decimal NAMTHANHLAP { get; set; }
        public string TYLEBANDO { get; set; }
        public string NGUONTHANHLAP { get; set; }
        public string COQUANDUYET { get; set; }
        public string COQUANTHAMDINH { get; set; }
        public string COQUANLAP { get; set; }
        public string DONVITUVAN { get; set; }
        public Nullable<System.DateTime> NGAYPHEDUYET { get; set; }
        public string TENKYQUYHOACH { get; set; }
        public string FILEBANDO { get; set; }
        public string SOQUYETDINH { get; set; }
        public string FILEHIENTRANG { get; set; }
        public string FILETHUYETMINH { get; set; }

        public virtual ICollection<QH_DINHKEMQUYHOACHCAPHUYEN> QH_DINHKEMQUYHOACHCAPHUYEN { get; set; }
    }
}
