namespace EF6CodeFirstMPLIS.Models
{
    using Configuration;
    using System.Data.Entity;
    public class MplisDbContext : DbContext
    {
        public MplisDbContext() : base("name=MplisDbContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here
            modelBuilder.HasDefaultSchema("MPLIS21");
            //CS_..._Configuration
            modelBuilder.Configurations.Add(new CS_CHUKYSO_Configuration());
            modelBuilder.Configurations.Add(new CS_GIAYTOXACMINH_Configuration());
            modelBuilder.Configurations.Add(new CS_LICHSUGIAHAN_Configuration());
            modelBuilder.Configurations.Add(new CS_NHACUNGCAP_Configuration());
            //HT_..._Configuration
            modelBuilder.Configurations.Add(new HT_NGUOIDUNG_Configuration());
            modelBuilder.Configurations.Add(new HT_TOCHUC_Configuration());
            modelBuilder.Configurations.Add(new HT_CAUHINHNGUOIDUNG_Configuration());
            modelBuilder.Configurations.Add(new HT_LICHSUTRUYCAP_Configuration());
            modelBuilder.Configurations.Add(new HT_NGUOIDUNG_QUYEN_Configuration());
            modelBuilder.Configurations.Add(new HT_QUYEN_Configuration());
            modelBuilder.Configurations.Add(new HT_CHUCNANG_Configuration());
            modelBuilder.Configurations.Add(new HT_CHUCNANG_NHOMCHUCNANG_Configuration());
            modelBuilder.Configurations.Add(new HT_NHOMCHUCNANG_Configuration());
            modelBuilder.Configurations.Add(new HT_NHOMCHUCNANG_MENU_Configuration());
            modelBuilder.Configurations.Add(new HT_MENU_Configuration());
            modelBuilder.Configurations.Add(new HT_TOCHUC_NHOMCHUCNANG_Configuration());
            modelBuilder.Configurations.Add(new HT_XA_NGUOIDUNG_Configuration());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //DC_..._Configuration
            modelBuilder.Configurations.Add(new DC_GIAYCHUNGNHAN_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_GCN_Configuration());
            modelBuilder.Configurations.Add(new DC_BIENDONG_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_CHU_Configuration());
            modelBuilder.Configurations.Add(new DC_NGUOI_Configuration());
            modelBuilder.Configurations.Add(new DC_DANGKY_NGUOI_Configuration());
            modelBuilder.Configurations.Add(new DC_DONDANGKY_Configuration());
            modelBuilder.Configurations.Add(new DC_DANGKY_GCN_Configuration());
            modelBuilder.Configurations.Add(new DC_DANGKY_THUA_Configuration());
            modelBuilder.Configurations.Add(new DC_XACNHANDONDANGKY_Configuration());
            modelBuilder.Configurations.Add(new DC_GCN_TILESH_Configuration());
            modelBuilder.Configurations.Add(new DC_MIENGIAMNVTC_Configuration());
            modelBuilder.Configurations.Add(new DC_NGHIAVUTAICHINH_Configuration());
            modelBuilder.Configurations.Add(new DC_GTKEMTHEO_Configuration());
            modelBuilder.Configurations.Add(new DC_KHOANDUOCTRU_Configuration());
            modelBuilder.Configurations.Add(new DC_YKIENXACNHAN_Configuration());
            modelBuilder.Configurations.Add(new DC_LOAINGHIAVUTAICHINH_Configuration());
            modelBuilder.Configurations.Add(new DC_NONVTC_Configuration());
            modelBuilder.Configurations.Add(new DC_NGUOI_DIACHI_Configuration());
            modelBuilder.Configurations.Add(new DC_DIACHI_Configuration());
            modelBuilder.Configurations.Add(new DC_TAISAN_DIACHI_Configuration());
            modelBuilder.Configurations.Add(new DC_TAISANGANLIENVOIDAT_Configuration());
            modelBuilder.Configurations.Add(new DC_QUYENSOHUUTAISAN_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_THECHAP_Configuration());
            modelBuilder.Configurations.Add(new DC_QUYENQUANLYDAT_Configuration());
            modelBuilder.Configurations.Add(new DC_MUCDICHSUDUNGDAT_Configuration());
            modelBuilder.Configurations.Add(new DC_NGUONGOCSUDUNG_Configuration());
            modelBuilder.Configurations.Add(new DC_QUYENSUDUNGDAT_Configuration());
            modelBuilder.Configurations.Add(new DC_VITRITHUADAT_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_CHUYENHTSDD_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_CHUYENMDSDD_Configuration());
            modelBuilder.Configurations.Add(new DC_THUEDAT_Configuration());
            modelBuilder.Configurations.Add(new DC_THUATAISAN_Configuration());
            modelBuilder.Configurations.Add(new DC_THUADAT_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_THUA_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_THUA_THUA_Configuration());
            modelBuilder.Configurations.Add(new DC_DOANDUONG_Configuration());
            modelBuilder.Configurations.Add(new DC_KHUVUC_Configuration());
            modelBuilder.Configurations.Add(new DC_TAILIEUDODAC_Configuration());
            modelBuilder.Configurations.Add(new DC_THUADAT_TAILIEUDODAC_Configuration());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());

