namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_LOAIMOCBIENGIOIDIAGIOI
    {
        public string LOAIMOCBIENGIOIDIAGIOIID { get; set; }
        public string MALOAIMOCBIENGIOIDIAGIOI { get; set; }
        public string TENLOAIMOCBIENGIOIDIAGIOI { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
