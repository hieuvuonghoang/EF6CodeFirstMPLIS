namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GD_BANDOGIADAT
    {
        public string BANDOGIADATID { get; set; }
        public string MATINH { get; set; }
        public string MAHUYEN { get; set; }
        public string MAXA { get; set; }
        public string FILEDINHKEM { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string uId { get; set; }
        public string TENFILE { get; set; }
        public string NOIDUNGTOMTAT { get; set; }
        public Nullable<decimal> NAM { get; set; }
    }
}
