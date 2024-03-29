namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;

    public partial class HC_TINHTHAMSO
    {
        public string TINHTHAMSOID { get; set; }
        public string THUADATSERVICELINK { get; set; }
        public Nullable<decimal> THUADATLAYERINDEX { get; set; }
        public string BASEMAPSERVICELINK { get; set; }
        public string QUYHOACHCAPTINHMAPSERVICELINK { get; set; }
        public string KHOANHDATSERVICELINK { get; set; }
        public string HIENTRANGSERVICELINK { get; set; }
        public string GIADATSERVICELINK { get; set; }
        public string VETINHSERVICELINK { get; set; }
        public string GIADATGRSERVICELINK { get; set; }
        public string MDSDSERVICELINK { get; set; }
        public string CAPGCNSERVICELINK { get; set; }
        public string TINHID { get; set; }
        public Nullable<decimal> KINHTUYENTRUC { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string uId { get; set; }
        public Nullable<decimal> QUYHOACHCAPTINHLAYERINDEX { get; set; }
        public Nullable<decimal> KHOANHDATLAYERINDEX { get; set; }
        public Nullable<decimal> HIENTRANGLAYERINDEX { get; set; }
        public Nullable<decimal> GIADATLAYERINDEX { get; set; }
        public Nullable<decimal> MDSDLAYERINDEX { get; set; }
        public Nullable<decimal> CAPGCNLAYERINDEX { get; set; }
        public Nullable<decimal> GIADATGRLAYERINDEX { get; set; }
        public string KVHCSERVICELINK { get; set; }
        public Nullable<decimal> KVHCLAYERTINHINDEX { get; set; }
        public string LOADEXPORTDGN { get; set; }
        public string LOADEXPORTGML { get; set; }
        public string GETDATAEDITDESKTOP { get; set; }
        public string THUADATMAPSERVERLINK { get; set; }
        public Nullable<decimal> THUADATMAPSERVERINDEX { get; set; }
        public Nullable<decimal> KVHCLAYERHUYENINDEX { get; set; }
        public Nullable<decimal> KVHCLAYERXAINDEX { get; set; }
        public string LOADEXPORTSHAPEFILE { get; set; }
        public string GEOMETRYSERVER { get; set; }
        public Nullable<decimal> QUYHOACHCAPHUYENLAYERINDEX { get; set; }
        public string QUYHOACHCAPHUYENMAPSERVICELINK { get; set; }
        public string QUYHOACHCAPHUYENFEATURESERVER { get; set; }
        public string QUYHOACHCAPTINHFEATURESERVER { get; set; }
        public string THUADATSERVICELINKLOCAL { get; set; }

        public virtual HC_TINH HC_TINH { get; set; }
    }
}
