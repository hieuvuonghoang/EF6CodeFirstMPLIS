namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_QUYENSUDUNGDAT
    {
        public string QUYENSUDUNGDATID { get; set; }
        public string NGUOIID { get; set; }
        public string THUADATID { get; set; }
        public string MUCDICHSUDUNGDATID { get; set; }
        public string GIAYCHUNGNHANID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string DONDANGKYID { get; set; }
        public string LAQUYENQUANLY { get; set; }
        public string TRANGTHAIPL { get; set; }
        public Nullable<System.DateTime> NGAYDANGKYTC { get; set; }
        public string BDTHECHAPID { get; set; }
        public string QUYENSDDGOCID { get; set; }
        public Nullable<decimal> TILESOHUU { get; set; }
    
        public virtual DC_BD_THECHAP DC_BD_THECHAP { get; set; }
        public virtual DC_MUCDICHSUDUNGDAT DC_MUCDICHSUDUNGDAT { get; set; }
        public virtual DC_NGUOI DC_NGUOI { get; set; }
    }
}
