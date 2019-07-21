namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QT_FILEDINHKEMHOSO
    {
        public string FILEDINHKEMHOSOID { get; set; }
        public string HOSOTIEPNHANID { get; set; }
        public string SODOQUYTRINHID { get; set; }
        public string BUOCQUYTRINHID { get; set; }
        public string TENFILE { get; set; }
        public Nullable<System.DateTime> NGAYTAOFILE { get; set; }
        public string NGUOITAOFILEID { get; set; }
        public Nullable<byte> LOAI { get; set; }
        public Nullable<decimal> SOLUONG { get; set; }
        public string GHICHU { get; set; }
        public string DUONGDANFILE { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<decimal> LOAIBAOCAO { get; set; }
        public string GIAYTOTHEOTTHCID { get; set; }
    
        public virtual QT_HOSOTIEPNHAN QT_HOSOTIEPNHAN { get; set; }
        public virtual QT_GIAYTOTHEOTTHC QT_GIAYTOTHEOTTHC { get; set; }
    }
}
