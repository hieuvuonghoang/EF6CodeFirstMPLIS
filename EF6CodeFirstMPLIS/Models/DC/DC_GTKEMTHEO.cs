namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_GTKEMTHEO
    {
        public string GTKEMTHEOID { get; set; }
        public string TENGIAYTO { get; set; }
        public string FILEDINHKEM { get; set; }
        public string TENFILE { get; set; }
        public string NGHIAVUTAICHINHID { get; set; }
    
        public virtual DC_NGHIAVUTAICHINH DC_NGHIAVUTAICHINH { get; set; }
    }
}
