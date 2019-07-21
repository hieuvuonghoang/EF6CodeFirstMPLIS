namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QT_GHICHUXULY
    {
        public string GHICHUXULYID { get; set; }
        public string HOSOXULYID { get; set; }
        public string QUYTRINHID { get; set; }
        public string HOSOTIEPNHANID { get; set; }
        public string BUOCQUYTRINHID { get; set; }
        public string NGUOIDUNGID { get; set; }
        public string GHICHUXL { get; set; }
        public Nullable<System.DateTime> NGAYGHICHU { get; set; }
    
        public virtual HT_NGUOIDUNG HT_NGUOIDUNG { get; set; }
        public virtual QT_BUOCQUYTRINH QT_BUOCQUYTRINH { get; set; }
        public virtual QT_HOSO_LANXULY QT_HOSO_LANXULY { get; set; }
        public virtual QT_HOSOTIEPNHAN QT_HOSOTIEPNHAN { get; set; }
        public virtual QT_QUYTRINH QT_QUYTRINH { get; set; }
    }
}
