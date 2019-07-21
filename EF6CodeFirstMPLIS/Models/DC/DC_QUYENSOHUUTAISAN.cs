namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_QUYENSOHUUTAISAN
    {
        public string QUYENSOHUUTAISANID { get; set; }
        public string NGUOIID { get; set; }
        public string TAISANGANLIENVOIDATID { get; set; }
        public string GIAYCHUNGNHANID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string DONDANGKYID { get; set; }
        public string TRANGTHAIPL { get; set; }
        public Nullable<System.DateTime> NGAYDANGKYTC { get; set; }
        public string BDTHECHAPID { get; set; }
        public string QUYENSHTSGOCID { get; set; }
        public Nullable<decimal> TILESOHUU { get; set; }
    
        public virtual DC_BD_THECHAP DC_BD_THECHAP { get; set; }
        public virtual DC_GIAYCHUNGNHAN DC_GIAYCHUNGNHAN { get; set; }
        public virtual DC_NGUOI DC_NGUOI { get; set; }
        public virtual DC_TAISANGANLIENVOIDAT DC_TAISANGANLIENVOIDAT { get; set; }
    }
}
