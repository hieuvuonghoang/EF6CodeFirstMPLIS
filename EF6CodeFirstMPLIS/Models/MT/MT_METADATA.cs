namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MT_METADATA
    {
        public string METADATAID { get; set; }
        public string FILEIDENTIFIER { get; set; }
        public string NGONNGU { get; set; }
        public string BANGMAKYTU { get; set; }
        public string PARENTIDENTIFIER { get; set; }
        public string PHAMVIMOTA { get; set; }
        public Nullable<System.DateTime> NGAYLAP { get; set; }
        public string DONVILAP { get; set; }
        public string TENCHUAN { get; set; }
        public string PHIENBAN { get; set; }
        public string XAID { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    }
}
