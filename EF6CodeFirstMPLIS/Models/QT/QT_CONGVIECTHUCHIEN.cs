namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QT_CONGVIECTHUCHIEN
    {
        public string CONGVIECTHUCHIENID { get; set; }
        public string TRANGTHAI { get; set; }
        public Nullable<System.DateTime> NGAYTHUCHIEN { get; set; }
        public string NGUOITHUCHIEN { get; set; }
        public string GHICHU { get; set; }
        public string CONGVIECTHEOBUOCID { get; set; }
        public string LUANCHUYENHOSOID { get; set; }
    
        public virtual QT_CONGVIECTHEOBUOC QT_CONGVIECTHEOBUOC { get; set; }
        public virtual QT_LUANCHUYEN_HOSO QT_LUANCHUYEN_HOSO { get; set; }
    }
}
