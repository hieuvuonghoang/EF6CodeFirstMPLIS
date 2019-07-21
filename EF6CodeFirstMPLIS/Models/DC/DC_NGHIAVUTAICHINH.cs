namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_NGHIAVUTAICHINH
    {
        public DC_NGHIAVUTAICHINH()
        {
            this.DC_GTKEMTHEO = new HashSet<DC_GTKEMTHEO>();
            this.DC_KHOANDUOCTRU = new HashSet<DC_KHOANDUOCTRU>();
            this.DC_MIENGIAMNVTC = new HashSet<DC_MIENGIAMNVTC>();
            this.DC_NONVTC = new HashSet<DC_NONVTC>();
        }
    
        public string NGHIAVUTAICHINHID { get; set; }
        public string QUYENSUDUNGDATID { get; set; }
        public string QUYENSOHUUTAISANID { get; set; }
        public string LOAINGHIAVUTAICHINHID { get; set; }
        public Nullable<decimal> TONGSOTIEN { get; set; }
        public Nullable<decimal> TONGSOTIENMIENGIAM { get; set; }
        public Nullable<decimal> TONGSOTIENNO { get; set; }
        public Nullable<System.DateTime> NGAYBATDAU { get; set; }
        public string HOANTHANH { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string SOPHIEUCHUYEN { get; set; }
    
        
        public virtual ICollection<DC_GTKEMTHEO> DC_GTKEMTHEO { get; set; }
        public virtual ICollection<DC_KHOANDUOCTRU> DC_KHOANDUOCTRU { get; set; }
        public virtual DC_LOAINGHIAVUTAICHINH DC_LOAINGHIAVUTAICHINH { get; set; }
        public virtual ICollection<DC_MIENGIAMNVTC> DC_MIENGIAMNVTC { get; set; }
        public virtual ICollection<DC_NONVTC> DC_NONVTC { get; set; }
    }
}
