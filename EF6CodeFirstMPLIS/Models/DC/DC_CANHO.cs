namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_CANHO
    {
        public DC_CANHO()
        {
            this.DC_CANHO_HANGMUCNCH = new HashSet<DC_CANHO_HANGMUCNCH>();
        }
    
        public string CANHOID { get; set; }
        public string NHACHUNGCUID { get; set; }
        public string SOHIEUCANHO { get; set; }
        public Nullable<decimal> TANGSO { get; set; }
        public Nullable<decimal> DIENTICHSAN { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string HINHTHUCSOHUU { get; set; }
        public string THOIHANSOHUU { get; set; }
        public string TINHTRANGDANGKY { get; set; }
        public Nullable<decimal> DTSH_CHUNG_CDT { get; set; }
        public Nullable<decimal> DTSH_CHUNG_NSDD { get; set; }
        public Nullable<decimal> DTSH_RIENG { get; set; }
        public string NGUONGOC { get; set; }
        public Nullable<decimal> NAMHOANCONG { get; set; }
        public string CO_HSXN_NHADUYNHAT { get; set; }
        public Nullable<decimal> DT_PT_RIENGLE { get; set; }
        public Nullable<decimal> DT_PT_KHONGRIENGLE { get; set; }
        public Nullable<decimal> DT_HT_NVTC { get; set; }
    
        public virtual DC_NHACHUNGCU DC_NHACHUNGCU { get; set; }
        public virtual ICollection<DC_CANHO_HANGMUCNCH> DC_CANHO_HANGMUCNCH { get; set; }
    }
}
