namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_THONGTINNGANCHAN
    {
        public string THONGTINNGANCHANID { get; set; }
        public Nullable<decimal> MUCDONGANCHAN { get; set; }
        public string SOHIEUCONGVAN { get; set; }
        public Nullable<System.DateTime> THOIDIEMBATDAU { get; set; }
        public Nullable<System.DateTime> THOIDIEMKETTHUC { get; set; }
        public string NOIDUNGNGANCHAN { get; set; }
        public string LYDONGANCHAN { get; set; }
        public byte[] FILENGANCHAN { get; set; }
        public string LOAIDOITUONGNGANCHAN { get; set; }
        public string HIEULUC { get; set; }
        public string THONGTINFILENGANCHAN { get; set; }
        public string CHANCAPGIAY { get; set; }
        public string CHANGIAODICH { get; set; }
        public string CHANBIENDONG { get; set; }
        public string BIENDONGID { get; set; }
        public string DVHCID { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
    }
}
