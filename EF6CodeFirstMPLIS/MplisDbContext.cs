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

            #region "CS_..._Configuration"
            modelBuilder.Configurations.Add(new CS_CHUKYSO_Configuration());
            modelBuilder.Configurations.Add(new CS_GIAYTOXACMINH_Configuration());
            modelBuilder.Configurations.Add(new CS_LICHSUGIAHAN_Configuration());
            modelBuilder.Configurations.Add(new CS_NHACUNGCAP_Configuration());
            #endregion
            #region "DC_..._Configuration"
            modelBuilder.Configurations.Add(new DC_BD_CHUYENHTSDD_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_CHUYENMDSDD_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_CHU_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_GCN_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_GCN_GCN_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_THECHAP_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_THUA_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_THUA_THUA_Configuration());
            modelBuilder.Configurations.Add(new DC_BD_TREN_GCN_Configuration());
            modelBuilder.Configurations.Add(new DC_BIENDONG_Configuration());
            modelBuilder.Configurations.Add(new DC_CANHAN_Configuration());
            modelBuilder.Configurations.Add(new DC_CANHO_Configuration());
            modelBuilder.Configurations.Add(new DC_CANHO_HANGMUCNCH_Configuration());
            modelBuilder.Configurations.Add(new DC_CAYLAUNAM_Configuration());
            modelBuilder.Configurations.Add(new DC_CHITIETCONGKHAI_Configuration());
            modelBuilder.Configurations.Add(new DC_CONGDONG_Configuration());
            modelBuilder.Configurations.Add(new DC_CONGTRINHNGAM_Configuration());
            modelBuilder.Configurations.Add(new DC_CONGTRINHXAYDUNG_Configuration());
            modelBuilder.Configurations.Add(new DC_DANGKY_GCN_Configuration());
            modelBuilder.Configurations.Add(new DC_DANGKY_NGUOI_Configuration());
            modelBuilder.Configurations.Add(new DC_DANGKY_TAISAN_Configuration());
            modelBuilder.Configurations.Add(new DC_DANGKY_THUA_Configuration());
            modelBuilder.Configurations.Add(new DC_DANHSACHCONGKHAI_Configuration());
            modelBuilder.Configurations.Add(new DC_DIACHI_Configuration());
            modelBuilder.Configurations.Add(new DC_DOANDUONG_Configuration());
            modelBuilder.Configurations.Add(new DC_DONDANGKY_Configuration());
            modelBuilder.Configurations.Add(new DC_DONKIENNGHI_Configuration());
            modelBuilder.Configurations.Add(new DC_GCN_TILESH_Configuration());
            modelBuilder.Configurations.Add(new DC_GIAYCHUNGNHAN_Configuration());
            modelBuilder.Configurations.Add(new DC_GIAYTOTUYTHAN_Configuration());
            modelBuilder.Configurations.Add(new DC_GTKEMTHEO_Configuration());
            modelBuilder.Configurations.Add(new DC_HANCHE_Configuration());
            modelBuilder.Configurations.Add(new DC_HANGMUCCONGTRINH_Configuration());
            modelBuilder.Configurations.Add(new DC_HANGMUCNGOAICANHO_Configuration());
            modelBuilder.Configurations.Add(new DC_HOGIADINH_Configuration());
            modelBuilder.Configurations.Add(new DC_HOGIADINH_THANHVIEN_Configuration());
            modelBuilder.Configurations.Add(new DC_KHOANDUOCTRU_Configuration());
            modelBuilder.Configurations.Add(new DC_KHUCHUNGCU_Configuration());
            modelBuilder.Configurations.Add(new DC_KHUVUC_Configuration());
            modelBuilder.Configurations.Add(new DC_LOAIBIENDONG_Configuration());
            modelBuilder.Configurations.Add(new DC_LOAICHEDOMIENGIAM_Configuration());
            modelBuilder.Configurations.Add(new DC_LOAICHEDONO_Configuration());
            modelBuilder.Configurations.Add(new DC_LOAIHANCHE_Configuration());
            modelBuilder.Configurations.Add(new DC_LOAINGHIAVUTAICHINH_Configuration());
            modelBuilder.Configurations.Add(new DC_MIENGIAMNVTC_Configuration());
            modelBuilder.Configurations.Add(new DC_MUCDICHSUDUNGDATLS_Configuration());
            modelBuilder.Configurations.Add(new DC_MUCDICHSUDUNGDAT_Configuration());
            modelBuilder.Configurations.Add(new DC_NGANCHANGIAYCHUNGNHAN_Configuration());
            modelBuilder.Configurations.Add(new DC_NGANCHANNGUOI_Configuration());
            modelBuilder.Configurations.Add(new DC_NGANCHANTAISAN_Configuration());
            modelBuilder.Configurations.Add(new DC_NGANCHANTHUADAT_Configuration());
            modelBuilder.Configurations.Add(new DC_NGHIAVUTAICHINH_Configuration());
            modelBuilder.Configurations.Add(new DC_NGUOILS_Configuration());
            modelBuilder.Configurations.Add(new DC_NGUOI_Configuration());
            modelBuilder.Configurations.Add(new DC_NGUOI_DIACHI_Configuration());
            modelBuilder.Configurations.Add(new DC_NGUONGOCSUDUNG_Configuration());
            modelBuilder.Configurations.Add(new DC_NHACHUNGCU_Configuration());
            modelBuilder.Configurations.Add(new DC_NHARIENGLE_Configuration());
            modelBuilder.Configurations.Add(new DC_NHOMNGUOI_Configuration());
            modelBuilder.Configurations.Add(new DC_NHOMNGUOI_THANHVIEN_Configuration());
            modelBuilder.Configurations.Add(new DC_NOICONGCHUNG_Configuration());
            modelBuilder.Configurations.Add(new DC_NONVTC_Configuration());
            modelBuilder.Configurations.Add(new DC_QUYENQUANLYDAT_Configuration());
            modelBuilder.Configurations.Add(new DC_QUYENSOHUUTAISANLS_Configuration());
            modelBuilder.Configurations.Add(new DC_QUYENSOHUUTAISAN_Configuration());
            modelBuilder.Configurations.Add(new DC_QUYENSUDUNGDATLS_Configuration());
            modelBuilder.Configurations.Add(new DC_QUYENSUDUNGDATSAUBD_Configuration());
            modelBuilder.Configurations.Add(new DC_QUYENSUDUNGDAT_Configuration());
            modelBuilder.Configurations.Add(new DC_QUYETDINH_Configuration());
            modelBuilder.Configurations.Add(new DC_RUNGTRONG_Configuration());
            modelBuilder.Configurations.Add(new DC_SODIACHINHDIENTU_CANHO_Configuration());
            modelBuilder.Configurations.Add(new DC_SODIACHINHDIENTU_THUADAT_Configuration());
            modelBuilder.Configurations.Add(new DC_TAILIEUDODAC_Configuration());
            modelBuilder.Configurations.Add(new DC_TAISANGANLIENVOIDATLICHSU_Configuration());
            modelBuilder.Configurations.Add(new DC_TAISANGANLIENVOIDATLS_Configuration());
            modelBuilder.Configurations.Add(new DC_TAISANGANLIENVOIDAT_Configuration());
            modelBuilder.Configurations.Add(new DC_TAISAN_DIACHI_Configuration());
            modelBuilder.Configurations.Add(new DC_TENDUONG_Configuration());
            modelBuilder.Configurations.Add(new DC_THONGTINNGANCHAN_Configuration());
            modelBuilder.Configurations.Add(new DC_THUADATLS_Configuration());
            modelBuilder.Configurations.Add(new DC_THUADAT_Configuration());
            modelBuilder.Configurations.Add(new DC_THUADAT_TAILIEUDODAC_Configuration());
            modelBuilder.Configurations.Add(new DC_THUADAT_TAISAN_Configuration());
            modelBuilder.Configurations.Add(new DC_THUATAISAN_Configuration());
            modelBuilder.Configurations.Add(new DC_THUEDAT_Configuration());
            modelBuilder.Configurations.Add(new DC_TOCHUC_Configuration());
            modelBuilder.Configurations.Add(new DC_TRANHCHAP_Configuration());
            modelBuilder.Configurations.Add(new DC_VITRITHUADAT_Configuration());
            modelBuilder.Configurations.Add(new DC_VOCHONG_Configuration());
            modelBuilder.Configurations.Add(new DC_XACNHANDONDANGKY_Configuration());
            modelBuilder.Configurations.Add(new DC_XA_TENDUONG_Configuration());
            modelBuilder.Configurations.Add(new DC_YKIENXACNHAN_Configuration());
            #endregion
            #region "DM_..._Configuration"
            modelBuilder.Configurations.Add(new DM_BOTHUTUCHANHCHINH_Configuration());
            modelBuilder.Configurations.Add(new DM_DANTOC_Configuration());
            modelBuilder.Configurations.Add(new DM_DOITUONGSUDUNG_Configuration());
            modelBuilder.Configurations.Add(new DM_GIAYTOKEMTHEOHS_Configuration());
            modelBuilder.Configurations.Add(new DM_HINHTHUCSUDUNGDAT_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIBANDODIACHINH_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIBIENDONG_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAICAPHANG_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIDATHIENTRANG_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIDIADANH_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIDIEMDOCAO_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIDIEMTOADO_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIDTMIENGIAM_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIDUONGTHUYHE_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIDUONG_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIGIAYTOTUYTHAN_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIHANHDONG_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIHANHLANGANTOANBAOVE_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIKETCAU_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIKHUCHUCNANGCAPHUYEN_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIKHUCHUCNANGCAPTINH_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIKHUVUCTONGHOP_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIMOCBIENGIOIDIAGIOI_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIMOC_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAINGHIAVUTAICHINH_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAINGUONGOCSUDUNG_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAINHA_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIQUYHOACH_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAITAISANGANLIENVOIDAT_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAITOCHUC_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAITRANGTHAIDANGKYCAPGCN_Configuration());
            modelBuilder.Configurations.Add(new DM_LOAIVUNGTHUYHE_Configuration());
            modelBuilder.Configurations.Add(new DM_MUCDICHSUDUNGQH_Configuration());
            modelBuilder.Configurations.Add(new DM_MUCDICHSUDUNG_Configuration());
            modelBuilder.Configurations.Add(new DM_QHVOICHUHO_Configuration());
            modelBuilder.Configurations.Add(new DM_QUOCTICH_Configuration());
            modelBuilder.Configurations.Add(new DM_SEQUENCE_Configuration());
            modelBuilder.Configurations.Add(new DM_TRANGTHAIHOSO_Configuration());
            #endregion
            #region "GD_..._Configuration"
            modelBuilder.Configurations.Add(new GD_BANDOGIADAT_Configuration());
            modelBuilder.Configurations.Add(new GD_BANGGIADAT_Configuration());
            modelBuilder.Configurations.Add(new GD_DMLOAIGIADAT_Configuration());
            modelBuilder.Configurations.Add(new GD_GIATHUADAT_Configuration());
            modelBuilder.Configurations.Add(new GD_HSDCGIADAT_Configuration());
            modelBuilder.Configurations.Add(new GD_KHUNGGIADAT_Configuration());
            modelBuilder.Configurations.Add(new GD_QDGIADAT_Configuration());
            #endregion
            #region "HC_..._Configuration"
            modelBuilder.Configurations.Add(new HC_DMKVHC_Configuration());
            modelBuilder.Configurations.Add(new HC_HUYEN_Configuration());
            modelBuilder.Configurations.Add(new HC_TINHTHAMSO_Configuration());
            modelBuilder.Configurations.Add(new HC_TINH_Configuration());
            #endregion
            #region "HS_..._Configuration"
            modelBuilder.Configurations.Add(new HS_HOSO_Configuration());
            modelBuilder.Configurations.Add(new HS_LICHSU_Configuration());
            modelBuilder.Configurations.Add(new HS_LIENKETTHUADAT_Configuration());
            modelBuilder.Configurations.Add(new HS_TC_CHU_Configuration());
            modelBuilder.Configurations.Add(new HS_TC_GCN_Configuration());
            modelBuilder.Configurations.Add(new HS_THANHPHANHOSO_Configuration());
            modelBuilder.Configurations.Add(new HS_VITRILUUTRU_Configuration());
            #endregion
            #region "HT_..._Configuration"
            modelBuilder.Configurations.Add(new HT_CAUHINHNGUOIDUNG_Configuration());
            modelBuilder.Configurations.Add(new HT_CAUHINH_Configuration());
            modelBuilder.Configurations.Add(new HT_CHUCNANG_Configuration());
            modelBuilder.Configurations.Add(new HT_CHUCNANG_NHOMCHUCNANG_Configuration());
            modelBuilder.Configurations.Add(new HT_LICHSUTRUYCAP_Configuration());
            modelBuilder.Configurations.Add(new HT_MAUGIAYTOKEMTHEOHS_Configuration());
            modelBuilder.Configurations.Add(new HT_MENU_Configuration());
            modelBuilder.Configurations.Add(new HT_NGUOIDUNG_Configuration());
            modelBuilder.Configurations.Add(new HT_NGUOIDUNG_QUYEN_Configuration());
            modelBuilder.Configurations.Add(new HT_NHOMCHUCNANG_Configuration());
            modelBuilder.Configurations.Add(new HT_NHOMCHUCNANG_MENU_Configuration());
            modelBuilder.Configurations.Add(new HT_QUYEN_Configuration());
            modelBuilder.Configurations.Add(new HT_TOCHUC_Configuration());
            modelBuilder.Configurations.Add(new HT_TOCHUC_NGUOIDUNG_Configuration());
            modelBuilder.Configurations.Add(new HT_TOCHUC_NHOMCHUCNANG_Configuration());
            modelBuilder.Configurations.Add(new HT_UNGDUNG_Configuration());
            modelBuilder.Configurations.Add(new HT_XA_NGUOIDUNG_Configuration());
            modelBuilder.Configurations.Add(new HT_XA_TOCHUC_Configuration());
            #endregion
            #region "LS_..._Configuration"
            modelBuilder.Configurations.Add(new LS_BD_GCN_Configuration());
            modelBuilder.Configurations.Add(new LS_BD_THUA_Configuration());
            modelBuilder.Configurations.Add(new LS_BOHOSO_Configuration());
            modelBuilder.Configurations.Add(new LS_TC_CHU_Configuration());
            modelBuilder.Configurations.Add(new LS_TC_GCN_Configuration());
            modelBuilder.Configurations.Add(new LS_TC_HOSO_Configuration());
            modelBuilder.Configurations.Add(new LS_TC_THUA_Configuration());
            #endregion
            #region "MT_..._Configuration"
            modelBuilder.Configurations.Add(new MT_CHATLUONG_Configuration());
            modelBuilder.Configurations.Add(new MT_DONVI_Configuration());
            modelBuilder.Configurations.Add(new MT_GIOIHAN_Configuration());
            modelBuilder.Configurations.Add(new MT_HEQUYCHIEU_Configuration());
            modelBuilder.Configurations.Add(new MT_LANDDATA_Configuration());
            modelBuilder.Configurations.Add(new MT_METADATA_Configuration());
            modelBuilder.Configurations.Add(new MT_PHANPHOI_Configuration());
            #endregion
            #region "QH_..._Configuration"
            modelBuilder.Configurations.Add(new QH_BIEUBANGCAPHUYEN_Configuration());
            modelBuilder.Configurations.Add(new QH_BIEUBANG_Configuration());
            modelBuilder.Configurations.Add(new QH_CAPHUYEN_Configuration());
            modelBuilder.Configurations.Add(new QH_CAPTINH_Configuration());
            modelBuilder.Configurations.Add(new QH_DINHKEMKCNCAPHUYEN_Configuration());
            modelBuilder.Configurations.Add(new QH_DINHKEMKCNCAPTINH_Configuration());
            modelBuilder.Configurations.Add(new QH_DINHKEMQUYHOACHCAPHUYEN_Configuration());
            modelBuilder.Configurations.Add(new QH_DINHKEMQUYHOACHCAPTINH_Configuration());
            modelBuilder.Configurations.Add(new QH_DINHKEMQUYHOACHCAPTW_Configuration());
            modelBuilder.Configurations.Add(new QH_DINHKEMQUYHOACHQPAN_Configuration());
            modelBuilder.Configurations.Add(new QH_KHUCHUCNANGCAPHUYENGEO_Configuration());
            modelBuilder.Configurations.Add(new QH_KHUCHUCNANGCAPHUYEN_Configuration());
            modelBuilder.Configurations.Add(new QH_KHUCHUCNANGCAPTINHGEO_Configuration());
            modelBuilder.Configurations.Add(new QH_KHUCHUCNANGCAPTINH_Configuration());
            modelBuilder.Configurations.Add(new QH_MDSD_Configuration());
            modelBuilder.Configurations.Add(new QH_MDSD_CT_Configuration());
            modelBuilder.Configurations.Add(new QH_QUYHOACHCAPHUYEN_Configuration());
            modelBuilder.Configurations.Add(new QH_QUYHOACHCAPTINH_Configuration());
            modelBuilder.Configurations.Add(new QH_QUYHOACHCAPTW_Configuration());
            modelBuilder.Configurations.Add(new QH_QUYHOACHQPAN_Configuration());
            modelBuilder.Configurations.Add(new QH_VUNGQUYHOACHCAPTINH_Configuration());
            #endregion
            #region "QT_..._Configuration"
            modelBuilder.Configurations.Add(new QT_BUOCQT_CAUHINH_Configuration());
            modelBuilder.Configurations.Add(new QT_BUOCQUYTRINH_Configuration());
            modelBuilder.Configurations.Add(new QT_CONGVIECTHEOBUOC_Configuration());
            modelBuilder.Configurations.Add(new QT_CONGVIECTHUCHIEN_Configuration());
            modelBuilder.Configurations.Add(new QT_FILEDINHKEMHOSO_Configuration());
            modelBuilder.Configurations.Add(new QT_GHICHUXULY_Configuration());
            modelBuilder.Configurations.Add(new QT_GIAYTOTHEOTTHC_Configuration());
            modelBuilder.Configurations.Add(new QT_HOSOTIEPNHAN_Configuration());
            modelBuilder.Configurations.Add(new QT_HOSO_LANXULY_Configuration());
            modelBuilder.Configurations.Add(new QT_LUANCHUYEN_HOSO_Configuration());
            modelBuilder.Configurations.Add(new QT_NGAYNGHI_Configuration());
            modelBuilder.Configurations.Add(new QT_NHOMQUYTRINH_Configuration());
            modelBuilder.Configurations.Add(new QT_QUYTRINH_Configuration());
            modelBuilder.Configurations.Add(new QT_THUTUCHANHCHINH_Configuration());
            modelBuilder.Configurations.Add(new QT_TTHC_QUYTRINH_Configuration());
            #endregion

            //
            modelBuilder.Configurations.Add(new LOAIHOSO_DONVIAPDUNG_Configuration());

        }

        #region "CS_Table"
        public DbSet<CS_CHUKYSO> CS_CHUKYSO { get; set; }
        public DbSet<CS_GIAYTOXACMINH> CS_GIAYTOXACMINH { get; set; }
        public DbSet<CS_LICHSUGIAHAN> CS_LICHSUGIAHAN { get; set; }
        public DbSet<CS_NHACUNGCAP> CS_NHACUNGCAP { get; set; }
        #endregion

        #region "DC_Table"
        public DbSet<DC_BD_CHU> DC_BD_CHU { get; set; }
        public DbSet<DC_BD_CHUYENHTSDD> DC_BD_CHUYENHTSDD { get; set; }
        public DbSet<DC_BD_CHUYENMDSDD> DC_BD_CHUYENMDSDD { get; set; }
        public DbSet<DC_BD_GCN> DC_BD_GCN { get; set; }
        public DbSet<DC_BD_GCN_GCN> DC_BD_GCN_GCN { get; set; }
        public DbSet<DC_BD_THECHAP> DC_BD_THECHAP { get; set; }
        public DbSet<DC_BD_THUA> DC_BD_THUA { get; set; }
        public DbSet<DC_BD_THUA_THUA> DC_BD_THUA_THUA { get; set; }
        public DbSet<DC_BD_TREN_GCN> DC_BD_TREN_GCN { get; set; }
        public DbSet<DC_BIENDONG> DC_BIENDONG { get; set; }
        public DbSet<DC_CANHAN> DC_CANHAN { get; set; }
        public DbSet<DC_CANHO> DC_CANHO { get; set; }
        public DbSet<DC_CANHO_HANGMUCNCH> DC_CANHO_HANGMUCNCH { get; set; }
        public DbSet<DC_CAYLAUNAM> DC_CAYLAUNAM { get; set; }
        public DbSet<DC_CHITIETCONGKHAI> DC_CHITIETCONGKHAI { get; set; }
        public DbSet<DC_CONGDONG> DC_CONGDONG { get; set; }
        public DbSet<DC_CONGTRINHNGAM> DC_CONGTRINHNGAM { get; set; }
        public DbSet<DC_CONGTRINHXAYDUNG> DC_CONGTRINHXAYDUNG { get; set; }
        public DbSet<DC_DANGKY_GCN> DC_DANGKY_GCN { get; set; }
        public DbSet<DC_DANGKY_NGUOI> DC_DANGKY_NGUOI { get; set; }
        public DbSet<DC_DANGKY_TAISAN> DC_DANGKY_TAISAN { get; set; }
        public DbSet<DC_DANGKY_THUA> DC_DANGKY_THUA { get; set; }
        public DbSet<DC_DANHSACHCONGKHAI> DC_DANHSACHCONGKHAI { get; set; }
        public DbSet<DC_DIACHI> DC_DIACHI { get; set; }
        public DbSet<DC_DOANDUONG> DC_DOANDUONG { get; set; }
        public DbSet<DC_DONDANGKY> DC_DONDANGKY { get; set; }
        public DbSet<DC_DONKIENNGHI> DC_DONKIENNGHI { get; set; }
        public DbSet<DC_GCN_TILESH> DC_GCN_TILESH { get; set; }
        public DbSet<DC_GIAYCHUNGNHAN> DC_GIAYCHUNGNHAN { get; set; }
        public DbSet<DC_GIAYTOTUYTHAN> DC_GIAYTOTUYTHAN { get; set; }
        public DbSet<DC_GTKEMTHEO> DC_GTKEMTHEO { get; set; }
        public DbSet<DC_HANCHE> DC_HANCHE { get; set; }
        public DbSet<DC_HANGMUCCONGTRINH> DC_HANGMUCCONGTRINH { get; set; }
        public DbSet<DC_HANGMUCNGOAICANHO> DC_HANGMUCNGOAICANHO { get; set; }
        public DbSet<DC_HOGIADINH> DC_HOGIADINH { get; set; }
        public DbSet<DC_HOGIADINH_THANHVIEN> DC_HOGIADINH_THANHVIEN { get; set; }
        public DbSet<DC_KHOANDUOCTRU> DC_KHOANDUOCTRU { get; set; }
        public DbSet<DC_KHUCHUNGCU> DC_KHUCHUNGCU { get; set; }
        public DbSet<DC_KHUVUC> DC_KHUVUC { get; set; }
        public DbSet<DC_LOAIBIENDONG> DC_LOAIBIENDONG { get; set; }
        public DbSet<DC_LOAICHEDOMIENGIAM> DC_LOAICHEDOMIENGIAM { get; set; }
        public DbSet<DC_LOAICHEDONO> DC_LOAICHEDONO { get; set; }
        public DbSet<DC_LOAIHANCHE> DC_LOAIHANCHE { get; set; }
        public DbSet<DC_LOAINGHIAVUTAICHINH> DC_LOAINGHIAVUTAICHINH { get; set; }
        public DbSet<DC_MIENGIAMNVTC> DC_MIENGIAMNVTC { get; set; }
        public DbSet<DC_MUCDICHSUDUNGDAT> DC_MUCDICHSUDUNGDAT { get; set; }
        public DbSet<DC_MUCDICHSUDUNGDATLS> DC_MUCDICHSUDUNGDATLS { get; set; }
        public DbSet<DC_NGANCHANGIAYCHUNGNHAN> DC_NGANCHANGIAYCHUNGNHAN { get; set; }
        public DbSet<DC_NGANCHANNGUOI> DC_NGANCHANNGUOI { get; set; }
        public DbSet<DC_NGANCHANTAISAN> DC_NGANCHANTAISAN { get; set; }
        public DbSet<DC_NGANCHANTHUADAT> DC_NGANCHANTHUADAT { get; set; }
        public DbSet<DC_NGHIAVUTAICHINH> DC_NGHIAVUTAICHINH { get; set; }
        public DbSet<DC_NGUOI> DC_NGUOI { get; set; }
        public DbSet<DC_NGUOILS> DC_NGUOILS { get; set; }
        public DbSet<DC_NGUOI_DIACHI> DC_NGUOI_DIACHI { get; set; }
        public DbSet<DC_NGUONGOCSUDUNG> DC_NGUONGOCSUDUNG { get; set; }
        public DbSet<DC_NHACHUNGCU> DC_NHACHUNGCU { get; set; }
        public DbSet<DC_NHARIENGLE> DC_NHARIENGLE { get; set; }
        public DbSet<DC_NHOMNGUOI> DC_NHOMNGUOI { get; set; }
        public DbSet<DC_NHOMNGUOI_THANHVIEN> DC_NHOMNGUOI_THANHVIEN { get; set; }
        public DbSet<DC_NOICONGCHUNG> DC_NOICONGCHUNG { get; set; }
        public DbSet<DC_NONVTC> DC_NONVTC { get; set; }
        public DbSet<DC_QUYENQUANLYDAT> DC_QUYENQUANLYDAT { get; set; }
        public DbSet<DC_QUYENSOHUUTAISAN> DC_QUYENSOHUUTAISAN { get; set; }
        public DbSet<DC_QUYENSOHUUTAISANLS> DC_QUYENSOHUUTAISANLS { get; set; }
        public DbSet<DC_QUYENSUDUNGDAT> DC_QUYENSUDUNGDAT { get; set; }
        public DbSet<DC_QUYENSUDUNGDATLS> DC_QUYENSUDUNGDATLS { get; set; }
        public DbSet<DC_QUYENSUDUNGDATSAUBD> DC_QUYENSUDUNGDATSAUBD { get; set; }
        public DbSet<DC_QUYETDINH> DC_QUYETDINH { get; set; }
        public DbSet<DC_RUNGTRONG> DC_RUNGTRONG { get; set; }
        public DbSet<DC_SODIACHINHDIENTU_CANHO> DC_SODIACHINHDIENTU_CANHO { get; set; }
        public DbSet<DC_SODIACHINHDIENTU_THUADAT> DC_SODIACHINHDIENTU_THUADAT { get; set; }
        public DbSet<DC_TAILIEUDODAC> DC_TAILIEUDODAC { get; set; }
        public DbSet<DC_TAISANGANLIENVOIDAT> DC_TAISANGANLIENVOIDAT { get; set; }
        public DbSet<DC_TAISANGANLIENVOIDATLICHSU> DC_TAISANGANLIENVOIDATLICHSU { get; set; }
        public DbSet<DC_TAISANGANLIENVOIDATLS> DC_TAISANGANLIENVOIDATLS { get; set; }
        public DbSet<DC_TAISAN_DIACHI> DC_TAISAN_DIACHI { get; set; }
        public DbSet<DC_TENDUONG> DC_TENDUONG { get; set; }
        public DbSet<DC_THONGTINNGANCHAN> DC_THONGTINNGANCHAN { get; set; }
        public DbSet<DC_THUADAT> DC_THUADAT { get; set; }
        public DbSet<DC_THUADATLS> DC_THUADATLS { get; set; }
        public DbSet<DC_THUADAT_TAILIEUDODAC> DC_THUADAT_TAILIEUDODAC { get; set; }
        public DbSet<DC_THUADAT_TAISAN> DC_THUADAT_TAISAN { get; set; }
        public DbSet<DC_THUATAISAN> DC_THUATAISAN { get; set; }
        public DbSet<DC_THUEDAT> DC_THUEDAT { get; set; }
        public DbSet<DC_TOCHUC> DC_TOCHUC { get; set; }
        public DbSet<DC_TRANHCHAP> DC_TRANHCHAP { get; set; }
        public DbSet<DC_VITRITHUADAT> DC_VITRITHUADAT { get; set; }
        public DbSet<DC_VOCHONG> DC_VOCHONG { get; set; }
        public DbSet<DC_XACNHANDONDANGKY> DC_XACNHANDONDANGKY { get; set; }
        public DbSet<DC_XA_TENDUONG> DC_XA_TENDUONG { get; set; }
        public DbSet<DC_YKIENXACNHAN> DC_YKIENXACNHAN { get; set; }
        #endregion

        #region "DM_Table"
        public DbSet<DM_BOTHUTUCHANHCHINH> DM_BOTHUTUCHANHCHINH { get; set; }
        public DbSet<DM_DANTOC> DM_DANTOC { get; set; }
        public DbSet<DM_DOITUONGSUDUNG> DM_DOITUONGSUDUNG { get; set; }
        public DbSet<DM_GIAYTOKEMTHEOHS> DM_GIAYTOKEMTHEOHS { get; set; }
        public DbSet<DM_HINHTHUCSUDUNGDAT> DM_HINHTHUCSUDUNGDAT { get; set; }
        public DbSet<DM_LOAIBANDODIACHINH> DM_LOAIBANDODIACHINH { get; set; }
        public DbSet<DM_LOAIBIENDONG> DM_LOAIBIENDONG { get; set; }
        public DbSet<DM_LOAICAPHANG> DM_LOAICAPHANG { get; set; }
        public DbSet<DM_LOAIDATHIENTRANG> DM_LOAIDATHIENTRANG { get; set; }
        public DbSet<DM_LOAIDIADANH> DM_LOAIDIADANH { get; set; }
        public DbSet<DM_LOAIDIEMDOCAO> DM_LOAIDIEMDOCAO { get; set; }
        public DbSet<DM_LOAIDIEMTOADO> DM_LOAIDIEMTOADO { get; set; }
        public DbSet<DM_LOAIDTMIENGIAM> DM_LOAIDTMIENGIAM { get; set; }
        public DbSet<DM_LOAIDUONG> DM_LOAIDUONG { get; set; }
        public DbSet<DM_LOAIDUONGTHUYHE> DM_LOAIDUONGTHUYHE { get; set; }
        public DbSet<DM_LOAIGIAYTOTUYTHAN> DM_LOAIGIAYTOTUYTHAN { get; set; }
        public DbSet<DM_LOAIHANHDONG> DM_LOAIHANHDONG { get; set; }
        public DbSet<DM_LOAIHANHLANGANTOANBAOVE> DM_LOAIHANHLANGANTOANBAOVE { get; set; }
        public DbSet<DM_LOAIKETCAU> DM_LOAIKETCAU { get; set; }
        public DbSet<DM_LOAIKHUCHUCNANGCAPHUYEN> DM_LOAIKHUCHUCNANGCAPHUYEN { get; set; }
        public DbSet<DM_LOAIKHUCHUCNANGCAPTINH> DM_LOAIKHUCHUCNANGCAPTINH { get; set; }
        public DbSet<DM_LOAIKHUVUCTONGHOP> DM_LOAIKHUVUCTONGHOP { get; set; }
        public DbSet<DM_LOAIMOC> DM_LOAIMOC { get; set; }
        public DbSet<DM_LOAIMOCBIENGIOIDIAGIOI> DM_LOAIMOCBIENGIOIDIAGIOI { get; set; }
        public DbSet<DM_LOAINGHIAVUTAICHINH> DM_LOAINGHIAVUTAICHINH { get; set; }
        public DbSet<DM_LOAINGUONGOCSUDUNG> DM_LOAINGUONGOCSUDUNG { get; set; }
        public DbSet<DM_LOAINHA> DM_LOAINHA { get; set; }
        public DbSet<DM_LOAIQUYHOACH> DM_LOAIQUYHOACH { get; set; }
        public DbSet<DM_LOAITAISANGANLIENVOIDAT> DM_LOAITAISANGANLIENVOIDAT { get; set; }
        public DbSet<DM_LOAITOCHUC> DM_LOAITOCHUC { get; set; }
        public DbSet<DM_LOAITRANGTHAIDANGKYCAPGCN> DM_LOAITRANGTHAIDANGKYCAPGCN { get; set; }
        public DbSet<DM_LOAIVUNGTHUYHE> DM_LOAIVUNGTHUYHE { get; set; }
        public DbSet<DM_MUCDICHSUDUNG> DM_MUCDICHSUDUNG { get; set; }
        public DbSet<DM_MUCDICHSUDUNGQH> DM_MUCDICHSUDUNGQH { get; set; }
        public DbSet<DM_QHVOICHUHO> DM_QHVOICHUHO { get; set; }
        public DbSet<DM_QUOCTICH> DM_QUOCTICH { get; set; }
        public DbSet<DM_SEQUENCE> DM_SEQUENCE { get; set; }
        public DbSet<DM_TRANGTHAIHOSO> DM_TRANGTHAIHOSO { get; set; }
        #endregion

        #region "GD_Table"
        public DbSet<GD_BANDOGIADAT> GD_BANDOGIADAT { get; set; }
        public DbSet<GD_BANGGIADAT> GD_BANGGIADAT { get; set; }
        public DbSet<GD_DMLOAIGIADAT> GD_DMLOAIGIADAT { get; set; }
        public DbSet<GD_GIATHUADAT> GD_GIATHUADAT { get; set; }
        public DbSet<GD_HSDCGIADAT> GD_HSDCGIADAT { get; set; }
        public DbSet<GD_KHUNGGIADAT> GD_KHUNGGIADAT { get; set; }
        public DbSet<GD_QDGIADAT> GD_QDGIADAT { get; set; }
        #endregion

        #region "HC_Table"
        public DbSet<HC_DMKVHC> HC_DMKVHC { get; set; }
        public DbSet<HC_HUYEN> HC_HUYEN { get; set; }
        public DbSet<HC_TINH> HC_TINH { get; set; }
        public DbSet<HC_TINHTHAMSO> HC_TINHTHAMSO { get; set; }
        #endregion

        #region "HS_Table"
        public DbSet<HS_HOSO> HS_HOSO { get; set; }
        public DbSet<HS_LICHSU> HS_LICHSU { get; set; }
        public DbSet<HS_LIENKETTHUADAT> HS_LIENKETTHUADAT { get; set; }
        public DbSet<HS_TC_CHU> HS_TC_CHU { get; set; }
        public DbSet<HS_TC_GCN> HS_TC_GCN { get; set; }
        public DbSet<HS_THANHPHANHOSO> HS_THANHPHANHOSO { get; set; }
        public DbSet<HS_VITRILUUTRU> HS_VITRILUUTRU { get; set; }
        #endregion

        #region "HSV_Table"
        //public DbSet<HSV_HUYEN_NGUOIDUNG> HSV_HUYEN_NGUOIDUNG { get; set; }
        //public DbSet<HSV_LICHSU> HSV_LICHSU { get; set; }
        //public DbSet<HSV_TINH_NGUOIDUNG> HSV_TINH_NGUOIDUNG { get; set; }
        //public DbSet<HSV_XA_NGUOIDUNG> HSV_XA_NGUOIDUNG { get; set; }
        #endregion

        #region "HT_Table"
        public DbSet<HT_CAUHINH> HT_CAUHINH { get; set; }
        public DbSet<HT_CAUHINHNGUOIDUNG> HT_CAUHINHNGUOIDUNG { get; set; }
        public DbSet<HT_CHUCNANG> HT_CHUCNANG { get; set; }
        public DbSet<HT_CHUCNANG_NHOMCHUCNANG> HT_CHUCNANG_NHOMCHUCNANG { get; set; }
        public DbSet<HT_LICHSUTRUYCAP> HT_LICHSUTRUYCAP { get; set; }
        public DbSet<HT_MAUGIAYTOKEMTHEOHS> HT_MAUGIAYTOKEMTHEOHS { get; set; }
        public DbSet<HT_MENU> HT_MENU { get; set; }
        public DbSet<HT_NGUOIDUNG> HT_NGUOIDUNG { get; set; }
        public DbSet<HT_NGUOIDUNG_QUYEN> HT_NGUOIDUNG_QUYEN { get; set; }
        public DbSet<HT_NHOMCHUCNANG> HT_NHOMCHUCNANG { get; set; }
        public DbSet<HT_NHOMCHUCNANG_MENU> HT_NHOMCHUCNANG_MENU { get; set; }
        public DbSet<HT_QUYEN> HT_QUYEN { get; set; }
        public DbSet<HT_THONGBAO> HT_THONGBAO { get; set; }
        public DbSet<HT_TOCHUC> HT_TOCHUC { get; set; }
        public DbSet<HT_TOCHUC_NGUOIDUNG> HT_TOCHUC_NGUOIDUNG { get; set; }
        public DbSet<HT_TOCHUC_NHOMCHUCNANG> HT_TOCHUC_NHOMCHUCNANG { get; set; }
        public DbSet<HT_UNGDUNG> HT_UNGDUNG { get; set; }
        public DbSet<HT_XA_NGUOIDUNG> HT_XA_NGUOIDUNG { get; set; }
        public DbSet<HT_XA_TOCHUC> HT_XA_TOCHUC { get; set; }
        #endregion

        #region "HTV_Table"
        //public DbSet<HTV_MAUGIAYTO> HTV_MAUGIAYTO { get; set; }
        //public DbSet<HTV_NGUOIDUNG_CHUCNANG> HTV_NGUOIDUNG_CHUCNANG { get; set; }
        //public DbSet<HTV_NGUOIDUNG_CHUCVU> HTV_NGUOIDUNG_CHUCVU { get; set; }
        //public DbSet<HTV_NGUOIDUNG_MENU> HTV_NGUOIDUNG_MENU { get; set; }
        //public DbSet<HTV_NGUOIDUNG_UNGDUNG> HTV_NGUOIDUNG_UNGDUNG { get; set; }
        #endregion

        #region "LS_Table"
        public DbSet<LS_BD_GCN> LS_BD_GCN { get; set; }
        public DbSet<LS_BD_THUA> LS_BD_THUA { get; set; }
        public DbSet<LS_BOHOSO> LS_BOHOSO { get; set; }
        public DbSet<LS_TC_CHU> LS_TC_CHU { get; set; }
        public DbSet<LS_TC_GCN> LS_TC_GCN { get; set; }
        public DbSet<LS_TC_HOSO> LS_TC_HOSO { get; set; }
        public DbSet<LS_TC_THUA> LS_TC_THUA { get; set; }
        #endregion

        #region "MT_Table"
        public DbSet<MT_CHATLUONG> MT_CHATLUONG { get; set; }
        public DbSet<MT_DONVI> MT_DONVI { get; set; }
        public DbSet<MT_GIOIHAN> MT_GIOIHAN { get; set; }
        public DbSet<MT_HEQUYCHIEU> MT_HEQUYCHIEU { get; set; }
        public DbSet<MT_LANDDATA> MT_LANDDATA { get; set; }
        public DbSet<MT_METADATA> MT_METADATA { get; set; }
        public DbSet<MT_PHANPHOI> MT_PHANPHOI { get; set; }
        #endregion

        #region "QH_Table"
        public DbSet<QH_BIEUBANG> QH_BIEUBANG { get; set; }
        public DbSet<QH_BIEUBANGCAPHUYEN> QH_BIEUBANGCAPHUYEN { get; set; }
        public DbSet<QH_CAPHUYEN> QH_CAPHUYEN { get; set; }
        public DbSet<QH_CAPTINH> QH_CAPTINH { get; set; }
        public DbSet<QH_DINHKEMKCNCAPHUYEN> QH_DINHKEMKCNCAPHUYEN { get; set; }
        public DbSet<QH_DINHKEMKCNCAPTINH> QH_DINHKEMKCNCAPTINH { get; set; }
        public DbSet<QH_DINHKEMQUYHOACHCAPHUYEN> QH_DINHKEMQUYHOACHCAPHUYEN { get; set; }
        public DbSet<QH_DINHKEMQUYHOACHCAPTINH> QH_DINHKEMQUYHOACHCAPTINH { get; set; }
        public DbSet<QH_DINHKEMQUYHOACHCAPTW> QH_DINHKEMQUYHOACHCAPTW { get; set; }
        public DbSet<QH_DINHKEMQUYHOACHQPAN> QH_DINHKEMQUYHOACHQPAN { get; set; }
        public DbSet<QH_KHUCHUCNANGCAPHUYEN> QH_KHUCHUCNANGCAPHUYEN { get; set; }
        public DbSet<QH_KHUCHUCNANGCAPHUYENGEO> QH_KHUCHUCNANGCAPHUYENGEO { get; set; }
        public DbSet<QH_KHUCHUCNANGCAPTINH> QH_KHUCHUCNANGCAPTINH { get; set; }
        public DbSet<QH_KHUCHUCNANGCAPTINHGEO> QH_KHUCHUCNANGCAPTINHGEO { get; set; }
        public DbSet<QH_MDSD> QH_MDSD { get; set; }
        public DbSet<QH_MDSD_CT> QH_MDSD_CT { get; set; }
        public DbSet<QH_QUYHOACHCAPHUYEN> QH_QUYHOACHCAPHUYEN { get; set; }
        public DbSet<QH_QUYHOACHCAPTINH> QH_QUYHOACHCAPTINH { get; set; }
        public DbSet<QH_QUYHOACHCAPTW> QH_QUYHOACHCAPTW { get; set; }
        public DbSet<QH_QUYHOACHQPAN> QH_QUYHOACHQPAN { get; set; }
        public DbSet<QH_VUNGQUYHOACHCAPTINH> QH_VUNGQUYHOACHCAPTINH { get; set; }
        #endregion

        #region "QT_Table"
        public DbSet<QT_BUOCQT_CAUHINH> QT_BUOCQT_CAUHINH { get; set; }
        public DbSet<QT_BUOCQUYTRINH> QT_BUOCQUYTRINH { get; set; }
        public DbSet<QT_CONGVIECTHEOBUOC> QT_CONGVIECTHEOBUOC { get; set; }
        public DbSet<QT_CONGVIECTHUCHIEN> QT_CONGVIECTHUCHIEN { get; set; }
        public DbSet<QT_FILEDINHKEMHOSO> QT_FILEDINHKEMHOSO { get; set; }
        public DbSet<QT_GHICHUXULY> QT_GHICHUXULY { get; set; }
        public DbSet<QT_GIAYTOTHEOTTHC> QT_GIAYTOTHEOTTHC { get; set; }
        public DbSet<QT_HOSOTIEPNHAN> QT_HOSOTIEPNHAN { get; set; }
        public DbSet<QT_HOSO_LANXULY> QT_HOSO_LANXULY { get; set; }
        public DbSet<QT_LUANCHUYEN_HOSO> QT_LUANCHUYEN_HOSO { get; set; }
        public DbSet<QT_NGAYNGHI> QT_NGAYNGHI { get; set; }
        public DbSet<QT_NHOMQUYTRINH> QT_NHOMQUYTRINH { get; set; }
        public DbSet<QT_QUYTRINH> QT_QUYTRINH { get; set; }
        public DbSet<QT_THUTUCHANHCHINH> QT_THUTUCHANHCHINH { get; set; }
        public DbSet<QT_TTHC_QUYTRINH> QT_TTHC_QUYTRINH { get; set; }
        #endregion

    }
}
