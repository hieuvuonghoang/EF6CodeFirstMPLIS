namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_SEQUENCE
    {
        public string SEQUENCEID { get; set; }
        public string MATINH { get; set; }
        public string MAHUYEN { get; set; }
        public string MAXA { get; set; }
        public Nullable<decimal> SOHIEUTOBANDO { get; set; }
        public Nullable<decimal> SOTHUTUTHUA { get; set; }
        public Nullable<int> STT { get; set; }
    }
}
