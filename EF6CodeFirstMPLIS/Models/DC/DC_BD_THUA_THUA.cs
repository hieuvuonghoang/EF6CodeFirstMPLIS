//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_BD_THUA_THUA
    {
        public string BDTHUATHUAID { get; set; }
        public string THUACHAID { get; set; }
        public string THUADATID { get; set; }
    
        public virtual DC_THUADAT DC_THUADAT { get; set; }
        public virtual DC_THUADAT DC_THUADAT1 { get; set; }
    }
}