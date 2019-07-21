namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class DC_VITRITHUADAT
    {
        public string VITRIID { get; set; }
        public string DUONG { get; set; }
        public string DOANDUONG { get; set; }
        public string KHUVUC { get; set; }
        public Nullable<decimal> VITRI { get; set; }
        public Nullable<decimal> CHIEUSAU { get; set; }
        public Nullable<decimal> CHIEURONGNGOHEM { get; set; }
        public string MUCDICHSUDUNGDATID { get; set; }
    
        public virtual DC_MUCDICHSUDUNGDAT DC_MUCDICHSUDUNGDAT { get; set; }
    }
}
