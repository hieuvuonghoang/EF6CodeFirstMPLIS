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
    
    public partial class DM_LOAINGHIAVUTAICHINH
    {
        
        public DM_LOAINGHIAVUTAICHINH()
        {
            this.DC_MIENGIAMNVTC = new HashSet<DC_MIENGIAMNVTC>();
            this.DC_NONVTC = new HashSet<DC_NONVTC>();
        }
    
        public string LOAINGHIAVUTAICHINHID { get; set; }
        public string TENNGHIAVUTAICHINH { get; set; }
        public string GHICHU { get; set; }
    
        
        public virtual ICollection<DC_MIENGIAMNVTC> DC_MIENGIAMNVTC { get; set; }
        
        public virtual ICollection<DC_NONVTC> DC_NONVTC { get; set; }
    }
}
