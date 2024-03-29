namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class GD_BANGGIADAT
    {
        public string BANGGIADATID { get; set; }
        public string MATINH { get; set; }
        public string MAHUYEN { get; set; }
        public Nullable<decimal> BANGSO { get; set; }
        public string FILEDINHKEM { get; set; }
        public string QDGIADATID { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string uId { get; set; }
        public string TENFILE { get; set; }
    
        public virtual GD_QDGIADAT GD_QDGIADAT { get; set; }
    }
}
