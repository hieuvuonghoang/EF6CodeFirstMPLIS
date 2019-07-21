namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QH_KHUCHUCNANGCAPHUYENGEO
    {
        public string KHUCHUCNANGCAPHUYENID { get; set; }
        public string MATINH { get; set; }
        public string MAHUYEN { get; set; }
        public string TENKHUCHUCNANG { get; set; }
        public string LOAIKHUCHUCNANGCAPHUYEN { get; set; }
        public Nullable<decimal> NAMQUYHOACH { get; set; }
        public string QHCHUCNANGCAPHUYENID { get; set; }
    }
}
