namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;

    public partial class HT_TOCHUC
    {
        public HT_TOCHUC()
        {
            this.CS_CHUKYSO = new HashSet<CS_CHUKYSO>();
            this.DC_GIAYCHUNGNHAN = new HashSet<DC_GIAYCHUNGNHAN>();
            this.HT_TOCHUC_NHOMCHUCNANG = new HashSet<HT_TOCHUC_NHOMCHUCNANG>();
            this.HT_TOCHUC_NGUOIDUNG = new HashSet<HT_TOCHUC_NGUOIDUNG>();
            this.HT_TOCHUC1 = new HashSet<HT_TOCHUC>();
            this.QT_HOSOTIEPNHAN = new HashSet<QT_HOSOTIEPNHAN>();
            this.QT_THUTUCHANHCHINH = new HashSet<QT_THUTUCHANHCHINH>();
            this.HT_XA_TOCHUC = new HashSet<HT_XA_TOCHUC>();
        }

        public string TOCHUCID { get; set; }
        public string KHOACHAID { get; set; }
        public string TENTOCHUC { get; set; }
        public string MOTA { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string DONVIHANHCHINHID { get; set; }
        public Nullable<byte> CAPTOCHUC { get; set; }
        public string MATOCHUC { get; set; }

        public virtual ICollection<CS_CHUKYSO> CS_CHUKYSO { get; set; }
        public virtual ICollection<DC_GIAYCHUNGNHAN> DC_GIAYCHUNGNHAN { get; set; }
        public virtual ICollection<HT_TOCHUC_NHOMCHUCNANG> HT_TOCHUC_NHOMCHUCNANG { get; set; }
        public virtual ICollection<HT_TOCHUC_NGUOIDUNG> HT_TOCHUC_NGUOIDUNG { get; set; }
        public virtual ICollection<HT_TOCHUC> HT_TOCHUC1 { get; set; }
        public virtual HT_TOCHUC HT_TOCHUC2 { get; set; }
        public virtual ICollection<QT_HOSOTIEPNHAN> QT_HOSOTIEPNHAN { get; set; }
        public virtual ICollection<QT_THUTUCHANHCHINH> QT_THUTUCHANHCHINH { get; set; }
        public virtual ICollection<HT_XA_TOCHUC> HT_XA_TOCHUC { get; set; }
    }
}