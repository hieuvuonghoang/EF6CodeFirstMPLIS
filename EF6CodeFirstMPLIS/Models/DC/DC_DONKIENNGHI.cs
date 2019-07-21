namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_DONKIENNGHI
    {
        public string DONKIENNGHIID { get; set; }
        public string DANHSACHCONGKHAIID { get; set; }
        public string TENFILE { get; set; }
        public string DUONGDANFILE { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    
        public virtual DC_DANHSACHCONGKHAI DC_DANHSACHCONGKHAI { get; set; }
    }
}
