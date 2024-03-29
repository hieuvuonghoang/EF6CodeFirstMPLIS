namespace EF6CodeFirstMPLIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HT_MENU
    {
        public HT_MENU()
        {
            this.HT_MENU1 = new HashSet<HT_MENU>();
            this.HT_NHOMCHUCNANG_MENU = new HashSet<HT_NHOMCHUCNANG_MENU>();
        }
    
        public string MENUID { get; set; }
        public string KHOACHAID { get; set; }
        public string UNGDUNGID { get; set; }
        public string URL { get; set; }
        public string TENMENU { get; set; }
        public string MOTA { get; set; }
        public byte[] ICON { get; set; }
        public string CHOPHEPSUDUNG { get; set; }
        public string THUTUSAPXEP { get; set; }
        public string uId { get; set; }
        public Nullable<System.DateTime> THOIDIEMKHOITAO { get; set; }
        public string NGUOICAPNHATID { get; set; }
        public Nullable<System.DateTime> THOIDIEMCAPNHAT { get; set; }
        public string ACTION { get; set; }
        public string CONTROLLER { get; set; }
        public string MAMENU { get; set; }

        public virtual ICollection<HT_MENU> HT_MENU1 { get; set; }
        public virtual HT_MENU HT_MENU2 { get; set; }
        public virtual ICollection<HT_NHOMCHUCNANG_MENU> HT_NHOMCHUCNANG_MENU { get; set; }
    }
}
