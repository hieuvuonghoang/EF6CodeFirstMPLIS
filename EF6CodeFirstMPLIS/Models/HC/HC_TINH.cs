namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    public partial class HC_TINH
    {
        public HC_TINH()
        {
            this.HC_HUYEN = new HashSet<HC_HUYEN>();
            this.HC_TINHTHAMSO = new HashSet<HC_TINHTHAMSO>();
        }
        public string TINHID { get; set; }
        public string MATINH { get; set; }
        public string TENTINH { get; set; }
        public string PHANLOAI { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string MAKVHC { get; set; }
        
        public virtual ICollection<HC_HUYEN> HC_HUYEN { get; set; }
        public virtual ICollection<HC_TINHTHAMSO> HC_TINHTHAMSO { get; set; }
    }
}
