namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_BOTHUTUCHANHCHINH
    {
        public DM_BOTHUTUCHANHCHINH()
        {
            this.QT_THUTUCHANHCHINH = new HashSet<QT_THUTUCHANHCHINH>();
        }
    
        public string BOTHUTUCHANHCHINHID { get; set; }
        public string TENBOTHUTUCHANHCHINH { get; set; }
        public string CANCUPHAPLY { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        
        public virtual ICollection<QT_THUTUCHANHCHINH> QT_THUTUCHANHCHINH { get; set; }
    }
}
