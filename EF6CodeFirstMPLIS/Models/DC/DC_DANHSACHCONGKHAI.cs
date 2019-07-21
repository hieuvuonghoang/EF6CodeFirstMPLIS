namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_DANHSACHCONGKHAI
    {
        public DC_DANHSACHCONGKHAI()
        {
            this.DC_CHITIETCONGKHAI = new HashSet<DC_CHITIETCONGKHAI>();
            this.DC_DONKIENNGHI = new HashSet<DC_DONKIENNGHI>();
        }
    
        public string DANHSACHCONGKHAIID { get; set; }
        public string XAID { get; set; }
        public string SOVANBAN { get; set; }
        public Nullable<System.DateTime> NGAYBATDAU { get; set; }
        public Nullable<System.DateTime> NGAYKETTHUC { get; set; }
        public string DIADIEMCONGKHAI { get; set; }
        public string NGUOIDAIDIENXACNHAN { get; set; }
        public Nullable<bool> DAKETTHUC { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string NGUOICAPNHATID { get; set; }

        public virtual ICollection<DC_CHITIETCONGKHAI> DC_CHITIETCONGKHAI { get; set; }
        public virtual ICollection<DC_DONKIENNGHI> DC_DONKIENNGHI { get; set; }
    }
}
