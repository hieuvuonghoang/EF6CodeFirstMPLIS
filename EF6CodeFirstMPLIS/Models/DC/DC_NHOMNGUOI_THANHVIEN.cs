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
    
    public partial class DC_NHOMNGUOI_THANHVIEN
    {
        public string NHOMNGUOIID { get; set; }
        public string LOAIDOITUONG { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string NHOMNGUOITHANHVIENID { get; set; }
        public string THANHPHANID { get; set; }
    
        public virtual DC_NHOMNGUOI DC_NHOMNGUOI { get; set; }
    }
}
