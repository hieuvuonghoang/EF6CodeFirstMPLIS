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
    
    public partial class DC_NGUOI_DIACHI
    {
        public string NGUOIID { get; set; }
        public string DIACHIID { get; set; }
        public string MOTA { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPPHATID { get; set; }
        public string uId { get; set; }
    
        public virtual DC_DIACHI DC_DIACHI { get; set; }
        public virtual DC_NGUOI DC_NGUOI { get; set; }
    }
}