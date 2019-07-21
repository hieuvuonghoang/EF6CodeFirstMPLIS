namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class GD_DMLOAIGIADAT
    {
        public GD_DMLOAIGIADAT()
        {
            this.GD_GIATHUADAT = new HashSet<GD_GIATHUADAT>();
        }
    
        public string LOAIGIADATID { get; set; }
        public string LOAIGIADAT { get; set; }
        public string GHICHU { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string uId { get; set; }
        
        public virtual ICollection<GD_GIATHUADAT> GD_GIATHUADAT { get; set; }
    }
}
