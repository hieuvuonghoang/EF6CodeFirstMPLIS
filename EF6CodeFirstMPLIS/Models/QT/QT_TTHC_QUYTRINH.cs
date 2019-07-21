namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QT_TTHC_QUYTRINH
    {
        public string TTHCQUYTRINHID { get; set; }
        public string QUYTRINHID { get; set; }
        public string THUTUCHANHCHINHID { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string ISACTIVE { get; set; }
    
        public virtual QT_QUYTRINH QT_QUYTRINH { get; set; }
        public virtual QT_THUTUCHANHCHINH QT_THUTUCHANHCHINH { get; set; }
    }
}
