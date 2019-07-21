namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_KHOANDUOCTRU
    {
        public string KHOANDUOCTRUID { get; set; }
        public string TENKHOANDUOCTRU { get; set; }
        public Nullable<decimal> SOTIEN { get; set; }
        public string GHICHU { get; set; }
        public string NGUOIID { get; set; }
        public string NGHIAVUTAICHINHID { get; set; }
    
        public virtual DC_NGUOI DC_NGUOI { get; set; }
        public virtual DC_NGHIAVUTAICHINH DC_NGHIAVUTAICHINH { get; set; }
    }
}
