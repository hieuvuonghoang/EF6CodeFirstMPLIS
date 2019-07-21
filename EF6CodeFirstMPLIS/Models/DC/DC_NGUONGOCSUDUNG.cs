namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_NGUONGOCSUDUNG
    {
        public string NGUONGOCSUDUNGID { get; set; }
        public string MUCDICHSUDUNGDATID { get; set; }
        public string CHITIET { get; set; }
        public string LOAINGUONGOCSUDUNGID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string THOIDIEMCAPNHAT { get; set; }
    
        public virtual DC_MUCDICHSUDUNGDAT DC_MUCDICHSUDUNGDAT { get; set; }
        public virtual DM_LOAINGUONGOCSUDUNG DM_LOAINGUONGOCSUDUNG { get; set; }
    }
}
