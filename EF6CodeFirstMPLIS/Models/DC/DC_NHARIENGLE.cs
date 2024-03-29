namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_NHARIENGLE
    {
        public string NHARIENGLEID { get; set; }
        public string XAID { get; set; }
        public Nullable<decimal> DIENTICHXAYDUNG { get; set; }
        public Nullable<decimal> DIENTICHSAN { get; set; }
        public string SOTANG { get; set; }
        public Nullable<decimal> SOTANGHAM { get; set; }
        public string KETCAU { get; set; }
        public string CAPHANG { get; set; }
        public string DIACHI { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string LOAICAPHANGID { get; set; }
        public string LOAINHAID { get; set; }
        public Nullable<decimal> DTSH_RIENG { get; set; }
        public Nullable<decimal> DT_SH_CHUNG { get; set; }
        public Nullable<decimal> NAMHOANCONG { get; set; }
        public Nullable<decimal> TLCL_CONLAI { get; set; }
        public string CO_HSXN_NHADUYNHAT { get; set; }
        public Nullable<decimal> DT_HT_NVTC { get; set; }
    
        public virtual DM_LOAICAPHANG DM_LOAICAPHANG { get; set; }
        public virtual DM_LOAINHA DM_LOAINHA { get; set; }
    }
}
