namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class GD_QDGIADAT
    {
        public GD_QDGIADAT()
        {
            this.GD_BANGGIADAT = new HashSet<GD_BANGGIADAT>();
        }
    
        public string QDGIADATID { get; set; }
        public string SOQUYETDINH { get; set; }
        public string FILEQUYETDINH { get; set; }
        public Nullable<System.DateTime> NGAYBANHANH { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string uId { get; set; }
        public string TENFILE { get; set; }
        public string NOIDUNGTOMTAT { get; set; }
        
        public virtual ICollection<GD_BANGGIADAT> GD_BANGGIADAT { get; set; }
    }
}
