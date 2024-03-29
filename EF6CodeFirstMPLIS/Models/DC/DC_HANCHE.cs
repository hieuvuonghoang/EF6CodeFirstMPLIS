namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_HANCHE
    {
        public string HANCHEID { get; set; }
        public string LOAIHANCHEID { get; set; }
        public Nullable<decimal> DIENTICH { get; set; }
        public string NOIDUNGHANCHE { get; set; }
        public string HANCHEMOTPHAN { get; set; }
        public string SOVANBAN { get; set; }
        public Nullable<System.DateTime> NGAYBANHANH { get; set; }
        public string COQUANBANHANH { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string DUONGDANFILEVANBAN { get; set; }
        public string GIAYCHUNGNHANID { get; set; }
        public string THUADATID { get; set; }
        public Nullable<decimal> LOAIHANCHE { get; set; }
        public string SODORANHGIOIHANCHE { get; set; }
        public string CONHIEULUC { get; set; }
        public Nullable<System.DateTime> NGAYHETHIEULUC { get; set; }
    
        public virtual DC_LOAIHANCHE DC_LOAIHANCHE { get; set; }
    }
}
