namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_CHITIETCONGKHAI
    {
        public string CHITIETCONGKHAIID { get; set; }
        public string DANHSACHCONGKHAIID { get; set; }
        public Nullable<decimal> THUTUSAPXEP { get; set; }
        public string NGUOIID { get; set; }
        public string TENCHUSUDUNG { get; set; }
        public string DIACHI { get; set; }
        public string THUADATID { get; set; }
        public Nullable<decimal> SOHIEUTOBANDO { get; set; }
        public Nullable<decimal> SOTHUTUTHUA { get; set; }
        public string MUCDICHSUDUNGDATID { get; set; }
        public string MAMUCDICHSUDUNG { get; set; }
        public Nullable<decimal> DIENTICHMDSD { get; set; }
        public string THOIDIEMSUDUNGDAT { get; set; }
        public string NGUONGOCSUDUNG { get; set; }
        public string TAISANID { get; set; }
        public string TAISANGANLIENVOIDAT { get; set; }
        public string TINHTRANGTRANHCHAP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string DONDANGKYID { get; set; }
    
        public virtual DC_DANHSACHCONGKHAI DC_DANHSACHCONGKHAI { get; set; }
    }
}
