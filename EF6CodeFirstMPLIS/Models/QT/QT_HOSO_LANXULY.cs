namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QT_HOSO_LANXULY
    {
        public QT_HOSO_LANXULY()
        {
            this.QT_GHICHUXULY = new HashSet<QT_GHICHUXULY>();
            this.QT_LUANCHUYEN_HOSO = new HashSet<QT_LUANCHUYEN_HOSO>();
        }
    
        public string HOSOXULYID { get; set; }
        public string HOSOTIEPNHANID { get; set; }
        public string QUYTRINHID { get; set; }
        public Nullable<System.DateTime> NGAYBATDAUXL { get; set; }
        public Nullable<System.DateTime> NGAYKETTHUCXL { get; set; }
        public string TRANGTHAI { get; set; }
        
        public virtual ICollection<QT_GHICHUXULY> QT_GHICHUXULY { get; set; }
        public virtual ICollection<QT_LUANCHUYEN_HOSO> QT_LUANCHUYEN_HOSO { get; set; }
        public virtual QT_HOSOTIEPNHAN QT_HOSOTIEPNHAN { get; set; }
        public virtual QT_QUYTRINH QT_QUYTRINH { get; set; }
    }
}
