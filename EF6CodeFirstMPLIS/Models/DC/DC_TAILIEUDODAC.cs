namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_TAILIEUDODAC
    {
        public DC_TAILIEUDODAC()
        {
            this.DC_THUADAT_TAILIEUDODAC = new HashSet<DC_THUADAT_TAILIEUDODAC>();
            this.DC_THUADAT = new HashSet<DC_THUADAT>();
        }
    
        public string TAILIEUDODACID { get; set; }
        public string XAID { get; set; }
        public string LOAIBANDODIACHINHID { get; set; }
        public string KVHCID { get; set; }
        public string DONVIDODAC { get; set; }
        public string PHUONGPHAPDO { get; set; }
        public string MUCDOCHINHXAC { get; set; }
        public string TYLEDODAC { get; set; }
        public Nullable<System.DateTime> NGAYHOANTHANH { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string TENTAILIEU { get; set; }
        public string GHICHU { get; set; }
        
        public virtual ICollection<DC_THUADAT_TAILIEUDODAC> DC_THUADAT_TAILIEUDODAC { get; set; }
        public virtual ICollection<DC_THUADAT> DC_THUADAT { get; set; }
        public virtual DM_LOAIBANDODIACHINH DM_LOAIBANDODIACHINH { get; set; }
        public virtual HC_DMKVHC HC_DMKVHC { get; set; }
    }
}
