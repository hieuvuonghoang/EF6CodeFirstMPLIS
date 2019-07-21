namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class GD_GIATHUADAT
    {
        public string GIATHUADATID { get; set; }
        public string LOAIGIADATID { get; set; }
        public string THUADATID { get; set; }
        public Nullable<decimal> GIADAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMXACDINH { get; set; }
        public string CANCUPHAPLY { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string uId { get; set; }
        public string TENFILE { get; set; }
        public Nullable<decimal> GIADATTHEOHSDC { get; set; }
    
        public virtual DC_THUADAT DC_THUADAT { get; set; }
        public virtual GD_DMLOAIGIADAT GD_DMLOAIGIADAT { get; set; }
    }
}
