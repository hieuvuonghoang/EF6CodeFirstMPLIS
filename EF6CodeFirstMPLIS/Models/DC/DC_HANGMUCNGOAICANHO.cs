namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_HANGMUCNGOAICANHO
    {
        public DC_HANGMUCNGOAICANHO()
        {
            this.DC_CANHO_HANGMUCNCH = new HashSet<DC_CANHO_HANGMUCNCH>();
        }
    
        public string HANGMUCSOHUUCHUNGID { get; set; }
        public string NHACHUNGCUID { get; set; }
        public string TENHANGMUC { get; set; }
        public Nullable<decimal> DIENTICH { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        
        public virtual ICollection<DC_CANHO_HANGMUCNCH> DC_CANHO_HANGMUCNCH { get; set; }
        public virtual DC_NHACHUNGCU DC_NHACHUNGCU { get; set; }
    }
}
