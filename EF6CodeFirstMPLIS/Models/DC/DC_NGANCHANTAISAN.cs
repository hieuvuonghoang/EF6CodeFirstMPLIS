namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_NGANCHANTAISAN
    {
        public string NGANCHANTAISANID { get; set; }
        public string THONGTINNGANCHANID { get; set; }
        public string TAISANGANLIENVOIDATID { get; set; }
        public string LOAITAISAN { get; set; }
        public string TENTAISAN { get; set; }
        public string DIACHICHITIET { get; set; }
        public string SONHA { get; set; }
        public string PHO { get; set; }
        public string KHUPHOXOM { get; set; }
        public string DVHCID { get; set; }
        public string GHICHU { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
    }
}
