﻿namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class CS_CHUKYSO
    {
        public CS_CHUKYSO()
        {
            this.CS_GIAYTOXACMINH = new HashSet<CS_GIAYTOXACMINH>();
            this.CS_LICHSUGIAHAN = new HashSet<CS_LICHSUGIAHAN>();
        }

        public string CHUKYSOID { get; set; }
        public string NHACUNGCAPID { get; set; }
        public string TOCHUCID { get; set; }
        public string NGUOIDUNGID { get; set; }
        public Nullable<decimal> LOAICHUKYSO { get; set; }
        public string NGUOIDUNGTEN { get; set; }
        public string TENTOCHUC { get; set; }
        public string CHUCVU { get; set; }
        public string NOICONGTAC { get; set; }
        public Nullable<System.DateTime> NGAYCOHIEULUC { get; set; }
        public Nullable<System.DateTime> NGAYHETHIEULUC { get; set; }
        public Nullable<bool> TRANGTHAIXACTHUC { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public string CA { get; set; }

        public virtual CS_NHACUNGCAP CS_NHACUNGCAP { get; set; }
        public virtual HT_NGUOIDUNG HT_NGUOIDUNG { get; set; }
        public virtual HT_TOCHUC HT_TOCHUC { get; set; }
        public virtual ICollection<CS_GIAYTOXACMINH> CS_GIAYTOXACMINH { get; set; }
        public virtual ICollection<CS_LICHSUGIAHAN> CS_LICHSUGIAHAN { get; set; }
    }
}
