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
    
    public partial class DC_NHOMNGUOI
    {
        
        public DC_NHOMNGUOI()
        {
            this.DC_NHOMNGUOI_THANHVIEN = new HashSet<DC_NHOMNGUOI_THANHVIEN>();
        }
    
        public string NHOMNGUOIID { get; set; }
        public string NGUOIDAIDIEN { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string CMTNGUOIDAIDIEN { get; set; }
    
        
        public virtual ICollection<DC_NHOMNGUOI_THANHVIEN> DC_NHOMNGUOI_THANHVIEN { get; set; }
    }
}