            //DM_..._Configuration
            modelBuilder.Configurations.Add(new DM_LOAIDTMIENGIAM_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAINGHIAVUTAICHINH_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAINGUONGOCSUDUNG_Configuration());
            modelBuilder.Configurations.Add(new DM_HINHTHUCSUDUNGDAT_Configuration());
            modelBuilder.Configurations.Add(new DM_MUCDICHSUDUNG_Configuration());
            modelBuilder.Configurations.Add(new DM_MUCDICHSUDUNGQH_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIBANDODIACHINH_Configuration());
            modelBuilder.Configurations.Add(new DM_BOTHUTUCHANHCHINH_Configuration());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());

            //HC_..._Configuration
            modelBuilder.Configurations.Add(new HC_DMKVHC_Configuration());
            modelBuilder.Configurations.Add(new HC_HUYEN_Configuration());
            modelBuilder.Configurations.Add(new HC_TINH_Configuration());
            modelBuilder.Configurations.Add(new HC_TINHTHAMSO_Configuration());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());

            //HS_..._Configuration
            modelBuilder.Configurations.Add(new HS_HOSO_Configuration());
            modelBuilder.Configurations.Add(new HS_LICHSU_Configuration());
            modelBuilder.Configurations.Add(new HS_LIENKETTHUADAT_Configuration());
            modelBuilder.Configurations.Add(new HS_TC_CHU_Configuration());
            modelBuilder.Configurations.Add(new HS_TC_GCN_Configuration());
            modelBuilder.Configurations.Add(new HS_THANHPHANHOSO_Configuration());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());

            //QT_..._Configuration
            modelBuilder.Configurations.Add(new QT_BUOCQT_CAUHINH_Configuration());
            modelBuilder.Configurations.Add(new QT_BUOCQUYTRINH_Configuration());
            modelBuilder.Configurations.Add(new QT_GHICHUXULY_Configuration());
            modelBuilder.Configurations.Add(new QT_HOSOTIEPNHAN_Configuration());
            modelBuilder.Configurations.Add(new QT_FILEDINHKEMHOSO_Configuration());
            modelBuilder.Configurations.Add(new QT_GIAYTOTHEOTTHC_Configuration());
            modelBuilder.Configurations.Add(new QT_THUTUCHANHCHINH_Configuration());
            modelBuilder.Configurations.Add(new QT_TTHC_QUYTRINH_Configuration());
            modelBuilder.Configurations.Add(new QT_QUYTRINH_Configuration());
            modelBuilder.Configurations.Add(new QT_CONGVIECTHEOBUOC_Configuration());
            modelBuilder.Configurations.Add(new QT_CONGVIECTHUCHIEN_Configuration());
            modelBuilder.Configurations.Add(new QT_LUANCHUYEN_HOSO_Configuration());
            modelBuilder.Configurations.Add(new QT_HOSO_LANXULY_Configuration());
            modelBuilder.Configurations.Add(new QT_NHOMQUYTRINH_Configuration());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());
            //modelBuilder.Configurations.Add(new ());

        }
        //CS_Table
        public DbSet<CS_CHUKYSO> CS_CHUKYSO { get; set; }
        public DbSet<CS_GIAYTOXACMINH> CS_GIAYTOXACMINH { get; set; }
        public DbSet<CS_LICHSUGIAHAN> CS_LICHSUGIAHAN { get; set; }
        public DbSet<CS_NHACUNGCAP> CS_NHACUNGCAP { get; set; }
        //HT_Table
        public DbSet<HT_NGUOIDUNG> HT_NGUOIDUNG { get; set; }
        public DbSet<HT_TOCHUC> HT_TOCHUC { get; set; }
        public DbSet<HT_CAUHINHNGUOIDUNG> HT_CAUHINHNGUOIDUNG { get; set; }
        public DbSet<HT_LICHSUTRUYCAP> HT_LICHSUTRUYCAP { get; set; }
    }
}
