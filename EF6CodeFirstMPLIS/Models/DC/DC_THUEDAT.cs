namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_THUEDAT
    {
        public string THUEDATID { get; set; }
        public Nullable<decimal> CTNDIENTICHXAYDUNG { get; set; }
        public Nullable<decimal> CTNGIADATDIENTICHXD { get; set; }
        public Nullable<decimal> DATCOMNDIENTICHMATDAT { get; set; }
        public Nullable<decimal> DATCOMNDIENTICHMATNUOC { get; set; }
        public Nullable<decimal> DATCOMNGIADAT { get; set; }
        public string MNVITRI { get; set; }
        public Nullable<decimal> MNDIENTICHTHUE { get; set; }
        public string BIENDONGID { get; set; }
        public string MUCDICHSUDUNGID { get; set; }
        public Nullable<decimal> THOIHANTHUE { get; set; }
        public Nullable<System.DateTime> TUNGAY { get; set; }
        public Nullable<System.DateTime> DENNGAY { get; set; }
        public Nullable<decimal> HINHTHUCTHUEMN { get; set; }
    
        public virtual DC_BIENDONG DC_BIENDONG { get; set; }
        public virtual DM_MUCDICHSUDUNG DM_MUCDICHSUDUNG { get; set; }
    }
}
