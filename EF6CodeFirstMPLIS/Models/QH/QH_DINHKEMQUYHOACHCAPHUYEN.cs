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
    
    public partial class QH_DINHKEMQUYHOACHCAPHUYEN
    {
        public string DINHKEMQUYHOACHCAPHUYENID { get; set; }
        public string QUYHOACHCAPHUYENID { get; set; }
        public string TENFILE { get; set; }
        public Nullable<System.DateTime> NGAYTAOFILE { get; set; }
        public string NGUOICAPHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string GHICHU { get; set; }
    
        public virtual QH_QUYHOACHCAPHUYEN QH_QUYHOACHCAPHUYEN { get; set; }
    }
}
