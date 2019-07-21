namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DM_DOITUONGSUDUNG
    {
        public DM_DOITUONGSUDUNG()
        {
            this.DC_NGUOI = new HashSet<DC_NGUOI>();
        }
    
        public string DOITUONGSUDUNGID { get; set; }
        public string MADOITUONGSUDUNG { get; set; }
        public string TENDOITUONGSUDUNG { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string uId { get; set; }
        public Nullable<decimal> LOAICHU { get; set; }
        
        public virtual ICollection<DC_NGUOI> DC_NGUOI { get; set; }
    }
}
