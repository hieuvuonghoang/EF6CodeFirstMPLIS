namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_MIENGIAMNVTC
    {
        public string MIENGIAMNVTCID { get; set; }
        public string NGHIAVUTAICHINHID { get; set; }
        public string LOAICHEDOMIENGIAMID { get; set; }
        public Nullable<decimal> SOTIENMIENGIAM { get; set; }
        public string SOQUYETDINHMIENGIAM { get; set; }
        public Nullable<System.DateTime> NGAYRAQUYETDINHMIENGIAM { get; set; }
        public string COQUANRAQUYETDINHMIENGIAM { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string LOAIDTMIENGIAMID { get; set; }
        public string LOAINGHIAVUTAICHINHID { get; set; }
        public Nullable<decimal> TYLEMIENGIAM { get; set; }
        public Nullable<decimal> THOIGIANMIENGIAM { get; set; }
        public string NGUOIID { get; set; }
    
        public virtual DC_NGUOI DC_NGUOI { get; set; }
        public virtual DM_LOAINGHIAVUTAICHINH DM_LOAINGHIAVUTAICHINH { get; set; }
        public virtual DM_LOAIDTMIENGIAM DM_LOAIDTMIENGIAM { get; set; }
        public virtual DC_NGHIAVUTAICHINH DC_NGHIAVUTAICHINH { get; set; }
    }
}
