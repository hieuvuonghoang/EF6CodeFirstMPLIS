namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QT_NHOMQUYTRINH
    {
        public QT_NHOMQUYTRINH()
        {
            this.QT_QUYTRINH = new HashSet<QT_QUYTRINH>();
        }
    
        public string NHOMQUYTRINHID { get; set; }
        public string TENNHOMQUYTRINH { get; set; }
        public string KYHIEUNHOM { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        
        public virtual ICollection<QT_QUYTRINH> QT_QUYTRINH { get; set; }
    }
}
