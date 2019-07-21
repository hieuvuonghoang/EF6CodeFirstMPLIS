namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QT_BUOCQT_CAUHINH
    {
        public string BUOCQTCAUHINHID { get; set; }
        public string BUOCQUYTRINHID { get; set; }
        public string NGUOIDUNGID { get; set; }
        public string KVHCID { get; set; }
    
        public virtual HC_DMKVHC HC_DMKVHC { get; set; }
        public virtual HT_NGUOIDUNG HT_NGUOIDUNG { get; set; }
        public virtual QT_BUOCQUYTRINH QT_BUOCQUYTRINH { get; set; }
    }
}
