namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_NONVTC
    {
        public string NONVTCID { get; set; }
        public Nullable<decimal> DIENTICH { get; set; }
        public Nullable<System.DateTime> NGAYGHINO { get; set; }
        public string NOIDUNG { get; set; }
        public string NGUOIID { get; set; }
        public string LOAINGHIAVUTAICHINHID { get; set; }
        public Nullable<decimal> SOTIENNO { get; set; }
        public string NGHIAVUTAICHINHID { get; set; }
        public string DATRA { get; set; }
    
        public virtual DC_NGHIAVUTAICHINH DC_NGHIAVUTAICHINH { get; set; }
        public virtual DC_NGUOI DC_NGUOI { get; set; }
        public virtual DM_LOAINGHIAVUTAICHINH DM_LOAINGHIAVUTAICHINH { get; set; }
    }
}
