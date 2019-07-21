namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QT_GIAYTOTHEOTTHC
    {
        public QT_GIAYTOTHEOTTHC()
        {
            this.QT_FILEDINHKEMHOSO = new HashSet<QT_FILEDINHKEMHOSO>();
        }
    
        public string GIAYTOTHEOTTHCID { get; set; }
        public string THUTUCHANHCHINHID { get; set; }
        public string TENLOAIGIAYTO { get; set; }
        
        public virtual ICollection<QT_FILEDINHKEMHOSO> QT_FILEDINHKEMHOSO { get; set; }
        public virtual QT_THUTUCHANHCHINH QT_THUTUCHANHCHINH { get; set; }
    }
}
