namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QT_CONGVIECTHEOBUOC
    {
        public QT_CONGVIECTHEOBUOC()
        {
            this.QT_CONGVIECTHUCHIEN = new HashSet<QT_CONGVIECTHUCHIEN>();
        }
    
        public string CONGVIECTHEOBUOCID { get; set; }
        public Nullable<decimal> STT { get; set; }
        public string TENCONGVIEC { get; set; }
        public string BUOCQUYTRINHID { get; set; }
    
        public virtual QT_BUOCQUYTRINH QT_BUOCQUYTRINH { get; set; }
        public virtual ICollection<QT_CONGVIECTHUCHIEN> QT_CONGVIECTHUCHIEN { get; set; }
    }
}
