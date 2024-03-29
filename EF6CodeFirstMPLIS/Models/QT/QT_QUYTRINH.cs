namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QT_QUYTRINH
    {
        public QT_QUYTRINH()
        {
            this.QT_BUOCQUYTRINH = new HashSet<QT_BUOCQUYTRINH>();
            this.QT_GHICHUXULY = new HashSet<QT_GHICHUXULY>();
            this.QT_HOSO_LANXULY = new HashSet<QT_HOSO_LANXULY>();
            this.QT_LUANCHUYEN_HOSO = new HashSet<QT_LUANCHUYEN_HOSO>();
            this.QT_TTHC_QUYTRINH = new HashSet<QT_TTHC_QUYTRINH>();
        }
    
        public string QUYTRINHID { get; set; }
        public string NHOMQUYTRINHID { get; set; }
        public Nullable<byte> CAPQUYTRINH { get; set; }
        public string DONVIHANHCHINHID { get; set; }
        public string TENQUYTRINH { get; set; }
        public Nullable<decimal> THOIHANGIAIQUYETTOIDA { get; set; }
        public string XML { get; set; }
        public string SVG { get; set; }
        public string PHAPLY { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string KYHIEU { get; set; }
        
        public virtual ICollection<QT_BUOCQUYTRINH> QT_BUOCQUYTRINH { get; set; }
        public virtual ICollection<QT_GHICHUXULY> QT_GHICHUXULY { get; set; }
        public virtual ICollection<QT_HOSO_LANXULY> QT_HOSO_LANXULY { get; set; }
        public virtual ICollection<QT_LUANCHUYEN_HOSO> QT_LUANCHUYEN_HOSO { get; set; }
        public virtual QT_NHOMQUYTRINH QT_NHOMQUYTRINH { get; set; }
        public virtual ICollection<QT_TTHC_QUYTRINH> QT_TTHC_QUYTRINH { get; set; }
    }
}
