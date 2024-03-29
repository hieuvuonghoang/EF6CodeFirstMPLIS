namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class QT_HOSOTIEPNHAN
    {
        public QT_HOSOTIEPNHAN()
        {
            this.HS_HOSO = new HashSet<HS_HOSO>();
            this.QT_FILEDINHKEMHOSO = new HashSet<QT_FILEDINHKEMHOSO>();
            this.QT_GHICHUXULY = new HashSet<QT_GHICHUXULY>();
            this.QT_HOSO_LANXULY = new HashSet<QT_HOSO_LANXULY>();
            this.QT_LUANCHUYEN_HOSO = new HashSet<QT_LUANCHUYEN_HOSO>();
        }
    
        public string HOSOTIEPNHANID { get; set; }
        public string TOCHUCID { get; set; }
        public string THUTUCHANHCHINHID { get; set; }
        public Nullable<byte> CAP { get; set; }
        public string DONVIHANHCHINHID { get; set; }
        public string SOBIENNHAN { get; set; }
        public string QUYENTIEPNHAN { get; set; }
        public string CANBOTIEPNHANID { get; set; }
        public Nullable<System.DateTime> NGAYTIEPNHANHOSO { get; set; }
        public Nullable<System.DateTime> NGAYHENTRAHOSO { get; set; }
        public string NGUOINOPHOSO { get; set; }
        public Nullable<byte> VAITRONGUOINOPHOSO { get; set; }
        public string MOTATOMTAT { get; set; }
        public string SODIENTHOAI { get; set; }
        public string EMAIL { get; set; }
        public string SOGIAYTO { get; set; }
        public Nullable<byte> PHUONGPHAPNHANTHONGBAO { get; set; }
        public string DIACHINGUOINOPHS { get; set; }
        public string TENNGUOINHANKETQUA { get; set; }
        public Nullable<byte> VAITRONGUOINHANKETQUA { get; set; }
        public string DIACHINGUOINHANKETQUA { get; set; }
        public Nullable<System.DateTime> NGAYTRAKETQUA { get; set; }
        public string GHICHUTRAKETQUA { get; set; }
        public Nullable<byte> TINHTRANGHOSO { get; set; }
        public string XULYTHEOQUYTRINH { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> NGAYHENLAYPHIEUCHUYENTHUE { get; set; }
        public string TENHOSO { get; set; }
        public Nullable<byte> LOAIHOSO { get; set; }
        public string TRANGTHAI { get; set; }
        public string DONVITHULYID { get; set; }
        public string HOSOXULYID { get; set; }
        
        public virtual ICollection<HS_HOSO> HS_HOSO { get; set; }
        public virtual HT_TOCHUC HT_TOCHUC { get; set; }
        public virtual ICollection<QT_FILEDINHKEMHOSO> QT_FILEDINHKEMHOSO { get; set; }
        public virtual ICollection<QT_GHICHUXULY> QT_GHICHUXULY { get; set; }
        public virtual ICollection<QT_HOSO_LANXULY> QT_HOSO_LANXULY { get; set; }
        public virtual ICollection<QT_LUANCHUYEN_HOSO> QT_LUANCHUYEN_HOSO { get; set; }
        public virtual QT_THUTUCHANHCHINH QT_THUTUCHANHCHINH { get; set; }
    }
}
