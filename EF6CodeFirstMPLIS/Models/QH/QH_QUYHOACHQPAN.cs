namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QH_QUYHOACHQPAN
    {
        public QH_QUYHOACHQPAN()
        {
            this.QH_DINHKEMQUYHOACHQPAN = new HashSet<QH_DINHKEMQUYHOACHQPAN>();
        }
    
        public string QUYHOACHQPANID { get; set; }
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
        public string TENDUAN { get; set; }
        public string FILEBANDO { get; set; }
        
        public virtual ICollection<QH_DINHKEMQUYHOACHQPAN> QH_DINHKEMQUYHOACHQPAN { get; set; }
    }
}
