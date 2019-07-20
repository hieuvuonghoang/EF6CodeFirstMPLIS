namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;

    public partial class HT_NGUOIDUNG
    {
        public HT_NGUOIDUNG()
        {
            this.CS_CHUKYSO = new HashSet<CS_CHUKYSO>();
            this.HT_CAUHINHNGUOIDUNG = new HashSet<HT_CAUHINHNGUOIDUNG>();
            this.HT_LICHSUTRUYCAP = new HashSet<HT_LICHSUTRUYCAP>();
            this.QT_BUOCQT_CAUHINH = new HashSet<QT_BUOCQT_CAUHINH>();
            this.QT_GHICHUXULY = new HashSet<QT_GHICHUXULY>();
            this.QT_LUANCHUYEN_HOSO = new HashSet<QT_LUANCHUYEN_HOSO>();
            this.HT_NGUOIDUNG_QUYEN = new HashSet<HT_NGUOIDUNG_QUYEN>();
            this.HT_TOCHUC_NGUOIDUNG = new HashSet<HT_TOCHUC_NGUOIDUNG>();
            this.HT_XA_NGUOIDUNG = new HashSet<HT_XA_NGUOIDUNG>();
        }

        public string NGUOIDUNGID { get; set; }
        public string TENDANGNHAP { get; set; }
        public string MATKHAU { get; set; }
        public string HOTENNGUOIDUNG { get; set; }
        public string GIOITINH { get; set; }
        public string SODIENTHOAI { get; set; }
        public string SODIENTHOAI2 { get; set; }
        public string EMAIL { get; set; }
        public string DIACHI { get; set; }
        public Nullable<bool> READONLY { get; set; }
        public byte[] ANHBIEUTUONG { get; set; }
        public string PHAITHAYDOIMATKHAU { get; set; }
        public Nullable<System.DateTime> THOIDIEMMATKHAUCOHIEULUC { get; set; }
        public Nullable<System.DateTime> THOIDIEMMATKHAUHETHIEULUC { get; set; }
        public string CHOPHEPSUDUNG { get; set; }
        public string MOTA { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string CAPNGUOIDUNG { get; set; }
        public string DONVIHANHCHINHID { get; set; }
        public Nullable<decimal> LOAINGUOIDUNG { get; set; }

        public virtual ICollection<CS_CHUKYSO> CS_CHUKYSO { get; set; }
        public virtual ICollection<HT_CAUHINHNGUOIDUNG> HT_CAUHINHNGUOIDUNG { get; set; }
        public virtual ICollection<HT_LICHSUTRUYCAP> HT_LICHSUTRUYCAP { get; set; }
        public virtual ICollection<QT_BUOCQT_CAUHINH> QT_BUOCQT_CAUHINH { get; set; }
        public virtual ICollection<QT_GHICHUXULY> QT_GHICHUXULY { get; set; }
        public virtual ICollection<QT_LUANCHUYEN_HOSO> QT_LUANCHUYEN_HOSO { get; set; }
        public virtual ICollection<HT_NGUOIDUNG_QUYEN> HT_NGUOIDUNG_QUYEN { get; set; }
        public virtual ICollection<HT_TOCHUC_NGUOIDUNG> HT_TOCHUC_NGUOIDUNG { get; set; }
        public virtual ICollection<HT_XA_NGUOIDUNG> HT_XA_NGUOIDUNG { get; set; }
    }
}
