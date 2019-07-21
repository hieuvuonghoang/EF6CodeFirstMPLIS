namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_LOAINGHIAVUTAICHINH
    {
        public DC_LOAINGHIAVUTAICHINH()
        {
            this.DC_NGHIAVUTAICHINH = new HashSet<DC_NGHIAVUTAICHINH>();
        }
    
        public string LOAINGHIAVUTAICHINHID { get; set; }
        public string TENLOAINGHIAVUTAICHINH { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        
        public virtual ICollection<DC_NGHIAVUTAICHINH> DC_NGHIAVUTAICHINH { get; set; }
    }
}
