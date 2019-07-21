namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QT_THUTUCHANHCHINH
    {
        public QT_THUTUCHANHCHINH()
        {
            this.QT_GIAYTOTHEOTTHC = new HashSet<QT_GIAYTOTHEOTTHC>();
            this.QT_HOSOTIEPNHAN = new HashSet<QT_HOSOTIEPNHAN>();
            this.QT_TTHC_QUYTRINH = new HashSet<QT_TTHC_QUYTRINH>();
        }
    
        public string THUTUCHANHCHINHID { get; set; }
        public string TOCHUCID { get; set; }
        public string BOTHUTUCHANHCHINHID { get; set; }
        public string TENTHUTUCHANHCHINH { get; set; }
        public string MOTA { get; set; }
        public Nullable<byte> CAP { get; set; }
        public string DONVIHANHCHINHID { get; set; }
        public Nullable<decimal> THOIHANGIAIQUYETTOIDA { get; set; }
        public Nullable<decimal> LEPHI { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string KYHIEU { get; set; }
        public string DONVIID { get; set; }
    
        public virtual DM_BOTHUTUCHANHCHINH DM_BOTHUTUCHANHCHINH { get; set; }
        public virtual HT_TOCHUC HT_TOCHUC { get; set; }
        public virtual ICollection<QT_GIAYTOTHEOTTHC> QT_GIAYTOTHEOTTHC { get; set; }
        public virtual ICollection<QT_HOSOTIEPNHAN> QT_HOSOTIEPNHAN { get; set; }
        public virtual ICollection<QT_TTHC_QUYTRINH> QT_TTHC_QUYTRINH { get; set; }
    }
}
