namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_CANHAN
    {
        public string CANHANID { get; set; }
        public string HOTEN { get; set; }
        public string HODEM { get; set; }
        public string TEN { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public Nullable<decimal> NAMSINH { get; set; }
        public Nullable<decimal> GIOITINH { get; set; }
        public Nullable<bool> CONSONG { get; set; }
        public string SOGIAYTO { get; set; }
        public Nullable<System.DateTime> NGAYCAP { get; set; }
        public string NOICAP { get; set; }
        public string QUOCTICHID { get; set; }
        public string QUOCTICHKHACIDS { get; set; }
        public string DANTOCID { get; set; }
        public string DIACHI { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string GIAYTOTUYTHANID { get; set; }
        public string SODIENTHOAI { get; set; }
        public string EMAIL { get; set; }
        public string MASOTHUE { get; set; }
    
        public virtual DM_DANTOC DM_DANTOC { get; set; }
        public virtual DM_QUOCTICH DM_QUOCTICH { get; set; }
    }
}
