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
    
    public partial class DM_LOAIBANDODIACHINH
    {
        
        public DM_LOAIBANDODIACHINH()
        {
            this.DC_TAILIEUDODAC = new HashSet<DC_TAILIEUDODAC>();
        }
    
        public string LOAIBANDODIACHINHID { get; set; }
        public string MALOAIBANDODIACHINH { get; set; }
        public string TENLOAIBANDODIACHINH { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    
        
        public virtual ICollection<DC_TAILIEUDODAC> DC_TAILIEUDODAC { get; set; }
    }
}