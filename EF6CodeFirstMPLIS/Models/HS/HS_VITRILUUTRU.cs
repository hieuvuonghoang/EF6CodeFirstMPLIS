namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class HS_VITRILUUTRU
    {
        public string VITRILUUTRUID { get; set; }
        public string KHOACHAID { get; set; }
        public string MAVITRILUUTRU { get; set; }
        public string TENVITRILUUTRU { get; set; }
        public string MOTA { get; set; }
        public string XAID { get; set; }
        public byte[] SODOVITRI { get; set; }
        public Nullable<bool> TRANGTHAI { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
    }
}
