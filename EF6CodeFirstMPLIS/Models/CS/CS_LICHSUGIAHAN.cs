namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CS_LICHSUGIAHAN
    {
        public string LICHSUGIAHANID { get; set; }
        public string CHUKYSOID { get; set; }
        public Nullable<System.DateTime> THOIDIEMGIAHAN { get; set; }
        public string NGUOIDUNGTEN { get; set; }
        public string TENTOCHUC { get; set; }
        public string CHUCVU { get; set; }
        public string NOICONGTAC { get; set; }
        public Nullable<System.DateTime> NGAYHETHIEULUCTRUOCGIAHAN { get; set; }
        public Nullable<System.DateTime> NGAYHETHIEULUCSAUGIAHAN { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string NGUOIDUNGID { get; set; }
        public string TOCHUCID { get; set; }
    
        public virtual CS_CHUKYSO CS_CHUKYSO { get; set; }
    }
}
