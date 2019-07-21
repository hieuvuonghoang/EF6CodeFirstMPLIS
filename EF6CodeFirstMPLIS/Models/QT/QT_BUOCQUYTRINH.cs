namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QT_BUOCQUYTRINH
    {
        public QT_BUOCQUYTRINH()
        {
            this.QT_BUOCQT_CAUHINH = new HashSet<QT_BUOCQT_CAUHINH>();
            this.QT_CONGVIECTHEOBUOC = new HashSet<QT_CONGVIECTHEOBUOC>();
            this.QT_GHICHUXULY = new HashSet<QT_GHICHUXULY>();
            this.QT_LUANCHUYEN_HOSO = new HashSet<QT_LUANCHUYEN_HOSO>();
        }
    
        public string BUOCQUYTRINHID { get; set; }
        public string MOTA { get; set; }
        public string BUOCQUYTRINHTRUOCIDS { get; set; }
        public Nullable<decimal> RECTX { get; set; }
        public Nullable<decimal> RECTY { get; set; }
        public Nullable<decimal> RECTWIDTH { get; set; }
        public Nullable<decimal> RECTHEIGHT { get; set; }
        public string QUYTRINHID { get; set; }
        public string LOAIBUOCQT { get; set; }
        public Nullable<decimal> DIEUKIEN { get; set; }
        public Nullable<decimal> THOIGIANQUYDINH { get; set; }
        public string BUOCQUYTRINHSAUIDS { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string BPMNID { get; set; }
        public string TENBUOC { get; set; }
        public string UID { get; set; }
        public Nullable<decimal> STT { get; set; }
        
        public virtual ICollection<QT_BUOCQT_CAUHINH> QT_BUOCQT_CAUHINH { get; set; }
        public virtual QT_QUYTRINH QT_QUYTRINH { get; set; }
        public virtual ICollection<QT_CONGVIECTHEOBUOC> QT_CONGVIECTHEOBUOC { get; set; }
        public virtual ICollection<QT_GHICHUXULY> QT_GHICHUXULY { get; set; }
        public virtual ICollection<QT_LUANCHUYEN_HOSO> QT_LUANCHUYEN_HOSO { get; set; }
    }
}
