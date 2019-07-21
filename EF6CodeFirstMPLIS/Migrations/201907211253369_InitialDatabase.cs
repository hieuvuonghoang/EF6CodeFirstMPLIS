namespace EF6CodeFirstMPLIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "MPLIS21.CS_CHUKYSO",
                c => new
                    {
                        CHUKYSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NHACUNGCAPID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TOCHUCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAICHUKYSO = c.Decimal(precision: 18, scale: 2),
                        NGUOIDUNGTEN = c.String(maxLength: 100, unicode: false),
                        TENTOCHUC = c.String(maxLength: 150, unicode: false),
                        CHUCVU = c.String(maxLength: 50, unicode: false),
                        NOICONGTAC = c.String(maxLength: 100, unicode: false),
                        NGAYCOHIEULUC = c.DateTime(),
                        NGAYHETHIEULUC = c.DateTime(),
                        TRANGTHAIXACTHUC = c.Boolean(),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        CA = c.String(),
                    })
                .PrimaryKey(t => t.CHUKYSOID)
                .ForeignKey("MPLIS21.CS_NHACUNGCAP", t => t.NHACUNGCAPID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HT_NGUOIDUNG", t => t.NGUOIDUNGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HT_TOCHUC", t => t.TOCHUCID, cascadeDelete: true)
                .Index(t => t.NHACUNGCAPID)
                .Index(t => t.NGUOIDUNGID)
                .Index(t => t.TOCHUCID);
            
            CreateTable(
                "MPLIS21.CS_GIAYTOXACMINH",
                c => new
                    {
                        GIAYTOXACMINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CHUKYSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THOIDIEMNOPXACMINH = c.DateTime(),
                        FILESCAN = c.Binary(),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        TENGIAYTO = c.String(maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.GIAYTOXACMINHID)
                .ForeignKey("MPLIS21.CS_CHUKYSO", t => t.CHUKYSOID, cascadeDelete: true)
                .Index(t => t.CHUKYSOID);
            
            CreateTable(
                "MPLIS21.CS_LICHSUGIAHAN",
                c => new
                    {
                        LICHSUGIAHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CHUKYSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THOIDIEMGIAHAN = c.DateTime(),
                        NGUOIDUNGTEN = c.String(maxLength: 100, unicode: false),
                        TENTOCHUC = c.String(maxLength: 150, unicode: false),
                        CHUCVU = c.String(maxLength: 50, unicode: false),
                        NOICONGTAC = c.String(maxLength: 100, unicode: false),
                        NGAYHETHIEULUCTRUOCGIAHAN = c.DateTime(),
                        NGAYHETHIEULUCSAUGIAHAN = c.DateTime(),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        NGUOIDUNGID = c.String(maxLength: 36, unicode: false),
                        TOCHUCID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LICHSUGIAHANID)
                .ForeignKey("MPLIS21.CS_CHUKYSO", t => t.CHUKYSOID, cascadeDelete: true)
                .Index(t => t.CHUKYSOID);
            
            CreateTable(
                "MPLIS21.CS_NHACUNGCAP",
                c => new
                    {
                        NHACUNGCAPID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENNHACUNGCAP = c.String(maxLength: 100, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        ROOTCA = c.String(),
                    })
                .PrimaryKey(t => t.NHACUNGCAPID);
            
            CreateTable(
                "MPLIS21.HT_NGUOIDUNG",
                c => new
                    {
                        NGUOIDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENDANGNHAP = c.String(maxLength: 20, unicode: false),
                        MATKHAU = c.String(maxLength: 100, unicode: false),
                        HOTENNGUOIDUNG = c.String(maxLength: 100, unicode: false),
                        GIOITINH = c.String(maxLength: 1, unicode: false),
                        SODIENTHOAI = c.String(maxLength: 15, unicode: false),
                        SODIENTHOAI2 = c.String(maxLength: 15, unicode: false),
                        EMAIL = c.String(maxLength: 50, unicode: false),
                        DIACHI = c.String(maxLength: 150, unicode: false),
                        READONLY = c.Boolean(),
                        ANHBIEUTUONG = c.Binary(),
                        PHAITHAYDOIMATKHAU = c.String(maxLength: 1, unicode: false),
                        THOIDIEMMATKHAUCOHIEULUC = c.DateTime(),
                        THOIDIEMMATKHAUHETHIEULUC = c.DateTime(),
                        CHOPHEPSUDUNG = c.String(maxLength: 1, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        CAPNGUOIDUNG = c.String(maxLength: 2, unicode: false),
                        DONVIHANHCHINHID = c.String(maxLength: 36, unicode: false),
                        LOAINGUOIDUNG = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.NGUOIDUNGID);
            
            CreateTable(
                "MPLIS21.HT_CAUHINHNGUOIDUNG",
                c => new
                    {
                        CAUHINHNGUOIDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENCAUHINH = c.String(maxLength: 50, unicode: false),
                        GIATRI = c.String(maxLength: 255, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.CAUHINHNGUOIDUNGID)
                .ForeignKey("MPLIS21.HT_NGUOIDUNG", t => t.NGUOIDUNGID, cascadeDelete: true)
                .Index(t => t.NGUOIDUNGID);
            
            CreateTable(
                "MPLIS21.HT_LICHSUTRUYCAP",
                c => new
                    {
                        LICHSUTRUYCAPID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NAM = c.Short(),
                        LOAIHANHDONG = c.String(maxLength: 1, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        uId = c.String(maxLength: 255, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.LICHSUTRUYCAPID)
                .ForeignKey("MPLIS21.HT_NGUOIDUNG", t => t.NGUOIDUNGID, cascadeDelete: true)
                .Index(t => t.NGUOIDUNGID);
            
            CreateTable(
                "MPLIS21.HT_NGUOIDUNG_QUYEN",
                c => new
                    {
                        NGUOIDUNGQUYENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        QUYENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KICHHOATQUYEN = c.Boolean(),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.NGUOIDUNGQUYENID)
                .ForeignKey("MPLIS21.HT_NGUOIDUNG", t => t.NGUOIDUNGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HT_QUYEN", t => t.QUYENID, cascadeDelete: true)
                .Index(t => t.NGUOIDUNGID)
                .Index(t => t.QUYENID);
            
            CreateTable(
                "MPLIS21.HT_QUYEN",
                c => new
                    {
                        QUYENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CHUCNANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 15, unicode: false),
                        CONTROLLERNAME = c.String(maxLength: 150, unicode: false),
                        ACTIONNAME = c.String(maxLength: 150, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.QUYENID)
                .ForeignKey("MPLIS21.HT_CHUCNANG", t => t.CHUCNANGID, cascadeDelete: true)
                .Index(t => t.CHUCNANGID);
            
            CreateTable(
                "MPLIS21.HT_CHUCNANG",
                c => new
                    {
                        CHUCNANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KHOACHAID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MACHUCNANG = c.String(maxLength: 30, unicode: false),
                        TENCHUCNANG = c.String(maxLength: 255, unicode: false),
                        URL = c.String(maxLength: 255, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 15, unicode: false),
                        CHOPHEPSUDUNG = c.String(maxLength: 1, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THUCHIENTHUCONG = c.Boolean(),
                        CACBIENDAUVAO = c.String(maxLength: 120, unicode: false),
                        CACBIENDAURA = c.String(maxLength: 120, unicode: false),
                    })
                .PrimaryKey(t => t.CHUCNANGID)
                .ForeignKey("MPLIS21.HT_CHUCNANG", t => t.KHOACHAID)
                .Index(t => t.KHOACHAID);
            
            CreateTable(
                "MPLIS21.HT_CHUCNANG_NHOMCHUCNANG",
                c => new
                    {
                        CHUCNANGNHOMCHUCNANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NHOMCHUCNANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CHUCNANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.CHUCNANGNHOMCHUCNANGID)
                .ForeignKey("MPLIS21.HT_CHUCNANG", t => t.CHUCNANGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HT_NHOMCHUCNANG", t => t.NHOMCHUCNANGID, cascadeDelete: true)
                .Index(t => t.CHUCNANGID)
                .Index(t => t.NHOMCHUCNANGID);
            
            CreateTable(
                "MPLIS21.HT_NHOMCHUCNANG",
                c => new
                    {
                        NHOMCHUCNANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        UNGDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        URL = c.String(maxLength: 255, unicode: false),
                        TENNHOM = c.String(maxLength: 255, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 10, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.NHOMCHUCNANGID)
                .ForeignKey("MPLIS21.HT_UNGDUNG", t => t.UNGDUNGID, cascadeDelete: true)
                .Index(t => t.UNGDUNGID);
            
            CreateTable(
                "MPLIS21.HT_NHOMCHUCNANG_MENU",
                c => new
                    {
                        NHOMCHUCNANGMENUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MENUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NHOMCHUCNANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.NHOMCHUCNANGMENUID)
                .ForeignKey("MPLIS21.HT_MENU", t => t.MENUID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HT_NHOMCHUCNANG", t => t.NHOMCHUCNANGID, cascadeDelete: true)
                .Index(t => t.MENUID)
                .Index(t => t.NHOMCHUCNANGID);
            
            CreateTable(
                "MPLIS21.HT_MENU",
                c => new
                    {
                        MENUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KHOACHAID = c.String(nullable: false, maxLength: 36, unicode: false),
                        UNGDUNGID = c.String(maxLength: 36, unicode: false),
                        URL = c.String(maxLength: 255, unicode: false),
                        TENMENU = c.String(maxLength: 80, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        ICON = c.Binary(),
                        CHOPHEPSUDUNG = c.String(maxLength: 1, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 50, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        ACTION = c.String(maxLength: 255, unicode: false),
                        CONTROLLER = c.String(maxLength: 255, unicode: false),
                        MAMENU = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.MENUID)
                .ForeignKey("MPLIS21.HT_MENU", t => t.KHOACHAID)
                .Index(t => t.KHOACHAID);
            
            CreateTable(
                "MPLIS21.HT_TOCHUC_NHOMCHUCNANG",
                c => new
                    {
                        TOCHUCNHOMCHUCNANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TOCHUCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NHOMCHUCNANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.TOCHUCNHOMCHUCNANGID)
                .ForeignKey("MPLIS21.HT_NHOMCHUCNANG", t => t.NHOMCHUCNANGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HT_TOCHUC", t => t.TOCHUCID, cascadeDelete: true)
                .Index(t => t.NHOMCHUCNANGID)
                .Index(t => t.TOCHUCID);
            
            CreateTable(
                "MPLIS21.HT_TOCHUC",
                c => new
                    {
                        TOCHUCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KHOACHAID = c.String(maxLength: 36, unicode: false),
                        TENTOCHUC = c.String(maxLength: 150, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 10, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        DONVIHANHCHINHID = c.String(maxLength: 36, unicode: false),
                        CAPTOCHUC = c.Byte(),
                        MATOCHUC = c.String(maxLength: 30, unicode: false),
                        HT_TOCHUC2_TOCHUCID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.TOCHUCID)
                .ForeignKey("MPLIS21.HT_TOCHUC", t => t.HT_TOCHUC2_TOCHUCID)
                .Index(t => t.HT_TOCHUC2_TOCHUCID);
            
            CreateTable(
                "MPLIS21.DC_GIAYCHUNGNHAN",
                c => new
                    {
                        GIAYCHUNGNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SOPHATHANH = c.String(maxLength: 20, unicode: false),
                        MAVACH = c.String(maxLength: 25, unicode: false),
                        BANQUET = c.String(maxLength: 2000, unicode: false),
                        NGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        DONDANGKYID = c.String(maxLength: 36, unicode: false),
                        SOVAOSO = c.String(maxLength: 10, unicode: false),
                        NGAYCAP = c.DateTime(),
                        TRANGTHAIXULY = c.String(maxLength: 1, unicode: false),
                        TRANGTHAIPL = c.String(maxLength: 1, unicode: false),
                        MAXA = c.String(maxLength: 5, unicode: false),
                        HSKTFILEPATH = c.String(maxLength: 500, unicode: false),
                        GHICHU = c.String(maxLength: 2000, unicode: false),
                        SOHUUCHUNGID = c.String(maxLength: 36, unicode: false),
                        CHUKYSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NONVTC = c.String(maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.GIAYCHUNGNHANID)
                .ForeignKey("MPLIS21.DC_NGUOI", t => t.NGUOIID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HT_TOCHUC", t => t.CHUKYSOID, cascadeDelete: true)
                .Index(t => t.NGUOIID)
                .Index(t => t.CHUKYSOID);
            
            CreateTable(
                "MPLIS21.DC_BD_GCN",
                c => new
                    {
                        BDGCNID = c.String(nullable: false, maxLength: 36, unicode: false),
                        GIAYCHUNGNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        BIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LAGCNVAO = c.String(maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.BDGCNID)
                .ForeignKey("MPLIS21.DC_BIENDONG", t => t.BIENDONGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_GIAYCHUNGNHAN", t => t.GIAYCHUNGNHANID, cascadeDelete: true)
                .Index(t => t.BIENDONGID)
                .Index(t => t.GIAYCHUNGNHANID);
            
            CreateTable(
                "MPLIS21.DC_BIENDONG",
                c => new
                    {
                        BIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAIBIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THOIDIEMBIENDONG = c.DateTime(),
                        MACOQUANTHUCHIEN = c.String(maxLength: 10, unicode: false),
                        SOTHUTU = c.Decimal(precision: 18, scale: 2),
                        MABIENDONG = c.String(maxLength: 30, unicode: false),
                        NOIDUNGBIENDONG = c.String(maxLength: 2000, unicode: false),
                        SOHOPDONG = c.String(maxLength: 30, unicode: false),
                        NGAYHOPDONG = c.DateTime(),
                        NOIDUNGHOPDONG = c.String(maxLength: 2000, unicode: false),
                        SOCONGCHUNG = c.String(maxLength: 20, unicode: false),
                        QUYENCONGCHUNG = c.String(maxLength: 20, unicode: false),
                        NGAYCONGCHUNG = c.DateTime(),
                        NOICONGCHUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        QUYETDINHID = c.String(maxLength: 36, unicode: false),
                        HOSOTIEPNHANID = c.String(maxLength: 36, unicode: false),
                        COTHUAXULY = c.String(maxLength: 1, unicode: false),
                        SOTHUTUBIENDONG = c.Decimal(precision: 18, scale: 2),
                        MAHSTTDANGKY = c.String(maxLength: 30, unicode: false),
                        NGAYTRUOCBA = c.DateTime(),
                        LYDOBIENDONG = c.String(maxLength: 50, unicode: false),
                        MAHOSOTHUTUCDANGKY = c.String(maxLength: 100, unicode: false),
                        NOICONGCHUNG = c.String(maxLength: 255, unicode: false),
                        MAKVHC = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.BIENDONGID)
                .ForeignKey("MPLIS21.DC_LOAIBIENDONG", t => t.LOAIBIENDONGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_NOICONGCHUNG", t => t.NOICONGCHUNGID, cascadeDelete: true)
                .Index(t => t.LOAIBIENDONGID)
                .Index(t => t.NOICONGCHUNGID);
            
            CreateTable(
                "MPLIS21.DC_BD_CHU",
                c => new
                    {
                        BDGCNID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        BIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        VAITROCHU = c.String(maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.BDGCNID)
                .ForeignKey("MPLIS21.DC_BIENDONG", t => t.BIENDONGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_NGUOI", t => t.NGUOIID, cascadeDelete: true)
                .Index(t => t.BIENDONGID)
                .Index(t => t.NGUOIID);
            
            CreateTable(
                "MPLIS21.DC_NGUOI",
                c => new
                    {
                        NGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CHITIETID = c.String(maxLength: 36, unicode: false),
                        LOAIDOITUONGID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        DOITUONGSUDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MADINHDANH = c.String(maxLength: 20, unicode: false),
                        MASOTHUE = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.NGUOIID)
                .ForeignKey("MPLIS21.DM_DOITUONGSUDUNG", t => t.DOITUONGSUDUNGID, cascadeDelete: true)
                .Index(t => t.DOITUONGSUDUNGID);
            
            CreateTable(
                "MPLIS21.DC_DANGKY_NGUOI",
                c => new
                    {
                        DANGKYNGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DONDANGKYID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MOTATOMTAT = c.String(maxLength: 150, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        LOAI = c.Decimal(precision: 18, scale: 2),
                        DENGHIDANGKY = c.Decimal(precision: 18, scale: 2),
                        CONHUCAUGHINONVTC = c.Boolean(),
                        DENGHIKHAC = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.DANGKYNGUOIID)
                .ForeignKey("MPLIS21.DC_DONDANGKY", t => t.DONDANGKYID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_NGUOI", t => t.NGUOIID, cascadeDelete: true)
                .Index(t => t.DONDANGKYID)
                .Index(t => t.NGUOIID);
            
            CreateTable(
                "MPLIS21.DC_DONDANGKY",
                c => new
                    {
                        DONDANGKYID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MADON = c.String(maxLength: 100, unicode: false),
                        NGAYDANGKY = c.DateTime(),
                        GHICHU = c.String(maxLength: 1000, unicode: false),
                        DACAPGIAY = c.String(maxLength: 1, unicode: false),
                        CANCUPHAPLY = c.String(maxLength: 30, unicode: false),
                        SOVAOSO = c.String(maxLength: 10, unicode: false),
                        NGAYCAP = c.DateTime(),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        HOSOTIEPNHANID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.DONDANGKYID);
            
            CreateTable(
                "MPLIS21.DC_DANGKY_GCN",
                c => new
                    {
                        DANGKYGCNID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DONDANGKYID = c.String(nullable: false, maxLength: 36, unicode: false),
                        GIAYCHUNGNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.DANGKYGCNID)
                .ForeignKey("MPLIS21.DC_DONDANGKY", t => t.DONDANGKYID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_GIAYCHUNGNHAN", t => t.GIAYCHUNGNHANID, cascadeDelete: true)
                .Index(t => t.DONDANGKYID)
                .Index(t => t.GIAYCHUNGNHANID);
            
            CreateTable(
                "MPLIS21.DC_DANGKY_THUA",
                c => new
                    {
                        DANGKYTHUAID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DONDANGKYID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MOTATOMTAT = c.String(maxLength: 150, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        HINHTHUCSUDUNG = c.Decimal(precision: 18, scale: 2),
                        THOIHANSUDUNG = c.String(maxLength: 150, unicode: false),
                        QUYENHANCHE = c.String(maxLength: 500, unicode: false),
                        THOIDIEMSUDUNGDAT = c.String(maxLength: 150, unicode: false),
                        DUDIEUKIENCAPGIAY = c.Decimal(precision: 18, scale: 2),
                        LYDOKHONGDUDIEUKIEN = c.String(maxLength: 1000, unicode: false),
                        THUADATID = c.String(maxLength: 36, unicode: false),
                        SOTHUTHUTHUA = c.Decimal(precision: 18, scale: 2),
                        SOHIEUTOBANDO = c.Decimal(precision: 18, scale: 2),
                        XAID = c.String(maxLength: 36, unicode: false),
                        MUCDICHSUDUNGDATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.DANGKYTHUAID)
                .ForeignKey("MPLIS21.DC_DONDANGKY", t => t.DONDANGKYID, cascadeDelete: true)
                .Index(t => t.DONDANGKYID);
            
            CreateTable(
                "MPLIS21.DC_XACNHANDONDANGKY",
                c => new
                    {
                        XACNHANDONDANGKYID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DONDANGKYID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CAPXACNHAN = c.Decimal(precision: 18, scale: 2),
                        DONVIHANHCHINHID = c.String(maxLength: 36, unicode: false),
                        TENCOQUANXACNHAN = c.String(maxLength: 255, unicode: false),
                        CANBOYKIENID = c.String(maxLength: 36, unicode: false),
                        CANBOKIEMTRAID = c.String(maxLength: 36, unicode: false),
                        CANBOPHEDUYETID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.XACNHANDONDANGKYID)
                .ForeignKey("MPLIS21.DC_DONDANGKY", t => t.DONDANGKYID, cascadeDelete: true)
                .Index(t => t.DONDANGKYID);
            
            CreateTable(
                "MPLIS21.DC_YKIENXACNHAN",
                c => new
                    {
                        YKIENXACNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        XACNHANDONDANGKYID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAIYKIEN = c.String(maxLength: 255, unicode: false),
                        NOIDUNGYKIEN = c.String(maxLength: 2000, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.YKIENXACNHANID)
                .ForeignKey("MPLIS21.DC_XACNHANDONDANGKY", t => t.XACNHANDONDANGKYID, cascadeDelete: true)
                .Index(t => t.XACNHANDONDANGKYID);
            
            CreateTable(
                "MPLIS21.DC_GCN_TILESH",
                c => new
                    {
                        GCNTILESHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TILESOHUU = c.Decimal(precision: 18, scale: 2),
                        GIAYCHUNGNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THANHVIENID = c.String(maxLength: 36, unicode: false),
                        LOAIDTMIENGIAMID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.GCNTILESHID)
                .ForeignKey("MPLIS21.DC_GIAYCHUNGNHAN", t => t.GIAYCHUNGNHANID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_NGUOI", t => t.NGUOIID)
                .ForeignKey("MPLIS21.DM_LOAIDTMIENGIAM", t => t.LOAIDTMIENGIAMID, cascadeDelete: true)
                .Index(t => t.GIAYCHUNGNHANID)
                .Index(t => t.NGUOIID)
                .Index(t => t.LOAIDTMIENGIAMID);
            
            CreateTable(
                "MPLIS21.DM_LOAIDTMIENGIAM",
                c => new
                    {
                        LOAIDTMIENGIAMID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENLOAIDOITUONG = c.String(maxLength: 200, unicode: false),
                        GHICHU = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIDTMIENGIAMID);
            
            CreateTable(
                "MPLIS21.DC_MIENGIAMNVTC",
                c => new
                    {
                        MIENGIAMNVTCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGHIAVUTAICHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAICHEDOMIENGIAMID = c.String(maxLength: 36, unicode: false),
                        SOTIENMIENGIAM = c.Decimal(precision: 18, scale: 2),
                        SOQUYETDINHMIENGIAM = c.String(maxLength: 15, unicode: false),
                        NGAYRAQUYETDINHMIENGIAM = c.DateTime(),
                        COQUANRAQUYETDINHMIENGIAM = c.String(maxLength: 150, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        LOAIDTMIENGIAMID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAINGHIAVUTAICHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TYLEMIENGIAM = c.Decimal(precision: 18, scale: 2),
                        THOIGIANMIENGIAM = c.Decimal(precision: 18, scale: 2),
                        NGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.MIENGIAMNVTCID)
                .ForeignKey("MPLIS21.DC_NGHIAVUTAICHINH", t => t.NGHIAVUTAICHINHID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_NGUOI", t => t.NGUOIID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DM_LOAIDTMIENGIAM", t => t.LOAIDTMIENGIAMID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DM_LOAINGHIAVUTAICHINH", t => t.LOAINGHIAVUTAICHINHID, cascadeDelete: true)
                .Index(t => t.NGHIAVUTAICHINHID)
                .Index(t => t.NGUOIID)
                .Index(t => t.LOAIDTMIENGIAMID)
                .Index(t => t.LOAINGHIAVUTAICHINHID);
            
            CreateTable(
                "MPLIS21.DC_NGHIAVUTAICHINH",
                c => new
                    {
                        NGHIAVUTAICHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        QUYENSUDUNGDATID = c.String(maxLength: 36, unicode: false),
                        QUYENSOHUUTAISANID = c.String(maxLength: 36, unicode: false),
                        LOAINGHIAVUTAICHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TONGSOTIEN = c.Decimal(precision: 18, scale: 2),
                        TONGSOTIENMIENGIAM = c.Decimal(precision: 18, scale: 2),
                        TONGSOTIENNO = c.Decimal(precision: 18, scale: 2),
                        NGAYBATDAU = c.DateTime(),
                        HOANTHANH = c.String(maxLength: 1, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        SOPHIEUCHUYEN = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.NGHIAVUTAICHINHID)
                .ForeignKey("MPLIS21.DC_LOAINGHIAVUTAICHINH", t => t.LOAINGHIAVUTAICHINHID, cascadeDelete: true)
                .Index(t => t.LOAINGHIAVUTAICHINHID);
            
            CreateTable(
                "MPLIS21.DC_GTKEMTHEO",
                c => new
                    {
                        GTKEMTHEOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENGIAYTO = c.String(maxLength: 200, unicode: false),
                        FILEDINHKEM = c.String(maxLength: 2000, unicode: false),
                        TENFILE = c.String(maxLength: 200, unicode: false),
                        NGHIAVUTAICHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.GTKEMTHEOID)
                .ForeignKey("MPLIS21.DC_NGHIAVUTAICHINH", t => t.NGHIAVUTAICHINHID, cascadeDelete: true)
                .Index(t => t.NGHIAVUTAICHINHID);
            
            CreateTable(
                "MPLIS21.DC_KHOANDUOCTRU",
                c => new
                    {
                        KHOANDUOCTRUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENKHOANDUOCTRU = c.String(maxLength: 200, unicode: false),
                        SOTIEN = c.Decimal(precision: 18, scale: 2),
                        GHICHU = c.String(maxLength: 200, unicode: false),
                        NGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGHIAVUTAICHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.KHOANDUOCTRUID)
                .ForeignKey("MPLIS21.DC_NGHIAVUTAICHINH", t => t.NGHIAVUTAICHINHID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_NGUOI", t => t.NGUOIID, cascadeDelete: true)
                .Index(t => t.NGHIAVUTAICHINHID)
                .Index(t => t.NGUOIID);
            
            CreateTable(
                "MPLIS21.DC_LOAINGHIAVUTAICHINH",
                c => new
                    {
                        LOAINGHIAVUTAICHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENLOAINGHIAVUTAICHINH = c.String(maxLength: 200, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.LOAINGHIAVUTAICHINHID);
            
            CreateTable(
                "MPLIS21.DC_NONVTC",
                c => new
                    {
                        NONVTCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DIENTICH = c.Decimal(precision: 18, scale: 2),
                        NGAYGHINO = c.DateTime(),
                        NOIDUNG = c.String(maxLength: 2000, unicode: false),
                        NGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAINGHIAVUTAICHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SOTIENNO = c.Decimal(precision: 18, scale: 2),
                        NGHIAVUTAICHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DATRA = c.String(maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.NONVTCID)
                .ForeignKey("MPLIS21.DC_NGHIAVUTAICHINH", t => t.NGHIAVUTAICHINHID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_NGUOI", t => t.NGUOIID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DM_LOAINGHIAVUTAICHINH", t => t.LOAINGHIAVUTAICHINHID, cascadeDelete: true)
                .Index(t => t.NGHIAVUTAICHINHID)
                .Index(t => t.NGUOIID)
                .Index(t => t.LOAINGHIAVUTAICHINHID);
            
            CreateTable(
                "MPLIS21.DM_LOAINGHIAVUTAICHINH",
                c => new
                    {
                        LOAINGHIAVUTAICHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENNGHIAVUTAICHINH = c.String(maxLength: 200, unicode: false),
                        GHICHU = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.LOAINGHIAVUTAICHINHID);
            
            CreateTable(
                "MPLIS21.DC_NGUOI_DIACHI",
                c => new
                    {
                        NGUOIDIACHIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DIACHIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPPHATID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.NGUOIDIACHIID)
                .ForeignKey("MPLIS21.DC_DIACHI", t => t.DIACHIID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_NGUOI", t => t.NGUOIID, cascadeDelete: true)
                .Index(t => t.DIACHIID)
                .Index(t => t.NGUOIID);
            
            CreateTable(
                "MPLIS21.DC_DIACHI",
                c => new
                    {
                        DIACHIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MAXA = c.String(maxLength: 5, unicode: false),
                        DIACHICHITIET = c.String(maxLength: 150, unicode: false),
                        TENDUONGPHO = c.String(maxLength: 250, unicode: false),
                        TENTODANPHO = c.String(maxLength: 250, unicode: false),
                        TENXA = c.String(maxLength: 50, unicode: false),
                        TENHUYEN = c.String(maxLength: 50, unicode: false),
                        TENTINH = c.String(maxLength: 50, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        DIACHIDAYDU = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.DIACHIID);
            
            CreateTable(
                "MPLIS21.DC_TAISAN_DIACHI",
                c => new
                    {
                        TAISANDIACHIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DIACHIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        TAISANGANLIENVOIDATID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.TAISANDIACHIID)
                .ForeignKey("MPLIS21.DC_DIACHI", t => t.DIACHIID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_TAISANGANLIENVOIDAT", t => t.TAISANGANLIENVOIDATID, cascadeDelete: true)
                .Index(t => t.DIACHIID)
                .Index(t => t.TAISANGANLIENVOIDATID);
            
            CreateTable(
                "MPLIS21.DC_TAISANGANLIENVOIDAT",
                c => new
                    {
                        TAISANGANLIENVOIDATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TAISANID = c.String(maxLength: 36, unicode: false),
                        LOAITAISAN = c.String(maxLength: 36, unicode: false),
                        TENTAISAN = c.String(maxLength: 150, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        TRANGTHAI = c.String(maxLength: 1, unicode: false),
                        TAISANGOCID = c.String(maxLength: 36, unicode: false),
                        SOLANCAPQUYEN = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.TAISANGANLIENVOIDATID);
            
            CreateTable(
                "MPLIS21.DC_QUYENSOHUUTAISAN",
                c => new
                    {
                        QUYENSOHUUTAISANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TAISANGANLIENVOIDATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        GIAYCHUNGNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        DONDANGKYID = c.String(maxLength: 36, unicode: false),
                        TRANGTHAIPL = c.String(maxLength: 1, unicode: false),
                        NGAYDANGKYTC = c.DateTime(),
                        BDTHECHAPID = c.String(nullable: false, maxLength: 36, unicode: false),
                        QUYENSHTSGOCID = c.String(maxLength: 36, unicode: false),
                        TILESOHUU = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.QUYENSOHUUTAISANID)
                .ForeignKey("MPLIS21.DC_BD_THECHAP", t => t.BDTHECHAPID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_GIAYCHUNGNHAN", t => t.GIAYCHUNGNHANID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_NGUOI", t => t.NGUOIID)
                .ForeignKey("MPLIS21.DC_TAISANGANLIENVOIDAT", t => t.TAISANGANLIENVOIDATID, cascadeDelete: true)
                .Index(t => t.BDTHECHAPID)
                .Index(t => t.GIAYCHUNGNHANID)
                .Index(t => t.NGUOIID)
                .Index(t => t.TAISANGANLIENVOIDATID);
            
            CreateTable(
                "MPLIS21.DC_BD_THECHAP",
                c => new
                    {
                        BDTHECHAPID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGAYNHANHS = c.DateTime(),
                        NGAYTHECHAP = c.DateTime(),
                        QUYENSO = c.String(),
                        SOTHUTU = c.Decimal(precision: 18, scale: 2),
                        SODANGKY = c.Decimal(precision: 18, scale: 2),
                        NGAYBATDAU = c.DateTime(),
                        NGAYKETTHUC = c.DateTime(),
                        BIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.BDTHECHAPID)
                .ForeignKey("MPLIS21.DC_BIENDONG", t => t.BIENDONGID, cascadeDelete: true)
                .Index(t => t.BIENDONGID);
            
            CreateTable(
                "MPLIS21.DC_QUYENQUANLYDAT",
                c => new
                    {
                        QUYENQUANLYDATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUADATID = c.String(maxLength: 36, unicode: false),
                        MUCDICHSUDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        DONDANGKYID = c.String(maxLength: 36, unicode: false),
                        GIAYCHUNGNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        BDTHECHAPID = c.String(nullable: false, maxLength: 36, unicode: false),
                        QUYENQLDATGOCID = c.String(maxLength: 36, unicode: false),
                        NGAYDANGKYTC = c.DateTime(),
                        TRANGTHAIPL = c.String(maxLength: 36, unicode: false),
                        TILESOHUU = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.QUYENQUANLYDATID)
                .ForeignKey("MPLIS21.DC_BD_THECHAP", t => t.BDTHECHAPID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_GIAYCHUNGNHAN", t => t.GIAYCHUNGNHANID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_MUCDICHSUDUNGDAT", t => t.MUCDICHSUDUNGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_NGUOI", t => t.NGUOIID)
                .Index(t => t.BDTHECHAPID)
                .Index(t => t.GIAYCHUNGNHANID)
                .Index(t => t.MUCDICHSUDUNGID)
                .Index(t => t.NGUOIID);
            
            CreateTable(
                "MPLIS21.DC_MUCDICHSUDUNGDAT",
                c => new
                    {
                        MUCDICHSUDUNGDATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUADATID = c.String(maxLength: 36, unicode: false),
                        SOTHUTUMDSD = c.Decimal(precision: 18, scale: 2),
                        MUCDICHSUDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MUCDICHSUDUNGQHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DIENTICH = c.Decimal(precision: 18, scale: 2),
                        SUDUNGCHUNG = c.Decimal(precision: 18, scale: 2),
                        THOIHANSUDUNG = c.String(maxLength: 250, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        LAMUCDICHCHINH = c.Boolean(),
                        MDSDGOCID = c.String(maxLength: 36, unicode: false),
                        DACAPQUYEN = c.String(maxLength: 1, unicode: false),
                        LOAITHOIHANSUDUNG = c.String(maxLength: 1, unicode: false),
                        TUNGAY = c.DateTime(),
                        DENNGAY = c.DateTime(),
                        DIENTICHPHAINOPTIEN = c.Decimal(precision: 18, scale: 2),
                        DIENTICHKHONGPHAINOPTIEN = c.Decimal(precision: 18, scale: 2),
                        SOLANCAPQUYEN = c.Decimal(precision: 18, scale: 2),
                        NGUONGOCSDTH = c.String(maxLength: 4000, unicode: false),
                        HINHTHUCSUDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.MUCDICHSUDUNGDATID)
                .ForeignKey("MPLIS21.DM_HINHTHUCSUDUNGDAT", t => t.HINHTHUCSUDUNGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DM_MUCDICHSUDUNG", t => t.MUCDICHSUDUNGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DM_MUCDICHSUDUNGQH", t => t.MUCDICHSUDUNGQHID, cascadeDelete: true)
                .Index(t => t.HINHTHUCSUDUNGID)
                .Index(t => t.MUCDICHSUDUNGID)
                .Index(t => t.MUCDICHSUDUNGQHID);
            
            CreateTable(
                "MPLIS21.DC_NGUONGOCSUDUNG",
                c => new
                    {
                        NGUONGOCSUDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MUCDICHSUDUNGDATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CHITIET = c.String(maxLength: 255, unicode: false),
                        LOAINGUONGOCSUDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.NGUONGOCSUDUNGID)
                .ForeignKey("MPLIS21.DC_MUCDICHSUDUNGDAT", t => t.MUCDICHSUDUNGDATID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DM_LOAINGUONGOCSUDUNG", t => t.LOAINGUONGOCSUDUNGID, cascadeDelete: true)
                .Index(t => t.MUCDICHSUDUNGDATID)
                .Index(t => t.LOAINGUONGOCSUDUNGID);
            
            CreateTable(
                "MPLIS21.DM_LOAINGUONGOCSUDUNG",
                c => new
                    {
                        LOAINGUONGOCSUDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MANGUONGOCSUDUNG = c.String(maxLength: 50, unicode: false),
                        TENNGUONGOCSUDUNG = c.String(maxLength: 400, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 10, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.LOAINGUONGOCSUDUNGID);
            
            CreateTable(
                "MPLIS21.DC_QUYENSUDUNGDAT",
                c => new
                    {
                        QUYENSUDUNGDATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUADATID = c.String(maxLength: 36, unicode: false),
                        MUCDICHSUDUNGDATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        GIAYCHUNGNHANID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        DONDANGKYID = c.String(maxLength: 36, unicode: false),
                        LAQUYENQUANLY = c.String(maxLength: 1, unicode: false),
                        TRANGTHAIPL = c.String(maxLength: 1, unicode: false),
                        NGAYDANGKYTC = c.DateTime(),
                        BDTHECHAPID = c.String(nullable: false, maxLength: 36, unicode: false),
                        QUYENSDDGOCID = c.String(maxLength: 36, unicode: false),
                        TILESOHUU = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.QUYENSUDUNGDATID)
                .ForeignKey("MPLIS21.DC_BD_THECHAP", t => t.BDTHECHAPID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_MUCDICHSUDUNGDAT", t => t.MUCDICHSUDUNGDATID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_NGUOI", t => t.NGUOIID, cascadeDelete: true)
                .Index(t => t.BDTHECHAPID)
                .Index(t => t.MUCDICHSUDUNGDATID)
                .Index(t => t.NGUOIID);
            
            CreateTable(
                "MPLIS21.DC_VITRITHUADAT",
                c => new
                    {
                        VITRIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DUONG = c.String(maxLength: 200, unicode: false),
                        DOANDUONG = c.String(maxLength: 200, unicode: false),
                        KHUVUC = c.String(maxLength: 200, unicode: false),
                        VITRI = c.Decimal(precision: 18, scale: 2),
                        CHIEUSAU = c.Decimal(precision: 18, scale: 2),
                        CHIEURONGNGOHEM = c.Decimal(precision: 18, scale: 2),
                        MUCDICHSUDUNGDATID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.VITRIID)
                .ForeignKey("MPLIS21.DC_MUCDICHSUDUNGDAT", t => t.MUCDICHSUDUNGDATID, cascadeDelete: true)
                .Index(t => t.MUCDICHSUDUNGDATID);
            
            CreateTable(
                "MPLIS21.DM_HINHTHUCSUDUNGDAT",
                c => new
                    {
                        HINHTHUCSUDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENHINHTHUCSUDUNG = c.String(maxLength: 200, unicode: false),
                        GHICHU = c.String(maxLength: 200, unicode: false),
                        STT = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.HINHTHUCSUDUNGID);
            
            CreateTable(
                "MPLIS21.DC_BD_CHUYENHTSDD",
                c => new
                    {
                        BDCHUYENHTSDDID = c.String(nullable: false, maxLength: 36, unicode: false),
                        HINHTHUCSUDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        BIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LAHTSDDTRUOCKHICHUYEN = c.String(maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.BDCHUYENHTSDDID)
                .ForeignKey("MPLIS21.DC_BIENDONG", t => t.BIENDONGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DM_HINHTHUCSUDUNGDAT", t => t.HINHTHUCSUDUNGID, cascadeDelete: true)
                .Index(t => t.BIENDONGID)
                .Index(t => t.HINHTHUCSUDUNGID);
            
            CreateTable(
                "MPLIS21.DM_MUCDICHSUDUNG",
                c => new
                    {
                        MUCDICHSUDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KHOACHAID = c.String(maxLength: 36, unicode: false),
                        MAMUCDICHSUDUNG = c.String(maxLength: 4, unicode: false),
                        TENMUCDICHSUDUNG = c.String(maxLength: 120, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 10, unicode: false),
                        THOIHANMACDINH = c.Byte(),
                        CANCUPHAPLY = c.String(maxLength: 100, unicode: false),
                        PHIENBAN = c.String(maxLength: 20, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        CHITIET = c.Boolean(),
                    })
                .PrimaryKey(t => t.MUCDICHSUDUNGID);
            
            CreateTable(
                "MPLIS21.DC_BD_CHUYENMDSDD",
                c => new
                    {
                        BDCHUYENMDSDID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MUCDICHSUDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        BIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LAMDSDTRUOCKHICHUYEN = c.String(maxLength: 1, unicode: false),
                        DIENTICHCHUYENMDSDD = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BDCHUYENMDSDID)
                .ForeignKey("MPLIS21.DC_BIENDONG", t => t.BIENDONGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DM_MUCDICHSUDUNG", t => t.MUCDICHSUDUNGID, cascadeDelete: true)
                .Index(t => t.BIENDONGID)
                .Index(t => t.MUCDICHSUDUNGID);
            
            CreateTable(
                "MPLIS21.DC_THUEDAT",
                c => new
                    {
                        THUEDATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CTNDIENTICHXAYDUNG = c.Decimal(precision: 18, scale: 2),
                        CTNGIADATDIENTICHXD = c.Decimal(precision: 18, scale: 2),
                        DATCOMNDIENTICHMATDAT = c.Decimal(precision: 18, scale: 2),
                        DATCOMNDIENTICHMATNUOC = c.Decimal(precision: 18, scale: 2),
                        DATCOMNGIADAT = c.Decimal(precision: 18, scale: 2),
                        MNVITRI = c.String(maxLength: 200, unicode: false),
                        MNDIENTICHTHUE = c.Decimal(precision: 18, scale: 2),
                        BIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MUCDICHSUDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THOIHANTHUE = c.Decimal(precision: 18, scale: 2),
                        TUNGAY = c.DateTime(),
                        DENNGAY = c.DateTime(),
                        HINHTHUCTHUEMN = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.THUEDATID)
                .ForeignKey("MPLIS21.DC_BIENDONG", t => t.BIENDONGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DM_MUCDICHSUDUNG", t => t.MUCDICHSUDUNGID, cascadeDelete: true)
                .Index(t => t.BIENDONGID)
                .Index(t => t.MUCDICHSUDUNGID);
            
            CreateTable(
                "MPLIS21.DM_MUCDICHSUDUNGQH",
                c => new
                    {
                        MUCDICHSUDUNGQHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KHOACHAID = c.String(maxLength: 36, unicode: false),
                        MAMUCDICHSUDUNGQH = c.String(maxLength: 4, unicode: false),
                        TENMUCDICHSUDUNGQH = c.String(maxLength: 120, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 10, unicode: false),
                        CANCUPHAPLY = c.String(maxLength: 100, unicode: false),
                        PHIENBAN = c.String(maxLength: 20, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        CHITIET = c.Boolean(),
                    })
                .PrimaryKey(t => t.MUCDICHSUDUNGQHID);
            
            CreateTable(
                "MPLIS21.DC_THUATAISAN",
                c => new
                    {
                        THUATAISANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TAISANGANLIENVOIDATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.THUATAISANID)
                .ForeignKey("MPLIS21.DC_TAISANGANLIENVOIDAT", t => t.TAISANGANLIENVOIDATID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_THUADAT", t => t.THUADATID, cascadeDelete: true)
                .Index(t => t.TAISANGANLIENVOIDATID)
                .Index(t => t.THUADATID);
            
            CreateTable(
                "MPLIS21.DC_THUADAT",
                c => new
                    {
                        THUADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KVHCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SOHIEUTOBANDO = c.Decimal(precision: 18, scale: 2),
                        SOTHUTUTHUA = c.Decimal(precision: 18, scale: 2),
                        SOHIEUTOBANDOCU = c.String(maxLength: 50, unicode: false),
                        SOTHUTUTHUACU = c.String(maxLength: 100, unicode: false),
                        DIENTICH = c.Decimal(precision: 18, scale: 2),
                        DIENTICHPHAPLY = c.Decimal(precision: 18, scale: 2),
                        TAILIEUDODACID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LADOITUONGCHIEMDAT = c.Decimal(precision: 18, scale: 2),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        DIACHITHUADAT = c.String(maxLength: 250, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                        DANGTRANHCHAP = c.String(maxLength: 1, unicode: false),
                        GEOMETRY = c.String(),
                        TRANGTHAI = c.String(maxLength: 1, unicode: false),
                        THUAGOCID = c.String(maxLength: 36, unicode: false),
                        LOAITHUADAT = c.String(maxLength: 1, unicode: false),
                        HSKTFILEPATH = c.String(maxLength: 500, unicode: false),
                        GTQUYENSDD = c.String(maxLength: 2000, unicode: false),
                        DOANDUONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KHUVUCID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.THUADATID)
                .ForeignKey("MPLIS21.DC_DOANDUONG", t => t.DOANDUONGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_KHUVUC", t => t.KHUVUCID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_TAILIEUDODAC", t => t.TAILIEUDODACID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HC_DMKVHC", t => t.KVHCID, cascadeDelete: true)
                .Index(t => t.DOANDUONGID)
                .Index(t => t.KHUVUCID)
                .Index(t => t.TAILIEUDODACID)
                .Index(t => t.KVHCID);
            
            CreateTable(
                "MPLIS21.DC_BD_THUA",
                c => new
                    {
                        BDTHUAID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAITHUABD = c.String(maxLength: 1, unicode: false),
                        LADULIEULS = c.String(maxLength: 1, unicode: false),
                        BIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.BDTHUAID)
                .ForeignKey("MPLIS21.DC_BIENDONG", t => t.BIENDONGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_THUADAT", t => t.THUADATID, cascadeDelete: true)
                .Index(t => t.BIENDONGID)
                .Index(t => t.THUADATID);
            
            CreateTable(
                "MPLIS21.DC_BD_THUA_THUA",
                c => new
                    {
                        BDTHUATHUAID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUACHAID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.BDTHUATHUAID)
                .ForeignKey("MPLIS21.DC_THUADAT", t => t.THUADATID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_THUADAT", t => t.THUACHAID)
                .Index(t => t.THUADATID)
                .Index(t => t.THUACHAID);
            
            CreateTable(
                "MPLIS21.DC_DOANDUONG",
                c => new
                    {
                        DOANDUONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENDUONGID = c.String(maxLength: 36, unicode: false),
                        TINHID = c.String(maxLength: 36, unicode: false),
                        HUYENID = c.String(maxLength: 36, unicode: false),
                        MADOANDUONG = c.String(maxLength: 20, unicode: false),
                        MADOANDUONG_THUE = c.String(maxLength: 20, unicode: false),
                        TENDOANDUONG = c.String(maxLength: 500, unicode: false),
                        NAMBATDAU = c.Decimal(precision: 18, scale: 2),
                        NAMKETTHUC = c.Decimal(precision: 18, scale: 2),
                        TRANGTHAI = c.Boolean(),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.DOANDUONGID);
            
            CreateTable(
                "MPLIS21.DC_KHUVUC",
                c => new
                    {
                        KHUVUCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENKHUVUC = c.String(maxLength: 200, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                        KVHCID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.KHUVUCID)
                .ForeignKey("MPLIS21.HC_DMKVHC", t => t.KVHCID)
                .Index(t => t.KVHCID);
            
            CreateTable(
                "MPLIS21.HC_DMKVHC",
                c => new
                    {
                        KVHCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        HUYENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MAXA = c.String(maxLength: 5, unicode: false),
                        TENKVHC = c.String(maxLength: 100, unicode: false),
                        PHANLOAI = c.String(maxLength: 20, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 5, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        MAKVHC = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.KVHCID)
                .ForeignKey("MPLIS21.HC_HUYEN", t => t.HUYENID, cascadeDelete: true)
                .Index(t => t.HUYENID);
            
            CreateTable(
                "MPLIS21.DC_TAILIEUDODAC",
                c => new
                    {
                        TAILIEUDODACID = c.String(nullable: false, maxLength: 36, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                        LOAIBANDODIACHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KVHCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DONVIDODAC = c.String(maxLength: 150, unicode: false),
                        PHUONGPHAPDO = c.String(maxLength: 150, unicode: false),
                        MUCDOCHINHXAC = c.String(maxLength: 50, unicode: false),
                        TYLEDODAC = c.String(maxLength: 20, unicode: false),
                        NGAYHOANTHANH = c.DateTime(),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        TENTAILIEU = c.String(maxLength: 100, unicode: false),
                        GHICHU = c.String(maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.TAILIEUDODACID)
                .ForeignKey("MPLIS21.DM_LOAIBANDODIACHINH", t => t.LOAIBANDODIACHINHID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HC_DMKVHC", t => t.KVHCID)
                .Index(t => t.LOAIBANDODIACHINHID)
                .Index(t => t.KVHCID);
            
            CreateTable(
                "MPLIS21.DC_THUADAT_TAILIEUDODAC",
                c => new
                    {
                        THUADATTAILIEUDODACID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TAILIEUDODACID = c.String(nullable: false, maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.THUADATTAILIEUDODACID)
                .ForeignKey("MPLIS21.DC_TAILIEUDODAC", t => t.TAILIEUDODACID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_THUADAT", t => t.THUADATID)
                .Index(t => t.TAILIEUDODACID)
                .Index(t => t.THUADATID);
            
            CreateTable(
                "MPLIS21.DM_LOAIBANDODIACHINH",
                c => new
                    {
                        LOAIBANDODIACHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIBANDODIACHINH = c.String(maxLength: 5, unicode: false),
                        TENLOAIBANDODIACHINH = c.String(maxLength: 60, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIBANDODIACHINHID);
            
            CreateTable(
                "MPLIS21.HC_HUYEN",
                c => new
                    {
                        HUYENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MAHUYEN = c.String(maxLength: 3, unicode: false),
                        TENHUYEN = c.String(maxLength: 80, unicode: false),
                        PHANLOAI = c.String(maxLength: 20, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 3, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        MAKVHC = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.HUYENID)
                .ForeignKey("MPLIS21.HC_TINH", t => t.TINHID, cascadeDelete: true)
                .Index(t => t.TINHID);
            
            CreateTable(
                "MPLIS21.HC_TINH",
                c => new
                    {
                        TINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 2, unicode: false),
                        TENTINH = c.String(maxLength: 60, unicode: false),
                        PHANLOAI = c.String(maxLength: 20, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 2, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        MAKVHC = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.TINHID);
            
            CreateTable(
                "MPLIS21.HC_TINHTHAMSO",
                c => new
                    {
                        TINHTHAMSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUADATSERVICELINK = c.String(maxLength: 250, unicode: false),
                        THUADATLAYERINDEX = c.Decimal(precision: 18, scale: 2),
                        BASEMAPSERVICELINK = c.String(maxLength: 250, unicode: false),
                        QUYHOACHCAPTINHMAPSERVICELINK = c.String(maxLength: 250, unicode: false),
                        KHOANHDATSERVICELINK = c.String(maxLength: 250, unicode: false),
                        HIENTRANGSERVICELINK = c.String(maxLength: 250, unicode: false),
                        GIADATSERVICELINK = c.String(maxLength: 250, unicode: false),
                        VETINHSERVICELINK = c.String(maxLength: 250, unicode: false),
                        GIADATGRSERVICELINK = c.String(maxLength: 250, unicode: false),
                        MDSDSERVICELINK = c.String(maxLength: 250, unicode: false),
                        CAPGCNSERVICELINK = c.String(maxLength: 250, unicode: false),
                        TINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KINHTUYENTRUC = c.Decimal(precision: 18, scale: 2),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        uId = c.String(maxLength: 36, unicode: false),
                        QUYHOACHCAPTINHLAYERINDEX = c.Decimal(precision: 18, scale: 2),
                        KHOANHDATLAYERINDEX = c.Decimal(precision: 18, scale: 2),
                        HIENTRANGLAYERINDEX = c.Decimal(precision: 18, scale: 2),
                        GIADATLAYERINDEX = c.Decimal(precision: 18, scale: 2),
                        MDSDLAYERINDEX = c.Decimal(precision: 18, scale: 2),
                        CAPGCNLAYERINDEX = c.Decimal(precision: 18, scale: 2),
                        GIADATGRLAYERINDEX = c.Decimal(precision: 18, scale: 2),
                        KVHCSERVICELINK = c.String(maxLength: 250, unicode: false),
                        KVHCLAYERTINHINDEX = c.Decimal(precision: 18, scale: 2),
                        LOADEXPORTDGN = c.String(maxLength: 250, unicode: false),
                        LOADEXPORTGML = c.String(maxLength: 250, unicode: false),
                        GETDATAEDITDESKTOP = c.String(maxLength: 250, unicode: false),
                        THUADATMAPSERVERLINK = c.String(maxLength: 250, unicode: false),
                        THUADATMAPSERVERINDEX = c.Decimal(precision: 18, scale: 2),
                        KVHCLAYERHUYENINDEX = c.Decimal(precision: 18, scale: 2),
                        KVHCLAYERXAINDEX = c.Decimal(precision: 18, scale: 2),
                        LOADEXPORTSHAPEFILE = c.String(maxLength: 250, unicode: false),
                        GEOMETRYSERVER = c.String(maxLength: 250, unicode: false),
                        QUYHOACHCAPHUYENLAYERINDEX = c.Decimal(precision: 18, scale: 2),
                        QUYHOACHCAPHUYENMAPSERVICELINK = c.String(maxLength: 250, unicode: false),
                        QUYHOACHCAPHUYENFEATURESERVER = c.String(maxLength: 250, unicode: false),
                        QUYHOACHCAPTINHFEATURESERVER = c.String(maxLength: 250, unicode: false),
                        THUADATSERVICELINKLOCAL = c.String(maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.TINHTHAMSOID)
                .ForeignKey("MPLIS21.HC_TINH", t => t.TINHID, cascadeDelete: true)
                .Index(t => t.TINHID);
            
            CreateTable(
                "MPLIS21.HS_HOSO",
                c => new
                    {
                        HOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KVHCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                        MAHOSO = c.String(maxLength: 20, unicode: false),
                        MAHOSO_ST = c.String(maxLength: 6, unicode: false),
                        MAHOSO_MB = c.String(maxLength: 2, unicode: false),
                        MAHOSO_TB = c.String(maxLength: 3, unicode: false),
                        MAHOSO_TAM = c.String(maxLength: 20, unicode: false),
                        TENHOSO = c.String(maxLength: 100, unicode: false),
                        SOTODAIDIEN = c.String(maxLength: 15, unicode: false),
                        SOTHUADAIDIEN = c.String(maxLength: 15, unicode: false),
                        NGAYHOSO = c.DateTime(),
                        PHONG = c.String(maxLength: 36, unicode: false),
                        KE = c.String(maxLength: 36, unicode: false),
                        NGAN = c.String(maxLength: 36, unicode: false),
                        HOP = c.String(maxLength: 36, unicode: false),
                        TENHOP = c.String(maxLength: 100, unicode: false),
                        GHICHU = c.String(maxLength: 255, unicode: false),
                        DALIENKETCSDL_KG = c.Boolean(),
                        DALIENKETCSDL_TT = c.Boolean(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        OID = c.String(maxLength: 36, unicode: false),
                        HOSOTIEPNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.HOSOID)
                .ForeignKey("MPLIS21.HC_DMKVHC", t => t.KVHCID, cascadeDelete: true)
                .ForeignKey("MPLIS21.QT_HOSOTIEPNHAN", t => t.HOSOTIEPNHANID, cascadeDelete: true)
                .Index(t => t.KVHCID)
                .Index(t => t.HOSOTIEPNHANID);
            
            CreateTable(
                "MPLIS21.HS_LICHSU",
                c => new
                    {
                        LICHSUHOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KVHCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                        HOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        HOSOTRUOCID = c.String(maxLength: 36, unicode: false),
                        HOSOSAUID = c.String(maxLength: 36, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        OID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LICHSUHOSOID)
                .ForeignKey("MPLIS21.HC_DMKVHC", t => t.KVHCID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HS_HOSO", t => t.HOSOID)
                .Index(t => t.KVHCID)
                .Index(t => t.HOSOID);
            
            CreateTable(
                "MPLIS21.HS_LIENKETTHUADAT",
                c => new
                    {
                        LIENKETTHUADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KVHCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TOTHUAID = c.String(maxLength: 36, unicode: false),
                        HOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SOTO = c.String(maxLength: 25, unicode: false),
                        SOTHUA = c.String(maxLength: 25, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THUAID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LIENKETTHUADATID)
                .ForeignKey("MPLIS21.HC_DMKVHC", t => t.KVHCID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HS_HOSO", t => t.HOSOID)
                .Index(t => t.KVHCID)
                .Index(t => t.HOSOID);
            
            CreateTable(
                "MPLIS21.HS_TC_CHU",
                c => new
                    {
                        TCCHUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENCHU = c.String(maxLength: 255, unicode: false),
                        DIACHI = c.String(maxLength: 255, unicode: false),
                        CHUID = c.String(maxLength: 36, unicode: false),
                        SOGIAYTOXM = c.String(maxLength: 50, unicode: false),
                        HOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.TCCHUID)
                .ForeignKey("MPLIS21.HS_HOSO", t => t.HOSOID, cascadeDelete: true)
                .Index(t => t.HOSOID);
            
            CreateTable(
                "MPLIS21.HS_TC_GCN",
                c => new
                    {
                        TCGCNID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SOPHATHANH = c.String(maxLength: 20, unicode: false),
                        SOVAOSO = c.String(maxLength: 10, unicode: false),
                        MAVACH = c.String(maxLength: 25, unicode: false),
                        GCNID = c.String(maxLength: 40, unicode: false),
                        MAKVHC = c.String(maxLength: 10, unicode: false),
                        HOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.TCGCNID)
                .ForeignKey("MPLIS21.HS_HOSO", t => t.HOSOID, cascadeDelete: true)
                .Index(t => t.HOSOID);
            
            CreateTable(
                "MPLIS21.HS_THANHPHANHOSO",
                c => new
                    {
                        THANHPHANHOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        HOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        GIAYTOKEMTHEOHSID = c.String(maxLength: 36, unicode: false),
                        TENTEPDULIEU = c.String(maxLength: 100, unicode: false),
                        KICHTHUOC = c.Decimal(precision: 18, scale: 2),
                        DUONGDAN = c.String(maxLength: 2000, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        OID = c.String(maxLength: 36, unicode: false),
                        SOBIENNHAN = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.THANHPHANHOSOID)
                .ForeignKey("MPLIS21.HS_HOSO", t => t.HOSOID, cascadeDelete: true)
                .Index(t => t.HOSOID);
            
            CreateTable(
                "MPLIS21.QT_HOSOTIEPNHAN",
                c => new
                    {
                        HOSOTIEPNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TOCHUCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUTUCHANHCHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CAP = c.Byte(),
                        DONVIHANHCHINHID = c.String(maxLength: 36, unicode: false),
                        SOBIENNHAN = c.String(maxLength: 30, unicode: false),
                        QUYENTIEPNHAN = c.String(maxLength: 150, unicode: false),
                        CANBOTIEPNHANID = c.String(maxLength: 36, unicode: false),
                        NGAYTIEPNHANHOSO = c.DateTime(),
                        NGAYHENTRAHOSO = c.DateTime(),
                        NGUOINOPHOSO = c.String(maxLength: 150, unicode: false),
                        VAITRONGUOINOPHOSO = c.Byte(),
                        MOTATOMTAT = c.String(maxLength: 150, unicode: false),
                        SODIENTHOAI = c.String(maxLength: 255, unicode: false),
                        EMAIL = c.String(maxLength: 50, unicode: false),
                        SOGIAYTO = c.String(maxLength: 30, unicode: false),
                        PHUONGPHAPNHANTHONGBAO = c.Byte(),
                        DIACHINGUOINOPHS = c.String(maxLength: 255, unicode: false),
                        TENNGUOINHANKETQUA = c.String(maxLength: 150, unicode: false),
                        VAITRONGUOINHANKETQUA = c.Byte(),
                        DIACHINGUOINHANKETQUA = c.String(maxLength: 255, unicode: false),
                        NGAYTRAKETQUA = c.DateTime(),
                        GHICHUTRAKETQUA = c.String(maxLength: 255, unicode: false),
                        TINHTRANGHOSO = c.Byte(),
                        XULYTHEOQUYTRINH = c.String(maxLength: 1, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGAYHENLAYPHIEUCHUYENTHUE = c.DateTime(),
                        TENHOSO = c.String(maxLength: 255, unicode: false),
                        LOAIHOSO = c.Byte(),
                        TRANGTHAI = c.String(maxLength: 1, unicode: false),
                        DONVITHULYID = c.String(maxLength: 36, unicode: false),
                        HOSOXULYID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.HOSOTIEPNHANID)
                .ForeignKey("MPLIS21.HT_TOCHUC", t => t.TOCHUCID, cascadeDelete: true)
                .ForeignKey("MPLIS21.QT_THUTUCHANHCHINH", t => t.THUTUCHANHCHINHID, cascadeDelete: true)
                .Index(t => t.TOCHUCID)
                .Index(t => t.THUTUCHANHCHINHID);
            
            CreateTable(
                "MPLIS21.QT_FILEDINHKEMHOSO",
                c => new
                    {
                        FILEDINHKEMHOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        HOSOTIEPNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SODOQUYTRINHID = c.String(maxLength: 36, unicode: false),
                        BUOCQUYTRINHID = c.String(maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 150, unicode: false),
                        NGAYTAOFILE = c.DateTime(),
                        NGUOITAOFILEID = c.String(maxLength: 36, unicode: false),
                        LOAI = c.Byte(),
                        SOLUONG = c.Decimal(precision: 18, scale: 2),
                        GHICHU = c.String(maxLength: 255, unicode: false),
                        DUONGDANFILE = c.String(maxLength: 2000, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        LOAIBAOCAO = c.Decimal(precision: 18, scale: 2),
                        GIAYTOTHEOTTHCID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.FILEDINHKEMHOSOID)
                .ForeignKey("MPLIS21.QT_GIAYTOTHEOTTHC", t => t.GIAYTOTHEOTTHCID, cascadeDelete: true)
                .ForeignKey("MPLIS21.QT_HOSOTIEPNHAN", t => t.HOSOTIEPNHANID, cascadeDelete: true)
                .Index(t => t.GIAYTOTHEOTTHCID)
                .Index(t => t.HOSOTIEPNHANID);
            
            CreateTable(
                "MPLIS21.QT_GIAYTOTHEOTTHC",
                c => new
                    {
                        GIAYTOTHEOTTHCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUTUCHANHCHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENLOAIGIAYTO = c.String(maxLength: 2000, unicode: false),
                    })
                .PrimaryKey(t => t.GIAYTOTHEOTTHCID)
                .ForeignKey("MPLIS21.QT_THUTUCHANHCHINH", t => t.THUTUCHANHCHINHID)
                .Index(t => t.THUTUCHANHCHINHID);
            
            CreateTable(
                "MPLIS21.QT_THUTUCHANHCHINH",
                c => new
                    {
                        THUTUCHANHCHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TOCHUCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        BOTHUTUCHANHCHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENTHUTUCHANHCHINH = c.String(maxLength: 1000, unicode: false),
                        MOTA = c.String(maxLength: 2000, unicode: false),
                        CAP = c.Byte(),
                        DONVIHANHCHINHID = c.String(maxLength: 36, unicode: false),
                        THOIHANGIAIQUYETTOIDA = c.Decimal(precision: 18, scale: 2),
                        LEPHI = c.Decimal(precision: 18, scale: 2),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        KYHIEU = c.String(maxLength: 15, unicode: false),
                        DONVIID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.THUTUCHANHCHINHID)
                .ForeignKey("MPLIS21.DM_BOTHUTUCHANHCHINH", t => t.BOTHUTUCHANHCHINHID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HT_TOCHUC", t => t.TOCHUCID)
                .Index(t => t.BOTHUTUCHANHCHINHID)
                .Index(t => t.TOCHUCID);
            
            CreateTable(
                "MPLIS21.DM_BOTHUTUCHANHCHINH",
                c => new
                    {
                        BOTHUTUCHANHCHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENBOTHUTUCHANHCHINH = c.String(maxLength: 255, unicode: false),
                        CANCUPHAPLY = c.String(maxLength: 255, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 10, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.BOTHUTUCHANHCHINHID);
            
            CreateTable(
                "MPLIS21.QT_TTHC_QUYTRINH",
                c => new
                    {
                        TTHCQUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        QUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUTUCHANHCHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        ISACTIVE = c.String(maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.TTHCQUYTRINHID)
                .ForeignKey("MPLIS21.QT_QUYTRINH", t => t.QUYTRINHID, cascadeDelete: true)
                .ForeignKey("MPLIS21.QT_THUTUCHANHCHINH", t => t.THUTUCHANHCHINHID, cascadeDelete: true)
                .Index(t => t.QUYTRINHID)
                .Index(t => t.THUTUCHANHCHINHID);
            
            CreateTable(
                "MPLIS21.QT_QUYTRINH",
                c => new
                    {
                        QUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NHOMQUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CAPQUYTRINH = c.Byte(),
                        DONVIHANHCHINHID = c.String(maxLength: 36, unicode: false),
                        TENQUYTRINH = c.String(maxLength: 255, unicode: false),
                        THOIHANGIAIQUYETTOIDA = c.Decimal(precision: 18, scale: 2),
                        XML = c.String(),
                        SVG = c.String(),
                        PHAPLY = c.String(maxLength: 1000, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        KYHIEU = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.QUYTRINHID)
                .ForeignKey("MPLIS21.QT_NHOMQUYTRINH", t => t.NHOMQUYTRINHID, cascadeDelete: true)
                .Index(t => t.NHOMQUYTRINHID);
            
            CreateTable(
                "MPLIS21.QT_BUOCQUYTRINH",
                c => new
                    {
                        BUOCQUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MOTA = c.String(maxLength: 255),
                        BUOCQUYTRINHTRUOCIDS = c.String(maxLength: 2000, unicode: false),
                        RECTX = c.Decimal(precision: 18, scale: 2),
                        RECTY = c.Decimal(precision: 18, scale: 2),
                        RECTWIDTH = c.Decimal(precision: 18, scale: 2),
                        RECTHEIGHT = c.Decimal(precision: 18, scale: 2),
                        QUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAIBUOCQT = c.String(maxLength: 1),
                        DIEUKIEN = c.Decimal(precision: 18, scale: 2),
                        THOIGIANQUYDINH = c.Decimal(precision: 18, scale: 2),
                        BUOCQUYTRINHSAUIDS = c.String(maxLength: 2000, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        BPMNID = c.String(maxLength: 100, unicode: false),
                        TENBUOC = c.String(maxLength: 250),
                        UID = c.String(maxLength: 36, unicode: false),
                        STT = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BUOCQUYTRINHID)
                .ForeignKey("MPLIS21.QT_QUYTRINH", t => t.QUYTRINHID, cascadeDelete: true)
                .Index(t => t.QUYTRINHID);
            
            CreateTable(
                "MPLIS21.QT_BUOCQT_CAUHINH",
                c => new
                    {
                        BUOCQTCAUHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        BUOCQUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KVHCID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.BUOCQTCAUHINHID)
                .ForeignKey("MPLIS21.HC_DMKVHC", t => t.KVHCID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HT_NGUOIDUNG", t => t.NGUOIDUNGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.QT_BUOCQUYTRINH", t => t.BUOCQUYTRINHID, cascadeDelete: true)
                .Index(t => t.KVHCID)
                .Index(t => t.NGUOIDUNGID)
                .Index(t => t.BUOCQUYTRINHID);
            
            CreateTable(
                "MPLIS21.QT_CONGVIECTHEOBUOC",
                c => new
                    {
                        CONGVIECTHEOBUOCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        STT = c.Decimal(precision: 18, scale: 2),
                        TENCONGVIEC = c.String(maxLength: 200, unicode: false),
                        BUOCQUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.CONGVIECTHEOBUOCID)
                .ForeignKey("MPLIS21.QT_BUOCQUYTRINH", t => t.BUOCQUYTRINHID, cascadeDelete: true)
                .Index(t => t.BUOCQUYTRINHID);
            
            CreateTable(
                "MPLIS21.QT_CONGVIECTHUCHIEN",
                c => new
                    {
                        CONGVIECTHUCHIENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TRANGTHAI = c.String(maxLength: 1, unicode: false),
                        NGAYTHUCHIEN = c.DateTime(),
                        NGUOITHUCHIEN = c.String(maxLength: 100, unicode: false),
                        GHICHU = c.String(maxLength: 200, unicode: false),
                        CONGVIECTHEOBUOCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LUANCHUYENHOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.CONGVIECTHUCHIENID)
                .ForeignKey("MPLIS21.QT_CONGVIECTHEOBUOC", t => t.CONGVIECTHEOBUOCID, cascadeDelete: true)
                .ForeignKey("MPLIS21.QT_LUANCHUYEN_HOSO", t => t.LUANCHUYENHOSOID, cascadeDelete: true)
                .Index(t => t.CONGVIECTHEOBUOCID)
                .Index(t => t.LUANCHUYENHOSOID);
            
            CreateTable(
                "MPLIS21.QT_LUANCHUYEN_HOSO",
                c => new
                    {
                        LUANCHUYENHOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        HOSOTIEPNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        BUOCQUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        QUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        HOSOXULYID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGAYTIEPNHAN = c.DateTime(),
                        NGAYCHUYEN = c.DateTime(),
                        TRANGTHAI = c.String(maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.LUANCHUYENHOSOID)
                .ForeignKey("MPLIS21.HT_NGUOIDUNG", t => t.NGUOIDUNGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.QT_BUOCQUYTRINH", t => t.BUOCQUYTRINHID)
                .ForeignKey("MPLIS21.QT_HOSO_LANXULY", t => t.HOSOXULYID, cascadeDelete: true)
                .ForeignKey("MPLIS21.QT_HOSOTIEPNHAN", t => t.HOSOTIEPNHANID, cascadeDelete: true)
                .ForeignKey("MPLIS21.QT_QUYTRINH", t => t.QUYTRINHID)
                .Index(t => t.NGUOIDUNGID)
                .Index(t => t.BUOCQUYTRINHID)
                .Index(t => t.HOSOXULYID)
                .Index(t => t.HOSOTIEPNHANID)
                .Index(t => t.QUYTRINHID);
            
            CreateTable(
                "MPLIS21.QT_HOSO_LANXULY",
                c => new
                    {
                        HOSOXULYID = c.String(nullable: false, maxLength: 36, unicode: false),
                        HOSOTIEPNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        QUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGAYBATDAUXL = c.DateTime(),
                        NGAYKETTHUCXL = c.DateTime(),
                        TRANGTHAI = c.String(maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.HOSOXULYID)
                .ForeignKey("MPLIS21.QT_HOSOTIEPNHAN", t => t.HOSOTIEPNHANID)
                .ForeignKey("MPLIS21.QT_QUYTRINH", t => t.QUYTRINHID)
                .Index(t => t.HOSOTIEPNHANID)
                .Index(t => t.QUYTRINHID);
            
            CreateTable(
                "MPLIS21.QT_GHICHUXULY",
                c => new
                    {
                        GHICHUXULYID = c.String(nullable: false, maxLength: 36, unicode: false),
                        HOSOXULYID = c.String(nullable: false, maxLength: 36, unicode: false),
                        QUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        HOSOTIEPNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        BUOCQUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        GHICHUXL = c.String(maxLength: 36, unicode: false),
                        NGAYGHICHU = c.DateTime(),
                    })
                .PrimaryKey(t => t.GHICHUXULYID)
                .ForeignKey("MPLIS21.HT_NGUOIDUNG", t => t.NGUOIDUNGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.QT_BUOCQUYTRINH", t => t.BUOCQUYTRINHID, cascadeDelete: true)
                .ForeignKey("MPLIS21.QT_HOSO_LANXULY", t => t.HOSOXULYID, cascadeDelete: true)
                .ForeignKey("MPLIS21.QT_HOSOTIEPNHAN", t => t.HOSOTIEPNHANID, cascadeDelete: true)
                .ForeignKey("MPLIS21.QT_QUYTRINH", t => t.QUYTRINHID)
                .Index(t => t.NGUOIDUNGID)
                .Index(t => t.BUOCQUYTRINHID)
                .Index(t => t.HOSOXULYID)
                .Index(t => t.HOSOTIEPNHANID)
                .Index(t => t.QUYTRINHID);
            
            CreateTable(
                "MPLIS21.QT_NHOMQUYTRINH",
                c => new
                    {
                        NHOMQUYTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENNHOMQUYTRINH = c.String(maxLength: 255, unicode: false),
                        KYHIEUNHOM = c.String(maxLength: 20, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 5, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.NHOMQUYTRINHID);
            
            CreateTable(
                "MPLIS21.HT_XA_NGUOIDUNG",
                c => new
                    {
                        XANGUOIDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KVHCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.XANGUOIDUNGID)
                .ForeignKey("MPLIS21.HC_DMKVHC", t => t.KVHCID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HT_NGUOIDUNG", t => t.NGUOIDUNGID, cascadeDelete: true)
                .Index(t => t.KVHCID)
                .Index(t => t.NGUOIDUNGID);
            
            CreateTable(
                "MPLIS21.HT_XA_TOCHUC",
                c => new
                    {
                        XATOCHUCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KVHCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TOCHUCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.XATOCHUCID)
                .ForeignKey("MPLIS21.HC_DMKVHC", t => t.KVHCID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HT_TOCHUC", t => t.TOCHUCID, cascadeDelete: true)
                .Index(t => t.KVHCID)
                .Index(t => t.TOCHUCID);
            
            CreateTable(
                "MPLIS21.DC_THUADAT_TAISAN",
                c => new
                    {
                        THUADATTAISANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TAISANID = c.String(maxLength: 36, unicode: false),
                        THUADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MOTA = c.String(maxLength: 150, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.THUADATTAISANID)
                .ForeignKey("MPLIS21.DC_THUADAT", t => t.THUADATID, cascadeDelete: true)
                .Index(t => t.THUADATID);
            
            CreateTable(
                "MPLIS21.DC_TRANHCHAP",
                c => new
                    {
                        TRANHCHAPID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NOIDUNG = c.String(maxLength: 4000, unicode: false),
                        NGAYPHATSINH = c.DateTime(),
                        CONTRANHCHAP = c.String(maxLength: 1, unicode: false),
                        GHICHU = c.String(maxLength: 200, unicode: false),
                        THUADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.TRANHCHAPID)
                .ForeignKey("MPLIS21.DC_THUADAT", t => t.THUADATID, cascadeDelete: true)
                .Index(t => t.THUADATID);
            
            CreateTable(
                "MPLIS21.GD_GIATHUADAT",
                c => new
                    {
                        GIATHUADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAIGIADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        GIADAT = c.Decimal(precision: 18, scale: 2),
                        THOIDIEMXACDINH = c.DateTime(),
                        CANCUPHAPLY = c.String(maxLength: 2000, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        uId = c.String(maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 100, unicode: false),
                        GIADATTHEOHSDC = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.GIATHUADATID)
                .ForeignKey("MPLIS21.DC_THUADAT", t => t.THUADATID, cascadeDelete: true)
                .ForeignKey("MPLIS21.GD_DMLOAIGIADAT", t => t.LOAIGIADATID, cascadeDelete: true)
                .Index(t => t.THUADATID)
                .Index(t => t.LOAIGIADATID);
            
            CreateTable(
                "MPLIS21.GD_DMLOAIGIADAT",
                c => new
                    {
                        LOAIGIADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAIGIADAT = c.String(maxLength: 200, unicode: false),
                        GHICHU = c.String(maxLength: 200, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        uId = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIGIADATID);
            
            CreateTable(
                "MPLIS21.DM_DOITUONGSUDUNG",
                c => new
                    {
                        DOITUONGSUDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MADOITUONGSUDUNG = c.String(maxLength: 5, unicode: false),
                        TENDOITUONGSUDUNG = c.String(maxLength: 100, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        LOAICHU = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.DOITUONGSUDUNGID);
            
            CreateTable(
                "MPLIS21.DC_BD_TREN_GCN",
                c => new
                    {
                        BDTRENGCNID = c.String(nullable: false, maxLength: 36, unicode: false),
                        GIAYCHUNGNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        BIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.BDTRENGCNID)
                .ForeignKey("MPLIS21.DC_BIENDONG", t => t.BIENDONGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_GIAYCHUNGNHAN", t => t.GIAYCHUNGNHANID, cascadeDelete: true)
                .Index(t => t.BIENDONGID)
                .Index(t => t.GIAYCHUNGNHANID);
            
            CreateTable(
                "MPLIS21.DC_LOAIBIENDONG",
                c => new
                    {
                        LOAIBIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIBIENDONG = c.String(maxLength: 20, unicode: false),
                        TENLOAIBIENDONG = c.String(maxLength: 500, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIBIENDONGID);
            
            CreateTable(
                "MPLIS21.DC_NOICONGCHUNG",
                c => new
                    {
                        NOICONGCHUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENNOICONGCHUNG = c.String(maxLength: 200, unicode: false),
                        DIACHI = c.String(maxLength: 200, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.NOICONGCHUNGID);
            
            CreateTable(
                "MPLIS21.LS_BD_GCN",
                c => new
                    {
                        LSBDGCNID = c.String(nullable: false, maxLength: 36, unicode: false),
                        GCNHIENTAIID = c.String(maxLength: 36, unicode: false),
                        GCNID = c.String(maxLength: 36, unicode: false),
                        GCNCHAID = c.String(maxLength: 40, unicode: false),
                        NGAYPD = c.DateTime(),
                        BIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MAKVHC = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.LSBDGCNID)
                .ForeignKey("MPLIS21.DC_BIENDONG", t => t.BIENDONGID, cascadeDelete: true)
                .Index(t => t.BIENDONGID);
            
            CreateTable(
                "MPLIS21.LS_BD_THUA",
                c => new
                    {
                        BDTHUAID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LICHSUTHUAID = c.String(maxLength: 36, unicode: false),
                        THUAHIENTAIID = c.String(maxLength: 36, unicode: false),
                        THUAID = c.String(maxLength: 36, unicode: false),
                        THUACHAID = c.String(maxLength: 36, unicode: false),
                        NGAYPD = c.DateTime(),
                        BIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MAKVHC = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.BDTHUAID)
                .ForeignKey("MPLIS21.DC_BIENDONG", t => t.BIENDONGID, cascadeDelete: true)
                .Index(t => t.BIENDONGID);
            
            CreateTable(
                "MPLIS21.LS_BOHOSO",
                c => new
                    {
                        BOHOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DATA = c.String(),
                        BIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGAYPD = c.DateTime(),
                        MAKVHC = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.BOHOSOID)
                .ForeignKey("MPLIS21.DC_BIENDONG", t => t.BIENDONGID, cascadeDelete: true)
                .Index(t => t.BIENDONGID);
            
            CreateTable(
                "MPLIS21.LS_TC_CHU",
                c => new
                    {
                        TCCHUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENCHU = c.String(maxLength: 255, unicode: false),
                        DIACHI = c.String(maxLength: 255, unicode: false),
                        BOHOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CHUID = c.String(maxLength: 36, unicode: false),
                        SOGIAYTOXM = c.String(maxLength: 50, unicode: false),
                        MAKVHC = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.TCCHUID)
                .ForeignKey("MPLIS21.LS_BOHOSO", t => t.BOHOSOID, cascadeDelete: true)
                .Index(t => t.BOHOSOID);
            
            CreateTable(
                "MPLIS21.LS_TC_GCN",
                c => new
                    {
                        TCGCNID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SOPHATHANH = c.String(maxLength: 20, unicode: false),
                        SOVAOSO = c.String(maxLength: 10, unicode: false),
                        MAVACH = c.String(maxLength: 25, unicode: false),
                        BOHOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        GCNID = c.String(maxLength: 40, unicode: false),
                        MAKVHC = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.TCGCNID)
                .ForeignKey("MPLIS21.LS_BOHOSO", t => t.BOHOSOID, cascadeDelete: true)
                .Index(t => t.BOHOSOID);
            
            CreateTable(
                "MPLIS21.LS_TC_HOSO",
                c => new
                    {
                        TCHOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SOBIENNHAN = c.String(maxLength: 30, unicode: false),
                        NGUOINOPHOSO = c.String(maxLength: 150, unicode: false),
                        DIACHI = c.String(maxLength: 255, unicode: false),
                        HOSOID = c.String(maxLength: 36, unicode: false),
                        BOHOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MAKVHC = c.String(maxLength: 10, unicode: false),
                        NGAYNHANHOSO = c.DateTime(),
                        NGAYTRAKETQUA = c.DateTime(),
                    })
                .PrimaryKey(t => t.TCHOSOID)
                .ForeignKey("MPLIS21.LS_BOHOSO", t => t.BOHOSOID, cascadeDelete: true)
                .Index(t => t.BOHOSOID);
            
            CreateTable(
                "MPLIS21.LS_TC_THUA",
                c => new
                    {
                        TCTHUAID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SHTOBD = c.String(maxLength: 10, unicode: false),
                        STTTHUA = c.String(maxLength: 10, unicode: false),
                        MAKVHC = c.String(maxLength: 10, unicode: false),
                        BOHOSOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUAID = c.String(maxLength: 36, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.TCTHUAID)
                .ForeignKey("MPLIS21.LS_BOHOSO", t => t.BOHOSOID, cascadeDelete: true)
                .Index(t => t.BOHOSOID);
            
            CreateTable(
                "MPLIS21.DC_BD_GCN_GCN",
                c => new
                    {
                        BDGCNGCNID = c.String(nullable: false, maxLength: 36, unicode: false),
                        GCNCHAID = c.String(nullable: false, maxLength: 36, unicode: false),
                        GIAYCHUNGNHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.BDGCNGCNID)
                .ForeignKey("MPLIS21.DC_GIAYCHUNGNHAN", t => t.GIAYCHUNGNHANID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_GIAYCHUNGNHAN", t => t.GCNCHAID)
                .Index(t => t.GIAYCHUNGNHANID)
                .Index(t => t.GCNCHAID);
            
            CreateTable(
                "MPLIS21.HT_TOCHUC_NGUOIDUNG",
                c => new
                    {
                        TOCHUCNGUOIDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TOCHUCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CHUCVU = c.String(maxLength: 50, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.TOCHUCNGUOIDUNGID)
                .ForeignKey("MPLIS21.HT_NGUOIDUNG", t => t.NGUOIDUNGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.HT_TOCHUC", t => t.TOCHUCID, cascadeDelete: true)
                .Index(t => t.NGUOIDUNGID)
                .Index(t => t.TOCHUCID);
            
            CreateTable(
                "MPLIS21.HT_UNGDUNG",
                c => new
                    {
                        UNGDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENUNGDUNG = c.String(maxLength: 80, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        ICON = c.Binary(),
                        CHOPHEPSUDUNG = c.String(maxLength: 1, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 10, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        URL = c.String(maxLength: 255, unicode: false),
                        MAUNGDUNG = c.String(maxLength: 3, unicode: false),
                    })
                .PrimaryKey(t => t.UNGDUNGID);
            
            CreateTable(
                "MPLIS21.DC_CANHAN",
                c => new
                    {
                        CANHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        HOTEN = c.String(maxLength: 150, unicode: false),
                        HODEM = c.String(maxLength: 90, unicode: false),
                        TEN = c.String(maxLength: 60, unicode: false),
                        NGAYSINH = c.DateTime(),
                        NAMSINH = c.Decimal(precision: 18, scale: 2),
                        GIOITINH = c.Decimal(precision: 18, scale: 2),
                        CONSONG = c.Boolean(),
                        SOGIAYTO = c.String(maxLength: 30, unicode: false),
                        NGAYCAP = c.DateTime(),
                        NOICAP = c.String(maxLength: 100, unicode: false),
                        QUOCTICHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        QUOCTICHKHACIDS = c.String(maxLength: 1000, unicode: false),
                        DANTOCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DIACHI = c.String(maxLength: 255, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        GIAYTOTUYTHANID = c.String(maxLength: 36, unicode: false),
                        SODIENTHOAI = c.String(maxLength: 255, unicode: false),
                        EMAIL = c.String(maxLength: 50, unicode: false),
                        MASOTHUE = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.CANHANID)
                .ForeignKey("MPLIS21.DM_DANTOC", t => t.DANTOCID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DM_QUOCTICH", t => t.QUOCTICHID, cascadeDelete: true)
                .Index(t => t.DANTOCID)
                .Index(t => t.QUOCTICHID);
            
            CreateTable(
                "MPLIS21.DM_DANTOC",
                c => new
                    {
                        DANTOCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENDANTOC = c.String(maxLength: 50, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 10, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        TENGOIKHAC = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.DANTOCID);
            
            CreateTable(
                "MPLIS21.DM_QUOCTICH",
                c => new
                    {
                        QUOCTICHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MAQUOCGIA = c.String(maxLength: 3, unicode: false),
                        TENQUOCGIATV = c.String(maxLength: 150, unicode: false),
                        TENQUOCGIAQT = c.String(maxLength: 150, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 10, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.QUOCTICHID);
            
            CreateTable(
                "MPLIS21.DC_CANHO",
                c => new
                    {
                        CANHOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NHACHUNGCUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SOHIEUCANHO = c.String(maxLength: 200, unicode: false),
                        TANGSO = c.Decimal(precision: 18, scale: 2),
                        DIENTICHSAN = c.Decimal(precision: 18, scale: 2),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        HINHTHUCSOHUU = c.String(maxLength: 50, unicode: false),
                        THOIHANSOHUU = c.String(maxLength: 50, unicode: false),
                        TINHTRANGDANGKY = c.String(maxLength: 36, unicode: false),
                        DTSH_CHUNG_CDT = c.Decimal(precision: 18, scale: 2),
                        DTSH_CHUNG_NSDD = c.Decimal(precision: 18, scale: 2),
                        DTSH_RIENG = c.Decimal(precision: 18, scale: 2),
                        NGUONGOC = c.String(maxLength: 10, unicode: false),
                        NAMHOANCONG = c.Decimal(precision: 18, scale: 2),
                        CO_HSXN_NHADUYNHAT = c.String(maxLength: 1, unicode: false),
                        DT_PT_RIENGLE = c.Decimal(precision: 18, scale: 2),
                        DT_PT_KHONGRIENGLE = c.Decimal(precision: 18, scale: 2),
                        DT_HT_NVTC = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CANHOID)
                .ForeignKey("MPLIS21.DC_NHACHUNGCU", t => t.NHACHUNGCUID, cascadeDelete: true)
                .Index(t => t.NHACHUNGCUID);
            
            CreateTable(
                "MPLIS21.DC_CANHO_HANGMUCNCH",
                c => new
                    {
                        CANHOHANGMUCNCHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        HANGMUCSOHUUCHUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CANHOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.CANHOHANGMUCNCHID)
                .ForeignKey("MPLIS21.DC_CANHO", t => t.CANHOID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DC_HANGMUCNGOAICANHO", t => t.HANGMUCSOHUUCHUNGID, cascadeDelete: true)
                .Index(t => t.CANHOID)
                .Index(t => t.HANGMUCSOHUUCHUNGID);
            
            CreateTable(
                "MPLIS21.DC_HANGMUCNGOAICANHO",
                c => new
                    {
                        HANGMUCSOHUUCHUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NHACHUNGCUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENHANGMUC = c.String(maxLength: 50, unicode: false),
                        DIENTICH = c.Decimal(precision: 18, scale: 2),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.HANGMUCSOHUUCHUNGID)
                .ForeignKey("MPLIS21.DC_NHACHUNGCU", t => t.NHACHUNGCUID)
                .Index(t => t.NHACHUNGCUID);
            
            CreateTable(
                "MPLIS21.DC_NHACHUNGCU",
                c => new
                    {
                        NHACHUNGCUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KHUCHUNGCUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENCHUNGCU = c.String(maxLength: 100, unicode: false),
                        DIENTICHXAYDUNG = c.Decimal(precision: 18, scale: 2),
                        DIENTICHSAN = c.Decimal(precision: 18, scale: 2),
                        TONGSOCAN = c.Decimal(precision: 18, scale: 2),
                        SOTANG = c.Decimal(precision: 18, scale: 2),
                        SOTANGHAM = c.Decimal(precision: 18, scale: 2),
                        NAMXAYDUNG = c.Decimal(precision: 18, scale: 2),
                        NAMHOANTHANH = c.Decimal(precision: 18, scale: 2),
                        THOIHANSOHUU = c.String(maxLength: 30, unicode: false),
                        CAPHANG = c.String(maxLength: 50, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        MAXA = c.String(maxLength: 5, unicode: false),
                        DIACHI = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.NHACHUNGCUID)
                .ForeignKey("MPLIS21.DC_KHUCHUNGCU", t => t.KHUCHUNGCUID, cascadeDelete: true)
                .Index(t => t.KHUCHUNGCUID);
            
            CreateTable(
                "MPLIS21.DC_KHUCHUNGCU",
                c => new
                    {
                        KHUCHUNGCUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MAXA = c.String(maxLength: 5, unicode: false),
                        TENKHU = c.String(maxLength: 100, unicode: false),
                        DIENTICHKHU = c.Decimal(precision: 18, scale: 2),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        DIACHI = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.KHUCHUNGCUID);
            
            CreateTable(
                "MPLIS21.DC_CAYLAUNAM",
                c => new
                    {
                        CAYLAUNAMID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENCAYLAUNAM = c.String(maxLength: 50, unicode: false),
                        LOAICAYTRONG = c.String(maxLength: 255, unicode: false),
                        DIENTICH = c.Decimal(precision: 18, scale: 2),
                        DIACHIID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        HINHTHUCSOHUU = c.String(maxLength: 50, unicode: false),
                        THOIHANSOHUU = c.String(maxLength: 50, unicode: false),
                        DIACHI = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.CAYLAUNAMID);
            
            CreateTable(
                "MPLIS21.DC_CHITIETCONGKHAI",
                c => new
                    {
                        CHITIETCONGKHAIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DANHSACHCONGKHAIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUTUSAPXEP = c.Decimal(precision: 18, scale: 2),
                        NGUOIID = c.String(maxLength: 36, unicode: false),
                        TENCHUSUDUNG = c.String(maxLength: 255, unicode: false),
                        DIACHI = c.String(maxLength: 255, unicode: false),
                        THUADATID = c.String(maxLength: 36, unicode: false),
                        SOHIEUTOBANDO = c.Decimal(precision: 18, scale: 2),
                        SOTHUTUTHUA = c.Decimal(precision: 18, scale: 2),
                        MUCDICHSUDUNGDATID = c.String(maxLength: 36, unicode: false),
                        MAMUCDICHSUDUNG = c.String(maxLength: 3, unicode: false),
                        DIENTICHMDSD = c.Decimal(precision: 18, scale: 2),
                        THOIDIEMSUDUNGDAT = c.String(maxLength: 150, unicode: false),
                        NGUONGOCSUDUNG = c.String(maxLength: 500, unicode: false),
                        TAISANID = c.String(maxLength: 36, unicode: false),
                        TAISANGANLIENVOIDAT = c.String(maxLength: 255, unicode: false),
                        TINHTRANGTRANHCHAP = c.String(maxLength: 255, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        DONDANGKYID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.CHITIETCONGKHAIID)
                .ForeignKey("MPLIS21.DC_DANHSACHCONGKHAI", t => t.DANHSACHCONGKHAIID, cascadeDelete: true)
                .Index(t => t.DANHSACHCONGKHAIID);
            
            CreateTable(
                "MPLIS21.DC_DANHSACHCONGKHAI",
                c => new
                    {
                        DANHSACHCONGKHAIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                        SOVANBAN = c.String(maxLength: 120, unicode: false),
                        NGAYBATDAU = c.DateTime(),
                        NGAYKETTHUC = c.DateTime(),
                        DIADIEMCONGKHAI = c.String(maxLength: 255, unicode: false),
                        NGUOIDAIDIENXACNHAN = c.String(maxLength: 255, unicode: false),
                        DAKETTHUC = c.Boolean(),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.DANHSACHCONGKHAIID);
            
            CreateTable(
                "MPLIS21.DC_DONKIENNGHI",
                c => new
                    {
                        DONKIENNGHIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DANHSACHCONGKHAIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 150, unicode: false),
                        DUONGDANFILE = c.String(maxLength: 2000, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.DONKIENNGHIID)
                .ForeignKey("MPLIS21.DC_DANHSACHCONGKHAI", t => t.DANHSACHCONGKHAIID, cascadeDelete: true)
                .Index(t => t.DANHSACHCONGKHAIID);
            
            CreateTable(
                "MPLIS21.DC_CONGDONG",
                c => new
                    {
                        CONGDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENCONGDONG = c.String(maxLength: 36, unicode: false),
                        NGUOIDAIDIENID = c.String(maxLength: 36, unicode: false),
                        DIACHI = c.String(maxLength: 255, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        CMTNGUOIDAIDIEN = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.CONGDONGID);
            
            CreateTable(
                "MPLIS21.DC_CONGTRINHNGAM",
                c => new
                    {
                        CONGTRINHNGAMID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MAXA = c.String(maxLength: 5, unicode: false),
                        TENCONGTRINH = c.String(maxLength: 100, unicode: false),
                        LOAICONGTRINHNGAM = c.String(maxLength: 50, unicode: false),
                        DIENTICHCONGTRINH = c.Decimal(precision: 18, scale: 2),
                        DOSAUTOIDA = c.Decimal(precision: 18, scale: 2),
                        VITRIDAUNOI = c.String(maxLength: 100, unicode: false),
                        NAMXAYDUNG = c.Decimal(precision: 18, scale: 2),
                        NAMHOANTHANH = c.Decimal(precision: 18, scale: 2),
                        THOIHANSOHUU = c.String(maxLength: 30, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        HINHTHUCSOHUU = c.String(maxLength: 50, unicode: false),
                        DIACHI = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.CONGTRINHNGAMID);
            
            CreateTable(
                "MPLIS21.DC_CONGTRINHXAYDUNG",
                c => new
                    {
                        CONGTRINHXAYDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MAXA = c.String(maxLength: 5, unicode: false),
                        TENCONGTRINH = c.String(maxLength: 200, unicode: false),
                        DIENTICHXAYDUNG = c.Decimal(precision: 18, scale: 2),
                        DIENTICHSAN = c.Decimal(precision: 18, scale: 2),
                        SOTANG = c.String(maxLength: 50, unicode: false),
                        SOTANGHAM = c.Decimal(precision: 18, scale: 2),
                        NAMXAYDUNG = c.Decimal(precision: 18, scale: 2),
                        NAMHOANTHANH = c.Decimal(precision: 18, scale: 2),
                        THOIHANSOHUU = c.String(maxLength: 30, unicode: false),
                        CAPHANG = c.String(maxLength: 50, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        HINHTHUCSOHUU = c.String(maxLength: 50, unicode: false),
                        DIACHI = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.CONGTRINHXAYDUNGID);
            
            CreateTable(
                "MPLIS21.DC_HANGMUCCONGTRINH",
                c => new
                    {
                        HANGMUCCONGTRINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CONGTRINHXAYDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENHANGMUC = c.String(maxLength: 250, unicode: false),
                        CONGNANG = c.String(maxLength: 30, unicode: false),
                        DIENTICHXAYDUNG = c.Decimal(precision: 18, scale: 2),
                        DIENTICHSAN = c.Decimal(precision: 18, scale: 2),
                        SOTANG = c.String(maxLength: 250, unicode: false),
                        SOTANGHAM = c.Decimal(precision: 18, scale: 2),
                        KETCAU = c.String(maxLength: 250, unicode: false),
                        NAMXAYDUNG = c.Decimal(precision: 18, scale: 2),
                        NAMHOANTHANH = c.Decimal(precision: 18, scale: 2),
                        THOIHANSOHUU = c.String(maxLength: 150, unicode: false),
                        CAPHANG = c.String(maxLength: 50, unicode: false),
                        DIACHIID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.HANGMUCCONGTRINHID)
                .ForeignKey("MPLIS21.DC_CONGTRINHXAYDUNG", t => t.CONGTRINHXAYDUNGID, cascadeDelete: true)
                .Index(t => t.CONGTRINHXAYDUNGID);
            
            CreateTable(
                "MPLIS21.DC_DANGKY_TAISAN",
                c => new
                    {
                        DANGKYTAISANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DONDANGKYID = c.String(maxLength: 36, unicode: false),
                        TAISANID = c.String(maxLength: 36, unicode: false),
                        MOTATOMTAT = c.String(maxLength: 150, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.DANGKYTAISANID);
            
            CreateTable(
                "MPLIS21.DC_GIAYTOTUYTHAN",
                c => new
                    {
                        GIAYTOTUYTHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAIGIAYTOTUYTHANID = c.String(maxLength: 36, unicode: false),
                        CANHANID = c.String(maxLength: 36, unicode: false),
                        SOGIAYTO = c.String(maxLength: 50, unicode: false),
                        NGAYCAP = c.DateTime(),
                        NOICAP = c.String(maxLength: 200, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        LAGIAYTOINGCN = c.Boolean(),
                    })
                .PrimaryKey(t => t.GIAYTOTUYTHANID);
            
            CreateTable(
                "MPLIS21.DC_HANCHE",
                c => new
                    {
                        HANCHEID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAIHANCHEID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DIENTICH = c.Decimal(precision: 18, scale: 2),
                        NOIDUNGHANCHE = c.String(maxLength: 150, unicode: false),
                        HANCHEMOTPHAN = c.String(maxLength: 1, unicode: false),
                        SOVANBAN = c.String(maxLength: 15, unicode: false),
                        NGAYBANHANH = c.DateTime(),
                        COQUANBANHANH = c.String(maxLength: 150, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        DUONGDANFILEVANBAN = c.String(maxLength: 500, unicode: false),
                        GIAYCHUNGNHANID = c.String(maxLength: 36, unicode: false),
                        THUADATID = c.String(maxLength: 36, unicode: false),
                        LOAIHANCHE = c.Decimal(precision: 18, scale: 2),
                        SODORANHGIOIHANCHE = c.String(maxLength: 500, unicode: false),
                        CONHIEULUC = c.String(maxLength: 1, unicode: false),
                        NGAYHETHIEULUC = c.DateTime(),
                    })
                .PrimaryKey(t => t.HANCHEID)
                .ForeignKey("MPLIS21.DC_LOAIHANCHE", t => t.LOAIHANCHEID, cascadeDelete: true)
                .Index(t => t.LOAIHANCHEID);
            
            CreateTable(
                "MPLIS21.DC_LOAIHANCHE",
                c => new
                    {
                        LOAIHANCHEID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENLOAIHANCHE = c.String(maxLength: 500, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.LOAIHANCHEID);
            
            CreateTable(
                "MPLIS21.DC_HOGIADINH",
                c => new
                    {
                        HOGIADINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CHUHO = c.String(maxLength: 36, unicode: false),
                        VOCHONG = c.String(maxLength: 36, unicode: false),
                        DIACHI = c.String(maxLength: 255, unicode: false),
                        DIACHIID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        CMTCHUHO = c.String(maxLength: 30, unicode: false),
                        CMTVOCHONG = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.HOGIADINHID);
            
            CreateTable(
                "MPLIS21.DC_HOGIADINH_THANHVIEN",
                c => new
                    {
                        HOGIADINHTVID = c.String(nullable: false, maxLength: 36, unicode: false),
                        HOGIADINHID = c.String(maxLength: 36, unicode: false),
                        CANHANID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        QHVOICHUHOID = c.String(nullable: false, maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.HOGIADINHTVID)
                .ForeignKey("MPLIS21.DM_QHVOICHUHO", t => t.QHVOICHUHOID, cascadeDelete: true)
                .Index(t => t.QHVOICHUHOID);
            
            CreateTable(
                "MPLIS21.DM_QHVOICHUHO",
                c => new
                    {
                        QHVOICHUHOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENQUANHE = c.String(maxLength: 120, unicode: false),
                        GHICHU = c.String(maxLength: 200, unicode: false),
                        STT = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.QHVOICHUHOID);
            
            CreateTable(
                "MPLIS21.DC_LOAICHEDOMIENGIAM",
                c => new
                    {
                        LOAICHEDOMIENGIAMID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENLOAICHEDOMIENGIAM = c.String(maxLength: 200, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.LOAICHEDOMIENGIAMID);
            
            CreateTable(
                "MPLIS21.DC_LOAICHEDONO",
                c => new
                    {
                        LOAICHEDONOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENLOAICHEDONO = c.String(maxLength: 200, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.LOAICHEDONOID);
            
            CreateTable(
                "MPLIS21.DC_MUCDICHSUDUNGDATLS",
                c => new
                    {
                        MUCDICHSUDUNGDATLSID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUADATLSID = c.String(maxLength: 36, unicode: false),
                        SOTHUTUMDSD = c.Decimal(precision: 18, scale: 2),
                        MUCDICHSUDUNGID = c.String(maxLength: 36, unicode: false),
                        MUCDICHSUDUNGQHID = c.String(maxLength: 36, unicode: false),
                        DIENTICH = c.Decimal(precision: 18, scale: 2),
                        SUDUNGCHUNG = c.Decimal(precision: 18, scale: 2),
                        THOIHANSUDUNG = c.String(maxLength: 50, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.MUCDICHSUDUNGDATLSID);
            
            CreateTable(
                "MPLIS21.DC_NGANCHANGIAYCHUNGNHAN",
                c => new
                    {
                        NGANCHANGIAYID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THONGTINNGANCHANID = c.String(maxLength: 36, unicode: false),
                        GIAYCHUNGNHANID = c.String(maxLength: 36, unicode: false),
                        SOHIEUGIAYCHUNGNHAN = c.String(maxLength: 15, unicode: false),
                        SOHOSOGOC = c.String(maxLength: 15, unicode: false),
                        SOVAOSO = c.String(maxLength: 15, unicode: false),
                        CANCUCAPGIAY = c.String(maxLength: 256, unicode: false),
                        NGAYCAPGIAYCHUNGNHAN = c.DateTime(),
                        GHICHU = c.String(maxLength: 256, unicode: false),
                        DVHCID = c.String(maxLength: 10, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.NGANCHANGIAYID);
            
            CreateTable(
                "MPLIS21.DC_NGANCHANNGUOI",
                c => new
                    {
                        NGANCHANNGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THONGTINNGANCHANID = c.String(maxLength: 36, unicode: false),
                        NGUOIID = c.String(maxLength: 36, unicode: false),
                        HOVATEN = c.String(maxLength: 200, unicode: false),
                        SOGIAYTO = c.String(maxLength: 100, unicode: false),
                        DAICHI = c.String(maxLength: 256, unicode: false),
                        GHICHU = c.String(maxLength: 256, unicode: false),
                        QUOCTICHID = c.String(maxLength: 36, unicode: false),
                        DVHCID = c.String(maxLength: 10, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                    })
                .PrimaryKey(t => t.NGANCHANNGUOIID);
            
            CreateTable(
                "MPLIS21.DC_NGANCHANTAISAN",
                c => new
                    {
                        NGANCHANTAISANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THONGTINNGANCHANID = c.String(maxLength: 36, unicode: false),
                        TAISANGANLIENVOIDATID = c.String(maxLength: 36, unicode: false),
                        LOAITAISAN = c.String(maxLength: 100, unicode: false),
                        TENTAISAN = c.String(maxLength: 256, unicode: false),
                        DIACHICHITIET = c.String(maxLength: 256, unicode: false),
                        SONHA = c.String(maxLength: 20, unicode: false),
                        PHO = c.String(maxLength: 100, unicode: false),
                        KHUPHOXOM = c.String(maxLength: 100, unicode: false),
                        DVHCID = c.String(maxLength: 3610, unicode: false),
                        GHICHU = c.String(maxLength: 256, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                    })
                .PrimaryKey(t => t.NGANCHANTAISANID);
            
            CreateTable(
                "MPLIS21.DC_NGANCHANTHUADAT",
                c => new
                    {
                        NGANCHANTHUADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THONGTINNGANCHANID = c.String(maxLength: 36, unicode: false),
                        THUADATID = c.String(maxLength: 36, unicode: false),
                        DVHCID = c.String(maxLength: 10, unicode: false),
                        SOTHUA = c.Decimal(precision: 18, scale: 2),
                        SOTOBANDO = c.Decimal(precision: 18, scale: 2),
                        DIACHITHUADAT = c.String(maxLength: 256, unicode: false),
                        SOTHUATAM = c.String(maxLength: 50, unicode: false),
                        SOTOBANDOTAM = c.String(maxLength: 50, unicode: false),
                        GHICHU = c.String(maxLength: 255, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                    })
                .PrimaryKey(t => t.NGANCHANTHUADATID);
            
            CreateTable(
                "MPLIS21.DC_NGUOILS",
                c => new
                    {
                        NGUOILSID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CHITIETID = c.String(maxLength: 36, unicode: false),
                        LOAIDOITUONGID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.NGUOILSID);
            
            CreateTable(
                "MPLIS21.DC_NHARIENGLE",
                c => new
                    {
                        NHARIENGLEID = c.String(nullable: false, maxLength: 36, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                        DIENTICHXAYDUNG = c.Decimal(precision: 18, scale: 2),
                        DIENTICHSAN = c.Decimal(precision: 18, scale: 2),
                        SOTANG = c.String(maxLength: 100, unicode: false),
                        SOTANGHAM = c.Decimal(precision: 18, scale: 2),
                        KETCAU = c.String(maxLength: 150, unicode: false),
                        CAPHANG = c.String(maxLength: 50, unicode: false),
                        DIACHI = c.String(maxLength: 255, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        LOAICAPHANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAINHAID = c.String(nullable: false, maxLength: 36, unicode: false),
                        DTSH_RIENG = c.Decimal(precision: 18, scale: 2),
                        DT_SH_CHUNG = c.Decimal(precision: 18, scale: 2),
                        NAMHOANCONG = c.Decimal(precision: 18, scale: 2),
                        TLCL_CONLAI = c.Decimal(precision: 18, scale: 2),
                        CO_HSXN_NHADUYNHAT = c.String(maxLength: 1, unicode: false),
                        DT_HT_NVTC = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.NHARIENGLEID)
                .ForeignKey("MPLIS21.DM_LOAICAPHANG", t => t.LOAICAPHANGID, cascadeDelete: true)
                .ForeignKey("MPLIS21.DM_LOAINHA", t => t.LOAINHAID, cascadeDelete: true)
                .Index(t => t.LOAICAPHANGID)
                .Index(t => t.LOAINHAID);
            
            CreateTable(
                "MPLIS21.DM_LOAICAPHANG",
                c => new
                    {
                        LOAICAPHANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAICAPHANG = c.String(maxLength: 5, unicode: false),
                        TENLOAICAPHANG = c.String(maxLength: 20, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAICAPHANGID);
            
            CreateTable(
                "MPLIS21.DM_LOAINHA",
                c => new
                    {
                        LOAINHAID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAINHA = c.String(maxLength: 20, unicode: false),
                        TENLOAINHA = c.String(maxLength: 200, unicode: false),
                        GHICHU = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.LOAINHAID);
            
            CreateTable(
                "MPLIS21.DC_NHOMNGUOI",
                c => new
                    {
                        NHOMNGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIDAIDIEN = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        CMTNGUOIDAIDIEN = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.NHOMNGUOIID);
            
            CreateTable(
                "MPLIS21.DC_NHOMNGUOI_THANHVIEN",
                c => new
                    {
                        NHOMNGUOITHANHVIENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NHOMNGUOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAIDOITUONG = c.String(maxLength: 1, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THANHPHANID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.NHOMNGUOITHANHVIENID)
                .ForeignKey("MPLIS21.DC_NHOMNGUOI", t => t.NHOMNGUOIID, cascadeDelete: true)
                .Index(t => t.NHOMNGUOIID);
            
            CreateTable(
                "MPLIS21.DC_QUYENSOHUUTAISANLS",
                c => new
                    {
                        QUYENSOHUUTAISANLSID = c.String(nullable: false, maxLength: 36, unicode: false),
                        BIENDONGID = c.String(maxLength: 36, unicode: false),
                        TRUOCBIENDONG = c.Decimal(precision: 18, scale: 2),
                        NGUOILSID = c.String(maxLength: 36, unicode: false),
                        TAISANGANLIENVOIDATLSID = c.String(maxLength: 36, unicode: false),
                        NGHIAVUTAICHINHLSID = c.String(maxLength: 36, unicode: false),
                        GIAYCHUNGNHANLSID = c.String(maxLength: 36, unicode: false),
                        HANCHEQUYENSOHUULSID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        DONDANGKYID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.QUYENSOHUUTAISANLSID);
            
            CreateTable(
                "MPLIS21.DC_QUYENSUDUNGDATLS",
                c => new
                    {
                        QUYENSUDUNGDATLSID = c.String(nullable: false, maxLength: 36, unicode: false),
                        BIENDONGID = c.String(maxLength: 36, unicode: false),
                        TRUOCBIENDONG = c.Decimal(precision: 18, scale: 2),
                        NGUOILSID = c.String(maxLength: 36, unicode: false),
                        THUADATLSID = c.String(maxLength: 36, unicode: false),
                        DAMUCDICHSUDUNGLSID = c.String(maxLength: 36, unicode: false),
                        NGHIAVUTAICHINHLSID = c.String(maxLength: 36, unicode: false),
                        HANCHEQUYENLSID = c.String(maxLength: 36, unicode: false),
                        GIAYCHUNGNHANLSID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        DONDANGKYID = c.String(maxLength: 36, unicode: false),
                        LAQUYENQUANLY = c.String(maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.QUYENSUDUNGDATLSID);
            
            CreateTable(
                "MPLIS21.DC_QUYENSUDUNGDATSAUBD",
                c => new
                    {
                        QUYENSUDUNGDATSAUBDID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOIID = c.String(maxLength: 36, unicode: false),
                        THUADATID = c.String(maxLength: 36, unicode: false),
                        DAMUCDICHSUDUNGID = c.String(maxLength: 36, unicode: false),
                        NGHIAVUTAICHINHID = c.String(maxLength: 36, unicode: false),
                        HANCHEQUYENID = c.String(maxLength: 36, unicode: false),
                        GIAYCHUNGNHANID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        DONDANGKYID = c.String(maxLength: 36, unicode: false),
                        LAQUYENQUANLY = c.String(maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.QUYENSUDUNGDATSAUBDID);
            
            CreateTable(
                "MPLIS21.DC_QUYETDINH",
                c => new
                    {
                        QUYETDINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SOQUYETDINH = c.String(maxLength: 20, unicode: false),
                        NGAYQUYETDINH = c.DateTime(),
                        NOIDUNGQUYETDINH = c.String(maxLength: 1000, unicode: false),
                        SOHOPDONG = c.String(maxLength: 20, unicode: false),
                        NGAYHOPDONG = c.DateTime(),
                        GIATRIHOPDONG = c.Decimal(precision: 18, scale: 2),
                        SOCONGCHUNG = c.String(maxLength: 20, unicode: false),
                        QUYENCONGCHUNG = c.String(maxLength: 20, unicode: false),
                        NOICONGCHUNG = c.String(maxLength: 100, unicode: false),
                        NGAYCONGCHUNG = c.DateTime(),
                        NOIDUNGHOPDONG = c.String(maxLength: 1000, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.QUYETDINHID);
            
            CreateTable(
                "MPLIS21.DC_RUNGTRONG",
                c => new
                    {
                        RUNGTRONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENRUNG = c.String(maxLength: 50, unicode: false),
                        LOAICAYRUNG = c.String(maxLength: 255, unicode: false),
                        DIENTICH = c.Decimal(precision: 18, scale: 2),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIHANSOHUU = c.String(maxLength: 50, unicode: false),
                        HINHTHUCSOHUU = c.String(maxLength: 50, unicode: false),
                        DIACHI = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.RUNGTRONGID);
            
            CreateTable(
                "MPLIS21.DC_SODIACHINHDIENTU_CANHO",
                c => new
                    {
                        SODIACHINHCANHOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENTAISAN = c.String(maxLength: 255, unicode: false),
                        LOAITAISAN = c.String(maxLength: 200, unicode: false),
                        TAISANID = c.String(maxLength: 36, unicode: false),
                        MADVHC = c.String(maxLength: 5, unicode: false),
                        FILEPATH = c.String(maxLength: 256, unicode: false),
                        NGAYTAO = c.DateTime(),
                        THOIDIEMKY = c.DateTime(),
                        NGUOIKY = c.String(maxLength: 255, unicode: false),
                        TINHTRANG = c.String(maxLength: 1, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        XAID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.SODIACHINHCANHOID);
            
            CreateTable(
                "MPLIS21.DC_SODIACHINHDIENTU_THUADAT",
                c => new
                    {
                        SODIACHINHTHUADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        THUADATID = c.String(maxLength: 36, unicode: false),
                        SOTHUA = c.String(maxLength: 5, unicode: false),
                        SOTOBANDO = c.String(maxLength: 5, unicode: false),
                        MADVHC = c.String(maxLength: 5, unicode: false),
                        NGAYTAO = c.DateTime(),
                        FILEPATH = c.String(maxLength: 255, unicode: false),
                        THOIDIEMKY = c.DateTime(),
                        NGUOIKY = c.String(maxLength: 255, unicode: false),
                        TINHTRANG = c.String(maxLength: 1, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        XAID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.SODIACHINHTHUADATID);
            
            CreateTable(
                "MPLIS21.DC_TAISANGANLIENVOIDATLICHSU",
                c => new
                    {
                        TAISANGANLIENVOIDATLICHSUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        BIENDONGID = c.String(maxLength: 36, unicode: false),
                        TRUOCBIENDONG = c.String(maxLength: 1, unicode: false),
                        TAISANLSID = c.String(maxLength: 36, unicode: false),
                        LOAITAISAN = c.String(maxLength: 36, unicode: false),
                        TENTAISAN = c.String(maxLength: 150, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.TAISANGANLIENVOIDATLICHSUID);
            
            CreateTable(
                "MPLIS21.DC_TAISANGANLIENVOIDATLS",
                c => new
                    {
                        TAISANGANLIENVOIDATLSID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TAISANLSID = c.String(maxLength: 36, unicode: false),
                        LOAITAISAN = c.String(maxLength: 36, unicode: false),
                        TENTAISAN = c.String(maxLength: 150, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.TAISANGANLIENVOIDATLSID);
            
            CreateTable(
                "MPLIS21.DC_TENDUONG",
                c => new
                    {
                        TENDUONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TINHID = c.String(maxLength: 36, unicode: false),
                        HUYENID = c.String(maxLength: 36, unicode: false),
                        LOAIDUONG = c.Decimal(precision: 18, scale: 2),
                        MADUONG = c.String(maxLength: 20, unicode: false),
                        MADUONG_THUE = c.String(maxLength: 20, unicode: false),
                        TENDUONG = c.String(maxLength: 255, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.TENDUONGID);
            
            CreateTable(
                "MPLIS21.DC_THONGTINNGANCHAN",
                c => new
                    {
                        THONGTINNGANCHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MUCDONGANCHAN = c.Decimal(precision: 18, scale: 2),
                        SOHIEUCONGVAN = c.String(maxLength: 100, unicode: false),
                        THOIDIEMBATDAU = c.DateTime(),
                        THOIDIEMKETTHUC = c.DateTime(),
                        NOIDUNGNGANCHAN = c.String(maxLength: 256, unicode: false),
                        LYDONGANCHAN = c.String(maxLength: 256, unicode: false),
                        FILENGANCHAN = c.Binary(),
                        LOAIDOITUONGNGANCHAN = c.String(maxLength: 60, unicode: false),
                        HIEULUC = c.String(maxLength: 1, unicode: false),
                        THONGTINFILENGANCHAN = c.String(maxLength: 256, unicode: false),
                        CHANCAPGIAY = c.String(maxLength: 1, unicode: false),
                        CHANGIAODICH = c.String(maxLength: 1, unicode: false),
                        CHANBIENDONG = c.String(maxLength: 1, unicode: false),
                        BIENDONGID = c.String(maxLength: 36, unicode: false),
                        DVHCID = c.String(maxLength: 10, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.THONGTINNGANCHANID);
            
            CreateTable(
                "MPLIS21.DC_THUADATLS",
                c => new
                    {
                        THUADATLSID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MAXA = c.String(maxLength: 5, unicode: false),
                        SOHIEUTOBANDO = c.Decimal(precision: 18, scale: 2),
                        SOTHUTUTHUA = c.Decimal(precision: 18, scale: 2),
                        SOHIEUTOBANDOCU = c.String(maxLength: 50, unicode: false),
                        SOTHUTUTHUACU = c.String(maxLength: 50, unicode: false),
                        DIENTICH = c.Decimal(precision: 18, scale: 2),
                        DIENTICHPHAPLY = c.Decimal(precision: 18, scale: 2),
                        TAILIEUDODACID = c.String(maxLength: 36, unicode: false),
                        LADOITUONGCHIEMDAT = c.Decimal(precision: 18, scale: 2),
                        DIACHIID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        DIACHI = c.String(maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.THUADATLSID);
            
            CreateTable(
                "MPLIS21.DC_TOCHUC",
                c => new
                    {
                        TOCHUCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENTOCHUC = c.String(maxLength: 500, unicode: false),
                        TENVIETTAT = c.String(maxLength: 30, unicode: false),
                        TENTOCHUCTA = c.String(maxLength: 120, unicode: false),
                        NGUOIDAIDIENID = c.String(maxLength: 36, unicode: false),
                        SOQUYETDINH = c.String(maxLength: 50, unicode: false),
                        NGAYQUYETDINH = c.DateTime(),
                        LOAIQUYETDINHTHANHLAP = c.String(maxLength: 100, unicode: false),
                        MADOANHNGHIEP = c.String(maxLength: 30, unicode: false),
                        MASOTHUE = c.String(maxLength: 20, unicode: false),
                        LOAITOCHUC = c.String(maxLength: 36, unicode: false),
                        DIACHI = c.String(maxLength: 255, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        CMTNGUOIDAIDIEN = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.TOCHUCID);
            
            CreateTable(
                "MPLIS21.DC_VOCHONG",
                c => new
                    {
                        VOCHONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        CHONG = c.String(maxLength: 36, unicode: false),
                        VO = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        DIACHI = c.String(maxLength: 255, unicode: false),
                        CMTCHONG = c.String(maxLength: 30, unicode: false),
                        CMTVO = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.VOCHONGID);
            
            CreateTable(
                "MPLIS21.DC_XA_TENDUONG",
                c => new
                    {
                        XATENDUONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENDUONGID = c.String(maxLength: 36, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.XATENDUONGID);
            
            CreateTable(
                "MPLIS21.DM_GIAYTOKEMTHEOHS",
                c => new
                    {
                        GIAYTOKEMTHEOHSID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENGIAYTOKEMTHEOHS = c.String(maxLength: 2000, unicode: false),
                        MAUGIAYTO = c.Binary(),
                        THUTUSAPXEP = c.String(maxLength: 15, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        KYHIEU = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.GIAYTOKEMTHEOHSID);
            
            CreateTable(
                "MPLIS21.DM_LOAIBIENDONG",
                c => new
                    {
                        LOAIBIENDONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MABIENDONG = c.String(maxLength: 3, unicode: false),
                        TENLOAIBIENDONG = c.String(maxLength: 255, unicode: false),
                        NGUOISUDUNG = c.String(maxLength: 100, unicode: false),
                        TRANGTHAI = c.String(maxLength: 1, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 100, unicode: false),
                        uid = c.String(maxLength: 250, unicode: false),
                        VAITROCHUVAO = c.String(maxLength: 250, unicode: false),
                        VAITROCHURA = c.String(maxLength: 250, unicode: false),
                        TENBANGDULIEU = c.String(maxLength: 40, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIBIENDONGID);
            
            CreateTable(
                "MPLIS21.DM_LOAIDATHIENTRANG",
                c => new
                    {
                        LOAIDATHIENTRANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KHOACHAID = c.String(maxLength: 36, unicode: false),
                        MALOAIDATHIENTRANG = c.String(maxLength: 4, unicode: false),
                        TENLOAIDATHIENTRANG = c.String(maxLength: 120, unicode: false),
                        THUTUSAPXEP = c.String(maxLength: 10, unicode: false),
                        CANCUPHAPLY = c.String(maxLength: 100, unicode: false),
                        PHIENBAN = c.String(maxLength: 20, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        CHITIET = c.Boolean(),
                    })
                .PrimaryKey(t => t.LOAIDATHIENTRANGID);
            
            CreateTable(
                "MPLIS21.DM_LOAIDIADANH",
                c => new
                    {
                        LOAIDIADANHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIDIADANH = c.String(maxLength: 5, unicode: false),
                        TENLOAIDIADANH = c.String(maxLength: 60, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIDIADANHID);
            
            CreateTable(
                "MPLIS21.DM_LOAIDIEMDOCAO",
                c => new
                    {
                        LOAIDIEMDOCAOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIDIEMDOCAO = c.String(maxLength: 5, unicode: false),
                        TENLOAIDIEMDOCAO = c.String(maxLength: 60, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIDIEMDOCAOID);
            
            CreateTable(
                "MPLIS21.DM_LOAIDIEMTOADO",
                c => new
                    {
                        LOAIDIEMTOADOID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIDIEMTOADO = c.String(maxLength: 5, unicode: false),
                        TENLOAIDIEMTOADO = c.String(maxLength: 60, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIDIEMTOADOID);
            
            CreateTable(
                "MPLIS21.DM_LOAIDUONG",
                c => new
                    {
                        LOAIDUONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIDUONG = c.String(maxLength: 5, unicode: false),
                        TENLOAIDUONG = c.String(maxLength: 40, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIDUONGID);
            
            CreateTable(
                "MPLIS21.DM_LOAIDUONGTHUYHE",
                c => new
                    {
                        LOAIDUONGTHUYHEID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIDUONGTHUYHE = c.String(maxLength: 5, unicode: false),
                        TENLOAIDUONGTHUYHE = c.String(maxLength: 80, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIDUONGTHUYHEID);
            
            CreateTable(
                "MPLIS21.DM_LOAIGIAYTOTUYTHAN",
                c => new
                    {
                        LOAIGIAYTOTUYTHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIGIAYTOTUYTHAN = c.String(maxLength: 5, unicode: false),
                        TENLOAIGIAYTOTUYTHAN = c.String(maxLength: 80, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIGIAYTOTUYTHANID);
            
            CreateTable(
                "MPLIS21.DM_LOAIHANHDONG",
                c => new
                    {
                        LOAIHANHDONGID = c.String(nullable: false, maxLength: 100, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        URL = c.String(maxLength: 1000, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATIF = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.LOAIHANHDONGID);
            
            CreateTable(
                "MPLIS21.DM_LOAIHANHLANGANTOANBAOVE",
                c => new
                    {
                        LOAIHANHLANGANTOANBAOVEID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIHANHLANGANTOANBAOVE = c.String(maxLength: 5, unicode: false),
                        TENLOAIHANHLANGANTOANBAOVE = c.String(maxLength: 120, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIHANHLANGANTOANBAOVEID);
            
            CreateTable(
                "MPLIS21.DM_LOAIKETCAU",
                c => new
                    {
                        LOAIKETCAUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIKETCAU = c.String(maxLength: 5, unicode: false),
                        TENLOAIKETCAU = c.String(maxLength: 20, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIKETCAUID);
            
            CreateTable(
                "MPLIS21.DM_LOAIKHUCHUCNANGCAPHUYEN",
                c => new
                    {
                        LOAIKHUCHUCNANGCAPHUYENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIKHUCHUCNANGCAPHUYEN = c.String(maxLength: 5, unicode: false),
                        TENLOAIKHUCHUCNANGCAPHUYEN = c.String(maxLength: 100, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIKHUCHUCNANGCAPHUYENID);
            
            CreateTable(
                "MPLIS21.DM_LOAIKHUCHUCNANGCAPTINH",
                c => new
                    {
                        LOAIKHUCHUCNANGCAPTINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIKHUCHUCNANGCAPTINH = c.String(maxLength: 5, unicode: false),
                        TENLOAIKHUCHUCNANGCAPTINH = c.String(maxLength: 100, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIKHUCHUCNANGCAPTINHID);
            
            CreateTable(
                "MPLIS21.DM_LOAIKHUVUCTONGHOP",
                c => new
                    {
                        LOAIKHUVUCTONGHOPID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIKHUVUCTONGHOP = c.String(maxLength: 5, unicode: false),
                        TENLOAIKHUVUCTONGHOP = c.String(maxLength: 80, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIKHUVUCTONGHOPID);
            
            CreateTable(
                "MPLIS21.DM_LOAIMOC",
                c => new
                    {
                        LOAIMOCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIMOC = c.String(maxLength: 5, unicode: false),
                        TENLOAIMOC = c.String(maxLength: 60, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIMOCID);
            
            CreateTable(
                "MPLIS21.DM_LOAIMOCBIENGIOIDIAGIOI",
                c => new
                    {
                        LOAIMOCBIENGIOIDIAGIOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIMOCBIENGIOIDIAGIOI = c.String(maxLength: 5, unicode: false),
                        TENLOAIMOCBIENGIOIDIAGIOI = c.String(maxLength: 60, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIMOCBIENGIOIDIAGIOIID);
            
            CreateTable(
                "MPLIS21.DM_LOAIQUYHOACH",
                c => new
                    {
                        LOAIQUYHOACHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIQUYHOACH = c.String(maxLength: 5, unicode: false),
                        TENLOAIQUYHOACH = c.String(maxLength: 60, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIQUYHOACHID);
            
            CreateTable(
                "MPLIS21.DM_LOAITAISANGANLIENVOIDAT",
                c => new
                    {
                        LOAITAISANGANLIENVOIDATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAITAISANGANLIENVOIDAT = c.String(maxLength: 5, unicode: false),
                        TENLOAITAISANGANLIENVOIDAT = c.String(maxLength: 60, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAITAISANGANLIENVOIDATID);
            
            CreateTable(
                "MPLIS21.DM_LOAITOCHUC",
                c => new
                    {
                        LOAITOCHUCID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAITOCHUC = c.String(maxLength: 3, unicode: false),
                        TENLOAITOCHUC = c.String(maxLength: 60, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.LOAITOCHUCID);
            
            CreateTable(
                "MPLIS21.DM_LOAITRANGTHAIDANGKYCAPGCN",
                c => new
                    {
                        LOAITRANGTHAIDANGKYCAPGCNID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAITRANGTHAIDANGKYCAPGCN = c.String(maxLength: 5, unicode: false),
                        TENLOAITRANGTHAIDANGKYCAPGCN = c.String(maxLength: 100, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAITRANGTHAIDANGKYCAPGCNID);
            
            CreateTable(
                "MPLIS21.DM_LOAIVUNGTHUYHE",
                c => new
                    {
                        LOAIVUNGTHUYHEID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MALOAIVUNGTHUYHE = c.String(maxLength: 5, unicode: false),
                        TENLOAIVUNGTHUYHE = c.String(maxLength: 60, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.LOAIVUNGTHUYHEID);
            
            CreateTable(
                "MPLIS21.DM_SEQUENCE",
                c => new
                    {
                        SEQUENCEID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 32, unicode: false),
                        MAHUYEN = c.String(maxLength: 32, unicode: false),
                        MAXA = c.String(maxLength: 32, unicode: false),
                        SOHIEUTOBANDO = c.Decimal(precision: 18, scale: 2),
                        SOTHUTUTHUA = c.Decimal(precision: 18, scale: 2),
                        STT = c.Int(),
                    })
                .PrimaryKey(t => t.SEQUENCEID);
            
            CreateTable(
                "MPLIS21.DM_TRANGTHAIHOSO",
                c => new
                    {
                        TRANGTHAIHOSOID = c.String(nullable: false, maxLength: 100, unicode: false),
                        TENTRANGTHAI = c.String(maxLength: 255, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.TRANGTHAIHOSOID);
            
            CreateTable(
                "MPLIS21.GD_BANDOGIADAT",
                c => new
                    {
                        BANDOGIADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 2, unicode: false),
                        MAHUYEN = c.String(maxLength: 3, unicode: false),
                        MAXA = c.String(maxLength: 5, unicode: false),
                        FILEDINHKEM = c.String(maxLength: 200, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        uId = c.String(maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 100, unicode: false),
                        NOIDUNGTOMTAT = c.String(maxLength: 4000, unicode: false),
                        NAM = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BANDOGIADATID);
            
            CreateTable(
                "MPLIS21.GD_BANGGIADAT",
                c => new
                    {
                        BANGGIADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 2, unicode: false),
                        MAHUYEN = c.String(maxLength: 3, unicode: false),
                        BANGSO = c.Decimal(precision: 18, scale: 2),
                        FILEDINHKEM = c.String(maxLength: 200, unicode: false),
                        QDGIADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        uId = c.String(maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.BANGGIADATID)
                .ForeignKey("MPLIS21.GD_QDGIADAT", t => t.QDGIADATID, cascadeDelete: true)
                .Index(t => t.QDGIADATID);
            
            CreateTable(
                "MPLIS21.GD_QDGIADAT",
                c => new
                    {
                        QDGIADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SOQUYETDINH = c.String(maxLength: 100, unicode: false),
                        FILEQUYETDINH = c.String(maxLength: 200, unicode: false),
                        NGAYBANHANH = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        uId = c.String(maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 100, unicode: false),
                        NOIDUNGTOMTAT = c.String(maxLength: 4000, unicode: false),
                    })
                .PrimaryKey(t => t.QDGIADATID);
            
            CreateTable(
                "MPLIS21.GD_HSDCGIADAT",
                c => new
                    {
                        HSDCGIADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SOQUYETDINH = c.String(maxLength: 100, unicode: false),
                        NGAYBANHANH = c.DateTime(),
                        HESODIEUCHINH = c.Decimal(precision: 18, scale: 2),
                        NGAYHIEULUC = c.DateTime(),
                        FILEQUYETDINH = c.String(maxLength: 200, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        uId = c.String(maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 100, unicode: false),
                        NOIDUNGTOMTAT = c.String(maxLength: 4000, unicode: false),
                    })
                .PrimaryKey(t => t.HSDCGIADATID);
            
            CreateTable(
                "MPLIS21.GD_KHUNGGIADAT",
                c => new
                    {
                        KHUNGGIADATID = c.String(nullable: false, maxLength: 36, unicode: false),
                        SOQUYETDINH = c.String(maxLength: 100, unicode: false),
                        NGAYBANHANH = c.DateTime(),
                        FILEDINHKEM = c.String(maxLength: 200, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        uId = c.String(maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 100, unicode: false),
                        NOIDUNGTOMTAT = c.String(maxLength: 4000, unicode: false),
                        MUCGIATOITHIEU = c.Decimal(precision: 18, scale: 2),
                        MUCGIATOIDA = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.KHUNGGIADATID);
            
            CreateTable(
                "MPLIS21.HS_VITRILUUTRU",
                c => new
                    {
                        VITRILUUTRUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KHOACHAID = c.String(maxLength: 36, unicode: false),
                        MAVITRILUUTRU = c.String(maxLength: 36, unicode: false),
                        TENVITRILUUTRU = c.String(maxLength: 100, unicode: false),
                        MOTA = c.String(maxLength: 250, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                        SODOVITRI = c.Binary(),
                        TRANGTHAI = c.Boolean(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.VITRILUUTRUID);
            
            CreateTable(
                "MPLIS21.HT_CAUHINH",
                c => new
                    {
                        CAUHINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENCAUHINH = c.String(maxLength: 50, unicode: false),
                        GIATRI = c.String(maxLength: 255, unicode: false),
                        CAP = c.Byte(),
                        MADONVIHANHCHINHID = c.String(maxLength: 36, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.CAUHINHID);
            
            CreateTable(
                "MPLIS21.HT_MAUGIAYTOKEMTHEOHS",
                c => new
                    {
                        MAUGIAYTOKEMTHEOHSID = c.String(nullable: false, maxLength: 36, unicode: false),
                        GIAYTOKEMTHEOHSID = c.String(maxLength: 36, unicode: false),
                        CAP = c.Byte(),
                        MADONVIHANHCHINHID = c.String(maxLength: 36, unicode: false),
                        TEMPLATE = c.Binary(),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.MAUGIAYTOKEMTHEOHSID);
            
            CreateTable(
                "MPLIS21.HT_THONGBAO",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        NGUOIDUNGID = c.String(),
                        NOIDUNG = c.String(),
                        LINK = c.String(),
                        DAXEM = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NGAYNHAN = c.DateTime(nullable: false),
                        NGAYXEM = c.DateTime(nullable: false),
                        TIEUDE = c.String(),
                        VOHIEUHOA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NGUOICAPNHATID = c.String(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "MPLIS21.MT_CHATLUONG",
                c => new
                    {
                        MCHATLUONGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MUCCHATLUONG = c.String(maxLength: 100, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        NGUONGOCDULIEU = c.String(maxLength: 255, unicode: false),
                        LOAIPHUONGPHAPDANHGIA = c.String(maxLength: 255, unicode: false),
                        PHUONGPHAPKIEMTRA = c.String(maxLength: 255, unicode: false),
                        KETLUANKIEMTRA = c.String(maxLength: 255, unicode: false),
                        MOTAKIEMTRA = c.String(maxLength: 255, unicode: false),
                        GIAITHICHKIEMTRA = c.String(maxLength: 255, unicode: false),
                        MLANDDATAID = c.String(maxLength: 36, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.MCHATLUONGID);
            
            CreateTable(
                "MPLIS21.MT_DONVI",
                c => new
                    {
                        DONVIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENLOAIDONVI = c.String(maxLength: 255, unicode: false),
                        TENDONVI = c.String(maxLength: 255, unicode: false),
                        DIACHI = c.String(maxLength: 255, unicode: false),
                        NGUOIDAIDIEN = c.String(maxLength: 255, unicode: false),
                        CHUCVU = c.String(maxLength: 100, unicode: false),
                        VAITRO = c.String(maxLength: 255, unicode: false),
                        EMAIL = c.String(maxLength: 255, unicode: false),
                        DIENTHOAI = c.String(maxLength: 50, unicode: false),
                        GHICHU = c.String(maxLength: 255, unicode: false),
                        MLANDDATAID = c.String(maxLength: 36, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.DONVIID);
            
            CreateTable(
                "MPLIS21.MT_GIOIHAN",
                c => new
                    {
                        GIOIHANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        LOAIGIOIHAN = c.String(maxLength: 255, unicode: false),
                        TENGIOIHAN = c.String(maxLength: 255, unicode: false),
                        GIOIHANDONG = c.String(maxLength: 255, unicode: false),
                        GIOIHANTAY = c.String(maxLength: 255, unicode: false),
                        GIOIHANNAM = c.String(maxLength: 255, unicode: false),
                        GIOIHANBAC = c.String(maxLength: 255, unicode: false),
                        GIOIHANKHAC = c.String(maxLength: 255, unicode: false),
                        MLANDDATAID = c.String(maxLength: 36, unicode: false),
                        MCHATLUONGID = c.String(maxLength: 36, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.GIOIHANID);
            
            CreateTable(
                "MPLIS21.MT_HEQUYCHIEU",
                c => new
                    {
                        HEQUYCHIEUID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENHEQUYCHIEU = c.String(maxLength: 100, unicode: false),
                        MAHEQUYCHIEU = c.String(maxLength: 100, unicode: false),
                        NGAYBANHANH = c.DateTime(),
                        MUICHIEU = c.String(maxLength: 100, unicode: false),
                        KINHTUYENTRUC = c.String(maxLength: 100, unicode: false),
                        MLANDDATAID = c.String(maxLength: 36, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.HEQUYCHIEUID);
            
            CreateTable(
                "MPLIS21.MT_LANDDATA",
                c => new
                    {
                        LANDDATAID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TRICHYEU = c.String(maxLength: 255, unicode: false),
                        NGAYNGHIEMTHU = c.DateTime(),
                        TOMTAT = c.String(maxLength: 255, unicode: false),
                        MUCDICH = c.String(maxLength: 255, unicode: false),
                        KIEUDULIEUKHONGGIAN = c.String(maxLength: 100, unicode: false),
                        HIENTRANG = c.String(maxLength: 100, unicode: false),
                        NGONNGU = c.String(maxLength: 100, unicode: false),
                        BANGMA = c.String(maxLength: 100, unicode: false),
                        CHUDE = c.String(maxLength: 255, unicode: false),
                        TENTUKHOA = c.String(maxLength: 255, unicode: false),
                        LOAITUKHOA = c.String(maxLength: 255, unicode: false),
                        TENTEPANH = c.String(maxLength: 255, unicode: false),
                        MOTATEPANH = c.String(maxLength: 255, unicode: false),
                        DINHDANGANH = c.String(maxLength: 50, unicode: false),
                        TYLEANH = c.String(maxLength: 50, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        FILEIDENTIFIER = c.String(maxLength: 36, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.LANDDATAID);
            
            CreateTable(
                "MPLIS21.MT_METADATA",
                c => new
                    {
                        METADATAID = c.String(nullable: false, maxLength: 36, unicode: false),
                        FILEIDENTIFIER = c.String(maxLength: 36, unicode: false),
                        NGONNGU = c.String(maxLength: 255, unicode: false),
                        BANGMAKYTU = c.String(maxLength: 100, unicode: false),
                        PARENTIDENTIFIER = c.String(maxLength: 36, unicode: false),
                        PHAMVIMOTA = c.String(maxLength: 100, unicode: false),
                        NGAYLAP = c.DateTime(),
                        DONVILAP = c.String(maxLength: 36, unicode: false),
                        TENCHUAN = c.String(maxLength: 255, unicode: false),
                        PHIENBAN = c.String(maxLength: 50, unicode: false),
                        XAID = c.String(maxLength: 36, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.METADATAID);
            
            CreateTable(
                "MPLIS21.MT_PHANPHOI",
                c => new
                    {
                        PHANPHOIID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENTEP = c.String(maxLength: 255, unicode: false),
                        PHIENBAN = c.String(maxLength: 36, unicode: false),
                        MOTA = c.String(maxLength: 255, unicode: false),
                        GHICHU = c.String(maxLength: 255, unicode: false),
                        DUONGDANPHANPHOI = c.String(maxLength: 255, unicode: false),
                        MLANDDATAID = c.String(maxLength: 36, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        UID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.PHANPHOIID);
            
            CreateTable(
                "MPLIS21.QH_BIEUBANG",
                c => new
                    {
                        BIEUBANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENBIEU = c.String(maxLength: 255, unicode: false),
                        TENCHITIET = c.String(maxLength: 1000, unicode: false),
                        NAM = c.Decimal(precision: 18, scale: 2),
                        QUYHOACHID = c.String(maxLength: 36, unicode: false),
                        CAPQUYHOACH = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BIEUBANGID);
            
            CreateTable(
                "MPLIS21.QH_BIEUBANGCAPHUYEN",
                c => new
                    {
                        BIEUBANGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENBIEU = c.String(maxLength: 255, unicode: false),
                        TENCHITIET = c.String(maxLength: 1000, unicode: false),
                        NAM = c.Decimal(precision: 18, scale: 2),
                        QUYHOACHCAPHUYENID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.BIEUBANGID);
            
            CreateTable(
                "MPLIS21.QH_CAPHUYEN",
                c => new
                    {
                        CAPHUYENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        VUNGQUYHOACHCAPHUYENID = c.String(maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 2, unicode: false),
                        MAHUYEN = c.String(maxLength: 3, unicode: false),
                        TENVUNGQUYHOACH = c.String(maxLength: 255, unicode: false),
                        MUCDICHSUDUNGQH = c.String(maxLength: 3, unicode: false),
                        NAMQUYHOACH = c.Decimal(precision: 18, scale: 2),
                        QUYHOACHCAPHUYENID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.CAPHUYENID);
            
            CreateTable(
                "MPLIS21.QH_CAPTINH",
                c => new
                    {
                        CAPTINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        VUNGQUYHOACHCAPTINHID = c.String(maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 2, unicode: false),
                        TENVUNGQUYHOACH = c.String(maxLength: 255, unicode: false),
                        MUCDICHSUDUNGQH = c.String(maxLength: 3, unicode: false),
                        NAMQUYHOACH = c.Decimal(precision: 18, scale: 2),
                        QUYHOACHCAPTINHID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.CAPTINHID);
            
            CreateTable(
                "MPLIS21.QH_DINHKEMKCNCAPHUYEN",
                c => new
                    {
                        DINHKEMKCNCAPHUYENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KHUCHUCNANGCAPHUYENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 500, unicode: false),
                        NGAYTAOFILE = c.DateTime(),
                        NGUOICAPHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        GHICHU = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.DINHKEMKCNCAPHUYENID)
                .ForeignKey("MPLIS21.QH_KHUCHUCNANGCAPHUYEN", t => t.KHUCHUCNANGCAPHUYENID, cascadeDelete: true)
                .Index(t => t.KHUCHUCNANGCAPHUYENID);
            
            CreateTable(
                "MPLIS21.QH_KHUCHUCNANGCAPHUYEN",
                c => new
                    {
                        KHUCHUCNANGCAPHUYENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 2, unicode: false),
                        MAHUYEN = c.String(maxLength: 3, unicode: false),
                        NAMTHANHLAP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TYLEBANDO = c.String(maxLength: 10, unicode: false),
                        NGUONTHANHLAP = c.String(maxLength: 30, unicode: false),
                        COQUANDUYET = c.String(maxLength: 50, unicode: false),
                        COQUANTHAMDINH = c.String(maxLength: 50, unicode: false),
                        COQUANLAP = c.String(maxLength: 50, unicode: false),
                        DONVITUVAN = c.String(maxLength: 50, unicode: false),
                        SOPHEDUYET = c.String(maxLength: 50, unicode: false),
                        NGAYPHEDUYET = c.DateTime(),
                        TENDUAN = c.String(maxLength: 255, unicode: false),
                        FILEBANDO = c.String(maxLength: 2000, unicode: false),
                    })
                .PrimaryKey(t => t.KHUCHUCNANGCAPHUYENID);
            
            CreateTable(
                "MPLIS21.QH_DINHKEMKCNCAPTINH",
                c => new
                    {
                        DINHKEMKCNCAPTINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        KHUCHUCNANGCAPTINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 500, unicode: false),
                        NGAYTAOFILE = c.DateTime(),
                        NGUOICAPHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        GHICHU = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.DINHKEMKCNCAPTINHID)
                .ForeignKey("MPLIS21.QH_KHUCHUCNANGCAPTINH", t => t.KHUCHUCNANGCAPTINHID, cascadeDelete: true)
                .Index(t => t.KHUCHUCNANGCAPTINHID);
            
            CreateTable(
                "MPLIS21.QH_KHUCHUCNANGCAPTINH",
                c => new
                    {
                        KHUCHUCNANGCAPTINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 2, unicode: false),
                        NAMTHANHLAP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TYLEBANDO = c.String(maxLength: 10, unicode: false),
                        NGUONTHANHLAP = c.String(maxLength: 30, unicode: false),
                        COQUANDUYET = c.String(maxLength: 50, unicode: false),
                        COQUANTHAMDINH = c.String(maxLength: 50, unicode: false),
                        COQUANLAP = c.String(maxLength: 50, unicode: false),
                        DONVITUVAN = c.String(maxLength: 50, unicode: false),
                        SOPHEDUYET = c.String(maxLength: 50, unicode: false),
                        NGAYPHEDUYET = c.DateTime(),
                        TENDUAN = c.String(maxLength: 255, unicode: false),
                        FILEBANDO = c.String(maxLength: 2000, unicode: false),
                    })
                .PrimaryKey(t => t.KHUCHUCNANGCAPTINHID);
            
            CreateTable(
                "MPLIS21.QH_DINHKEMQUYHOACHCAPHUYEN",
                c => new
                    {
                        DINHKEMQUYHOACHCAPHUYENID = c.String(nullable: false, maxLength: 100, unicode: false),
                        QUYHOACHCAPHUYENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 500, unicode: false),
                        NGAYTAOFILE = c.DateTime(),
                        NGUOICAPHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        GHICHU = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.DINHKEMQUYHOACHCAPHUYENID)
                .ForeignKey("MPLIS21.QH_QUYHOACHCAPHUYEN", t => t.QUYHOACHCAPHUYENID, cascadeDelete: true)
                .Index(t => t.QUYHOACHCAPHUYENID);
            
            CreateTable(
                "MPLIS21.QH_QUYHOACHCAPHUYEN",
                c => new
                    {
                        QUYHOACHCAPHUYENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 2, unicode: false),
                        MAHUYEN = c.String(maxLength: 3, unicode: false),
                        NAMTHANHLAP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TYLEBANDO = c.String(maxLength: 10, unicode: false),
                        NGUONTHANHLAP = c.String(maxLength: 30, unicode: false),
                        COQUANDUYET = c.String(maxLength: 50, unicode: false),
                        COQUANTHAMDINH = c.String(maxLength: 50, unicode: false),
                        COQUANLAP = c.String(maxLength: 50, unicode: false),
                        DONVITUVAN = c.String(maxLength: 50, unicode: false),
                        NGAYPHEDUYET = c.DateTime(),
                        TENKYQUYHOACH = c.String(maxLength: 255, unicode: false),
                        FILEBANDO = c.String(maxLength: 2000, unicode: false),
                        SOQUYETDINH = c.String(maxLength: 100, unicode: false),
                        FILEHIENTRANG = c.String(maxLength: 2000, unicode: false),
                        FILETHUYETMINH = c.String(maxLength: 2000, unicode: false),
                    })
                .PrimaryKey(t => t.QUYHOACHCAPHUYENID);
            
            CreateTable(
                "MPLIS21.QH_DINHKEMQUYHOACHCAPTINH",
                c => new
                    {
                        DINHKEMQUYHOACHCAPTINHID = c.String(nullable: false, maxLength: 100, unicode: false),
                        QUYHOACHCAPTINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 500, unicode: false),
                        NGAYTAOFILE = c.DateTime(),
                        NGUOICAPHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        GHICHU = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.DINHKEMQUYHOACHCAPTINHID)
                .ForeignKey("MPLIS21.QH_QUYHOACHCAPTINH", t => t.QUYHOACHCAPTINHID, cascadeDelete: true)
                .Index(t => t.QUYHOACHCAPTINHID);
            
            CreateTable(
                "MPLIS21.QH_QUYHOACHCAPTINH",
                c => new
                    {
                        QUYHOACHCAPTINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 2, unicode: false),
                        NAMTHANHLAP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TYLEBANDO = c.String(maxLength: 10, unicode: false),
                        NGUONTHANHLAP = c.String(maxLength: 30, unicode: false),
                        COQUANDUYET = c.String(maxLength: 50, unicode: false),
                        COQUANTHAMDINH = c.String(maxLength: 50, unicode: false),
                        COQUANLAP = c.String(maxLength: 50, unicode: false),
                        DONVITUVAN = c.String(maxLength: 50, unicode: false),
                        NGAYPHEDUYET = c.DateTime(),
                        TENKYQUYHOACH = c.String(maxLength: 255, unicode: false),
                        FILEBANDO = c.String(maxLength: 2000, unicode: false),
                        SOQUYETDINH = c.String(maxLength: 100, unicode: false),
                        FILEHIENTRANG = c.String(maxLength: 2000, unicode: false),
                        FILETHUYETMINH = c.String(maxLength: 2000, unicode: false),
                    })
                .PrimaryKey(t => t.QUYHOACHCAPTINHID);
            
            CreateTable(
                "MPLIS21.QH_DINHKEMQUYHOACHCAPTW",
                c => new
                    {
                        DINHKEMQUYHOACHCAPTWID = c.String(nullable: false, maxLength: 36, unicode: false),
                        QUYHOACHCAPTWID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 500, unicode: false),
                        NGAYTAOFILE = c.DateTime(),
                        NGUOICAPHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        GHICHU = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.DINHKEMQUYHOACHCAPTWID)
                .ForeignKey("MPLIS21.QH_QUYHOACHCAPTW", t => t.QUYHOACHCAPTWID, cascadeDelete: true)
                .Index(t => t.QUYHOACHCAPTWID);
            
            CreateTable(
                "MPLIS21.QH_QUYHOACHCAPTW",
                c => new
                    {
                        QUYHOACHCAPTWID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NAMTHANHLAP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TYLEBANDO = c.String(maxLength: 10, unicode: false),
                        NGUONTHANHLAP = c.String(maxLength: 30, unicode: false),
                        COQUANDUYET = c.String(maxLength: 50, unicode: false),
                        COQUANTHAMDINH = c.String(maxLength: 50, unicode: false),
                        COQUANLAP = c.String(maxLength: 50, unicode: false),
                        DONVITUVAN = c.String(maxLength: 50, unicode: false),
                        NGAYPHEDUYET = c.DateTime(),
                        TENKYQUYHOACH = c.String(maxLength: 255, unicode: false),
                        FILEBANDO = c.String(maxLength: 2000, unicode: false),
                        SOQUYETDINH = c.String(maxLength: 100, unicode: false),
                        FILEHIENTRANG = c.String(maxLength: 2000, unicode: false),
                        FILETHUYETMINH = c.String(maxLength: 2000, unicode: false),
                    })
                .PrimaryKey(t => t.QUYHOACHCAPTWID);
            
            CreateTable(
                "MPLIS21.QH_DINHKEMQUYHOACHQPAN",
                c => new
                    {
                        DINHKEMQUYHOACHQPANID = c.String(nullable: false, maxLength: 100, unicode: false),
                        QUYHOACHQPANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        TENFILE = c.String(maxLength: 500, unicode: false),
                        NGAYTAOFILE = c.DateTime(),
                        NGUOICAPHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                        GHICHU = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.DINHKEMQUYHOACHQPANID)
                .ForeignKey("MPLIS21.QH_QUYHOACHQPAN", t => t.QUYHOACHQPANID, cascadeDelete: true)
                .Index(t => t.QUYHOACHQPANID);
            
            CreateTable(
                "MPLIS21.QH_QUYHOACHQPAN",
                c => new
                    {
                        QUYHOACHQPANID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 2, unicode: false),
                        MAHUYEN = c.String(maxLength: 3, unicode: false),
                        NAMTHANHLAP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TYLEBANDO = c.String(maxLength: 10, unicode: false),
                        NGUONTHANHLAP = c.String(maxLength: 30, unicode: false),
                        COQUANDUYET = c.String(maxLength: 50, unicode: false),
                        COQUANTHAMDINH = c.String(maxLength: 50, unicode: false),
                        COQUANLAP = c.String(maxLength: 50, unicode: false),
                        DONVITUVAN = c.String(maxLength: 50, unicode: false),
                        NGAYPHEDUYET = c.DateTime(),
                        TENDUAN = c.String(maxLength: 255, unicode: false),
                        FILEBANDO = c.String(maxLength: 2000, unicode: false),
                    })
                .PrimaryKey(t => t.QUYHOACHQPANID);
            
            CreateTable(
                "MPLIS21.QH_KHUCHUCNANGCAPHUYENGEO",
                c => new
                    {
                        KHUCHUCNANGCAPHUYENID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 2, unicode: false),
                        MAHUYEN = c.String(maxLength: 3, unicode: false),
                        TENKHUCHUCNANG = c.String(maxLength: 255, unicode: false),
                        LOAIKHUCHUCNANGCAPHUYEN = c.String(maxLength: 3, unicode: false),
                        NAMQUYHOACH = c.Decimal(precision: 18, scale: 2),
                        QHCHUCNANGCAPHUYENID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.KHUCHUCNANGCAPHUYENID);
            
            CreateTable(
                "MPLIS21.QH_KHUCHUCNANGCAPTINHGEO",
                c => new
                    {
                        KHUCHUNANGCAPTINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 2, unicode: false),
                        TENKHUCHUCNANG = c.String(maxLength: 255, unicode: false),
                        LOAIKHUCHUCNANGCAPTINH = c.String(maxLength: 3, unicode: false),
                        NAMQUYHOACH = c.Decimal(precision: 18, scale: 2),
                        QHKHUCHUNANGCAPTINHID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.KHUCHUNANGCAPTINHID);
            
            CreateTable(
                "MPLIS21.QH_MDSD",
                c => new
                    {
                        MDSDID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MAMDSD = c.String(maxLength: 3, unicode: false),
                        DIENTICH = c.Decimal(precision: 18, scale: 2),
                        BIEUBANGID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.MDSDID);
            
            CreateTable(
                "MPLIS21.QH_MDSD_CT",
                c => new
                    {
                        MDSDCTID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MDSDID = c.String(maxLength: 36, unicode: false),
                        MAMDSD = c.String(maxLength: 3, unicode: false),
                        DIENTICH = c.Decimal(precision: 18, scale: 2),
                        BIEUBANGCAPTINHID = c.String(maxLength: 36, unicode: false),
                    })
                .PrimaryKey(t => t.MDSDCTID);
            
            CreateTable(
                "MPLIS21.QH_VUNGQUYHOACHCAPTINH",
                c => new
                    {
                        VUNGQUYHOACHCAPTINHID = c.String(nullable: false, maxLength: 36, unicode: false),
                        MATINH = c.String(maxLength: 2, unicode: false),
                        TENVUNGQUYHOACH = c.String(maxLength: 50, unicode: false),
                        MUCDICHSUDUNGQH = c.String(maxLength: 3, unicode: false),
                        NAMQUYHOACH = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.VUNGQUYHOACHCAPTINHID);
            
            CreateTable(
                "MPLIS21.QT_NGAYNGHI",
                c => new
                    {
                        NGAYNGHIID = c.String(nullable: false, maxLength: 100, unicode: false),
                        TENNGAYNGHI = c.String(maxLength: 255, unicode: false),
                        NGAYBATDAU = c.DateTime(),
                        NGAYKETTHUC = c.DateTime(),
                        LOAINGAY = c.String(maxLength: 1, unicode: false),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                        THOIDIEMKHOITAO = c.DateTime(),
                    })
                .PrimaryKey(t => t.NGAYNGHIID);
            
            CreateTable(
                "MPLIS21.LOAIHOSO_DONVIAPDUNG",
                c => new
                    {
                        LOAIHOSODONVIAPDUNGID = c.String(nullable: false, maxLength: 36, unicode: false),
                        NHOMNGUOIDUNGID = c.String(maxLength: 36, unicode: false),
                        LOAIHOSOID = c.String(maxLength: 36, unicode: false),
                        uId = c.String(maxLength: 36, unicode: false),
                        THOIDIEMKHOITAO = c.DateTime(),
                        NGUOICAPNHATID = c.String(maxLength: 36, unicode: false),
                        THOIDIEMCAPNHAT = c.DateTime(),
                    })
                .PrimaryKey(t => t.LOAIHOSODONVIAPDUNGID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("MPLIS21.QH_DINHKEMQUYHOACHQPAN", "QUYHOACHQPANID", "MPLIS21.QH_QUYHOACHQPAN");
            DropForeignKey("MPLIS21.QH_DINHKEMQUYHOACHCAPTW", "QUYHOACHCAPTWID", "MPLIS21.QH_QUYHOACHCAPTW");
            DropForeignKey("MPLIS21.QH_DINHKEMQUYHOACHCAPTINH", "QUYHOACHCAPTINHID", "MPLIS21.QH_QUYHOACHCAPTINH");
            DropForeignKey("MPLIS21.QH_DINHKEMQUYHOACHCAPHUYEN", "QUYHOACHCAPHUYENID", "MPLIS21.QH_QUYHOACHCAPHUYEN");
            DropForeignKey("MPLIS21.QH_DINHKEMKCNCAPTINH", "KHUCHUCNANGCAPTINHID", "MPLIS21.QH_KHUCHUCNANGCAPTINH");
            DropForeignKey("MPLIS21.QH_DINHKEMKCNCAPHUYEN", "KHUCHUCNANGCAPHUYENID", "MPLIS21.QH_KHUCHUCNANGCAPHUYEN");
            DropForeignKey("MPLIS21.GD_BANGGIADAT", "QDGIADATID", "MPLIS21.GD_QDGIADAT");
            DropForeignKey("MPLIS21.DC_NHOMNGUOI_THANHVIEN", "NHOMNGUOIID", "MPLIS21.DC_NHOMNGUOI");
            DropForeignKey("MPLIS21.DC_NHARIENGLE", "LOAINHAID", "MPLIS21.DM_LOAINHA");
            DropForeignKey("MPLIS21.DC_NHARIENGLE", "LOAICAPHANGID", "MPLIS21.DM_LOAICAPHANG");
            DropForeignKey("MPLIS21.DC_HOGIADINH_THANHVIEN", "QHVOICHUHOID", "MPLIS21.DM_QHVOICHUHO");
            DropForeignKey("MPLIS21.DC_HANCHE", "LOAIHANCHEID", "MPLIS21.DC_LOAIHANCHE");
            DropForeignKey("MPLIS21.DC_HANGMUCCONGTRINH", "CONGTRINHXAYDUNGID", "MPLIS21.DC_CONGTRINHXAYDUNG");
            DropForeignKey("MPLIS21.DC_CHITIETCONGKHAI", "DANHSACHCONGKHAIID", "MPLIS21.DC_DANHSACHCONGKHAI");
            DropForeignKey("MPLIS21.DC_DONKIENNGHI", "DANHSACHCONGKHAIID", "MPLIS21.DC_DANHSACHCONGKHAI");
            DropForeignKey("MPLIS21.DC_CANHO", "NHACHUNGCUID", "MPLIS21.DC_NHACHUNGCU");
            DropForeignKey("MPLIS21.DC_CANHO_HANGMUCNCH", "HANGMUCSOHUUCHUNGID", "MPLIS21.DC_HANGMUCNGOAICANHO");
            DropForeignKey("MPLIS21.DC_HANGMUCNGOAICANHO", "NHACHUNGCUID", "MPLIS21.DC_NHACHUNGCU");
            DropForeignKey("MPLIS21.DC_NHACHUNGCU", "KHUCHUNGCUID", "MPLIS21.DC_KHUCHUNGCU");
            DropForeignKey("MPLIS21.DC_CANHO_HANGMUCNCH", "CANHOID", "MPLIS21.DC_CANHO");
            DropForeignKey("MPLIS21.DC_CANHAN", "QUOCTICHID", "MPLIS21.DM_QUOCTICH");
            DropForeignKey("MPLIS21.DC_CANHAN", "DANTOCID", "MPLIS21.DM_DANTOC");
            DropForeignKey("MPLIS21.CS_CHUKYSO", "TOCHUCID", "MPLIS21.HT_TOCHUC");
            DropForeignKey("MPLIS21.CS_CHUKYSO", "NGUOIDUNGID", "MPLIS21.HT_NGUOIDUNG");
            DropForeignKey("MPLIS21.HT_NGUOIDUNG_QUYEN", "QUYENID", "MPLIS21.HT_QUYEN");
            DropForeignKey("MPLIS21.HT_QUYEN", "CHUCNANGID", "MPLIS21.HT_CHUCNANG");
            DropForeignKey("MPLIS21.HT_CHUCNANG", "KHOACHAID", "MPLIS21.HT_CHUCNANG");
            DropForeignKey("MPLIS21.HT_CHUCNANG_NHOMCHUCNANG", "NHOMCHUCNANGID", "MPLIS21.HT_NHOMCHUCNANG");
            DropForeignKey("MPLIS21.HT_NHOMCHUCNANG", "UNGDUNGID", "MPLIS21.HT_UNGDUNG");
            DropForeignKey("MPLIS21.HT_TOCHUC_NHOMCHUCNANG", "TOCHUCID", "MPLIS21.HT_TOCHUC");
            DropForeignKey("MPLIS21.HT_TOCHUC", "HT_TOCHUC2_TOCHUCID", "MPLIS21.HT_TOCHUC");
            DropForeignKey("MPLIS21.HT_TOCHUC_NGUOIDUNG", "TOCHUCID", "MPLIS21.HT_TOCHUC");
            DropForeignKey("MPLIS21.HT_TOCHUC_NGUOIDUNG", "NGUOIDUNGID", "MPLIS21.HT_NGUOIDUNG");
            DropForeignKey("MPLIS21.DC_GIAYCHUNGNHAN", "CHUKYSOID", "MPLIS21.HT_TOCHUC");
            DropForeignKey("MPLIS21.DC_GIAYCHUNGNHAN", "NGUOIID", "MPLIS21.DC_NGUOI");
            DropForeignKey("MPLIS21.DC_BD_GCN_GCN", "GCNCHAID", "MPLIS21.DC_GIAYCHUNGNHAN");
            DropForeignKey("MPLIS21.DC_BD_GCN_GCN", "GIAYCHUNGNHANID", "MPLIS21.DC_GIAYCHUNGNHAN");
            DropForeignKey("MPLIS21.DC_BD_GCN", "GIAYCHUNGNHANID", "MPLIS21.DC_GIAYCHUNGNHAN");
            DropForeignKey("MPLIS21.DC_BD_GCN", "BIENDONGID", "MPLIS21.DC_BIENDONG");
            DropForeignKey("MPLIS21.LS_TC_THUA", "BOHOSOID", "MPLIS21.LS_BOHOSO");
            DropForeignKey("MPLIS21.LS_TC_HOSO", "BOHOSOID", "MPLIS21.LS_BOHOSO");
            DropForeignKey("MPLIS21.LS_TC_GCN", "BOHOSOID", "MPLIS21.LS_BOHOSO");
            DropForeignKey("MPLIS21.LS_TC_CHU", "BOHOSOID", "MPLIS21.LS_BOHOSO");
            DropForeignKey("MPLIS21.LS_BOHOSO", "BIENDONGID", "MPLIS21.DC_BIENDONG");
            DropForeignKey("MPLIS21.LS_BD_THUA", "BIENDONGID", "MPLIS21.DC_BIENDONG");
            DropForeignKey("MPLIS21.LS_BD_GCN", "BIENDONGID", "MPLIS21.DC_BIENDONG");
            DropForeignKey("MPLIS21.DC_BIENDONG", "NOICONGCHUNGID", "MPLIS21.DC_NOICONGCHUNG");
            DropForeignKey("MPLIS21.DC_BIENDONG", "LOAIBIENDONGID", "MPLIS21.DC_LOAIBIENDONG");
            DropForeignKey("MPLIS21.DC_BD_TREN_GCN", "GIAYCHUNGNHANID", "MPLIS21.DC_GIAYCHUNGNHAN");
            DropForeignKey("MPLIS21.DC_BD_TREN_GCN", "BIENDONGID", "MPLIS21.DC_BIENDONG");
            DropForeignKey("MPLIS21.DC_BD_CHU", "NGUOIID", "MPLIS21.DC_NGUOI");
            DropForeignKey("MPLIS21.DC_NGUOI", "DOITUONGSUDUNGID", "MPLIS21.DM_DOITUONGSUDUNG");
            DropForeignKey("MPLIS21.DC_NGUOI_DIACHI", "NGUOIID", "MPLIS21.DC_NGUOI");
            DropForeignKey("MPLIS21.DC_NGUOI_DIACHI", "DIACHIID", "MPLIS21.DC_DIACHI");
            DropForeignKey("MPLIS21.DC_TAISAN_DIACHI", "TAISANGANLIENVOIDATID", "MPLIS21.DC_TAISANGANLIENVOIDAT");
            DropForeignKey("MPLIS21.DC_THUATAISAN", "THUADATID", "MPLIS21.DC_THUADAT");
            DropForeignKey("MPLIS21.DC_THUADAT", "KVHCID", "MPLIS21.HC_DMKVHC");
            DropForeignKey("MPLIS21.GD_GIATHUADAT", "LOAIGIADATID", "MPLIS21.GD_DMLOAIGIADAT");
            DropForeignKey("MPLIS21.GD_GIATHUADAT", "THUADATID", "MPLIS21.DC_THUADAT");
            DropForeignKey("MPLIS21.DC_TRANHCHAP", "THUADATID", "MPLIS21.DC_THUADAT");
            DropForeignKey("MPLIS21.DC_THUADAT_TAISAN", "THUADATID", "MPLIS21.DC_THUADAT");
            DropForeignKey("MPLIS21.DC_THUADAT", "TAILIEUDODACID", "MPLIS21.DC_TAILIEUDODAC");
            DropForeignKey("MPLIS21.DC_THUADAT", "KHUVUCID", "MPLIS21.DC_KHUVUC");
            DropForeignKey("MPLIS21.DC_KHUVUC", "KVHCID", "MPLIS21.HC_DMKVHC");
            DropForeignKey("MPLIS21.HT_XA_TOCHUC", "TOCHUCID", "MPLIS21.HT_TOCHUC");
            DropForeignKey("MPLIS21.HT_XA_TOCHUC", "KVHCID", "MPLIS21.HC_DMKVHC");
            DropForeignKey("MPLIS21.HT_XA_NGUOIDUNG", "NGUOIDUNGID", "MPLIS21.HT_NGUOIDUNG");
            DropForeignKey("MPLIS21.HT_XA_NGUOIDUNG", "KVHCID", "MPLIS21.HC_DMKVHC");
            DropForeignKey("MPLIS21.HS_HOSO", "HOSOTIEPNHANID", "MPLIS21.QT_HOSOTIEPNHAN");
            DropForeignKey("MPLIS21.QT_HOSOTIEPNHAN", "THUTUCHANHCHINHID", "MPLIS21.QT_THUTUCHANHCHINH");
            DropForeignKey("MPLIS21.QT_FILEDINHKEMHOSO", "HOSOTIEPNHANID", "MPLIS21.QT_HOSOTIEPNHAN");
            DropForeignKey("MPLIS21.QT_FILEDINHKEMHOSO", "GIAYTOTHEOTTHCID", "MPLIS21.QT_GIAYTOTHEOTTHC");
            DropForeignKey("MPLIS21.QT_GIAYTOTHEOTTHC", "THUTUCHANHCHINHID", "MPLIS21.QT_THUTUCHANHCHINH");
            DropForeignKey("MPLIS21.QT_TTHC_QUYTRINH", "THUTUCHANHCHINHID", "MPLIS21.QT_THUTUCHANHCHINH");
            DropForeignKey("MPLIS21.QT_TTHC_QUYTRINH", "QUYTRINHID", "MPLIS21.QT_QUYTRINH");
            DropForeignKey("MPLIS21.QT_QUYTRINH", "NHOMQUYTRINHID", "MPLIS21.QT_NHOMQUYTRINH");
            DropForeignKey("MPLIS21.QT_BUOCQUYTRINH", "QUYTRINHID", "MPLIS21.QT_QUYTRINH");
            DropForeignKey("MPLIS21.QT_CONGVIECTHUCHIEN", "LUANCHUYENHOSOID", "MPLIS21.QT_LUANCHUYEN_HOSO");
            DropForeignKey("MPLIS21.QT_LUANCHUYEN_HOSO", "QUYTRINHID", "MPLIS21.QT_QUYTRINH");
            DropForeignKey("MPLIS21.QT_LUANCHUYEN_HOSO", "HOSOTIEPNHANID", "MPLIS21.QT_HOSOTIEPNHAN");
            DropForeignKey("MPLIS21.QT_LUANCHUYEN_HOSO", "HOSOXULYID", "MPLIS21.QT_HOSO_LANXULY");
            DropForeignKey("MPLIS21.QT_HOSO_LANXULY", "QUYTRINHID", "MPLIS21.QT_QUYTRINH");
            DropForeignKey("MPLIS21.QT_HOSO_LANXULY", "HOSOTIEPNHANID", "MPLIS21.QT_HOSOTIEPNHAN");
            DropForeignKey("MPLIS21.QT_GHICHUXULY", "QUYTRINHID", "MPLIS21.QT_QUYTRINH");
            DropForeignKey("MPLIS21.QT_GHICHUXULY", "HOSOTIEPNHANID", "MPLIS21.QT_HOSOTIEPNHAN");
            DropForeignKey("MPLIS21.QT_GHICHUXULY", "HOSOXULYID", "MPLIS21.QT_HOSO_LANXULY");
            DropForeignKey("MPLIS21.QT_GHICHUXULY", "BUOCQUYTRINHID", "MPLIS21.QT_BUOCQUYTRINH");
            DropForeignKey("MPLIS21.QT_GHICHUXULY", "NGUOIDUNGID", "MPLIS21.HT_NGUOIDUNG");
            DropForeignKey("MPLIS21.QT_LUANCHUYEN_HOSO", "BUOCQUYTRINHID", "MPLIS21.QT_BUOCQUYTRINH");
            DropForeignKey("MPLIS21.QT_LUANCHUYEN_HOSO", "NGUOIDUNGID", "MPLIS21.HT_NGUOIDUNG");
            DropForeignKey("MPLIS21.QT_CONGVIECTHUCHIEN", "CONGVIECTHEOBUOCID", "MPLIS21.QT_CONGVIECTHEOBUOC");
            DropForeignKey("MPLIS21.QT_CONGVIECTHEOBUOC", "BUOCQUYTRINHID", "MPLIS21.QT_BUOCQUYTRINH");
            DropForeignKey("MPLIS21.QT_BUOCQT_CAUHINH", "BUOCQUYTRINHID", "MPLIS21.QT_BUOCQUYTRINH");
            DropForeignKey("MPLIS21.QT_BUOCQT_CAUHINH", "NGUOIDUNGID", "MPLIS21.HT_NGUOIDUNG");
            DropForeignKey("MPLIS21.QT_BUOCQT_CAUHINH", "KVHCID", "MPLIS21.HC_DMKVHC");
            DropForeignKey("MPLIS21.QT_THUTUCHANHCHINH", "TOCHUCID", "MPLIS21.HT_TOCHUC");
            DropForeignKey("MPLIS21.QT_THUTUCHANHCHINH", "BOTHUTUCHANHCHINHID", "MPLIS21.DM_BOTHUTUCHANHCHINH");
            DropForeignKey("MPLIS21.QT_HOSOTIEPNHAN", "TOCHUCID", "MPLIS21.HT_TOCHUC");
            DropForeignKey("MPLIS21.HS_THANHPHANHOSO", "HOSOID", "MPLIS21.HS_HOSO");
            DropForeignKey("MPLIS21.HS_TC_GCN", "HOSOID", "MPLIS21.HS_HOSO");
            DropForeignKey("MPLIS21.HS_TC_CHU", "HOSOID", "MPLIS21.HS_HOSO");
            DropForeignKey("MPLIS21.HS_LIENKETTHUADAT", "HOSOID", "MPLIS21.HS_HOSO");
            DropForeignKey("MPLIS21.HS_LIENKETTHUADAT", "KVHCID", "MPLIS21.HC_DMKVHC");
            DropForeignKey("MPLIS21.HS_LICHSU", "HOSOID", "MPLIS21.HS_HOSO");
            DropForeignKey("MPLIS21.HS_LICHSU", "KVHCID", "MPLIS21.HC_DMKVHC");
            DropForeignKey("MPLIS21.HS_HOSO", "KVHCID", "MPLIS21.HC_DMKVHC");
            DropForeignKey("MPLIS21.HC_DMKVHC", "HUYENID", "MPLIS21.HC_HUYEN");
            DropForeignKey("MPLIS21.HC_HUYEN", "TINHID", "MPLIS21.HC_TINH");
            DropForeignKey("MPLIS21.HC_TINHTHAMSO", "TINHID", "MPLIS21.HC_TINH");
            DropForeignKey("MPLIS21.DC_TAILIEUDODAC", "KVHCID", "MPLIS21.HC_DMKVHC");
            DropForeignKey("MPLIS21.DC_TAILIEUDODAC", "LOAIBANDODIACHINHID", "MPLIS21.DM_LOAIBANDODIACHINH");
            DropForeignKey("MPLIS21.DC_THUADAT_TAILIEUDODAC", "THUADATID", "MPLIS21.DC_THUADAT");
            DropForeignKey("MPLIS21.DC_THUADAT_TAILIEUDODAC", "TAILIEUDODACID", "MPLIS21.DC_TAILIEUDODAC");
            DropForeignKey("MPLIS21.DC_THUADAT", "DOANDUONGID", "MPLIS21.DC_DOANDUONG");
            DropForeignKey("MPLIS21.DC_BD_THUA_THUA", "THUACHAID", "MPLIS21.DC_THUADAT");
            DropForeignKey("MPLIS21.DC_BD_THUA_THUA", "THUADATID", "MPLIS21.DC_THUADAT");
            DropForeignKey("MPLIS21.DC_BD_THUA", "THUADATID", "MPLIS21.DC_THUADAT");
            DropForeignKey("MPLIS21.DC_BD_THUA", "BIENDONGID", "MPLIS21.DC_BIENDONG");
            DropForeignKey("MPLIS21.DC_THUATAISAN", "TAISANGANLIENVOIDATID", "MPLIS21.DC_TAISANGANLIENVOIDAT");
            DropForeignKey("MPLIS21.DC_QUYENSOHUUTAISAN", "TAISANGANLIENVOIDATID", "MPLIS21.DC_TAISANGANLIENVOIDAT");
            DropForeignKey("MPLIS21.DC_QUYENSOHUUTAISAN", "NGUOIID", "MPLIS21.DC_NGUOI");
            DropForeignKey("MPLIS21.DC_QUYENSOHUUTAISAN", "GIAYCHUNGNHANID", "MPLIS21.DC_GIAYCHUNGNHAN");
            DropForeignKey("MPLIS21.DC_QUYENSOHUUTAISAN", "BDTHECHAPID", "MPLIS21.DC_BD_THECHAP");
            DropForeignKey("MPLIS21.DC_QUYENQUANLYDAT", "NGUOIID", "MPLIS21.DC_NGUOI");
            DropForeignKey("MPLIS21.DC_QUYENQUANLYDAT", "MUCDICHSUDUNGID", "MPLIS21.DC_MUCDICHSUDUNGDAT");
            DropForeignKey("MPLIS21.DC_MUCDICHSUDUNGDAT", "MUCDICHSUDUNGQHID", "MPLIS21.DM_MUCDICHSUDUNGQH");
            DropForeignKey("MPLIS21.DC_MUCDICHSUDUNGDAT", "MUCDICHSUDUNGID", "MPLIS21.DM_MUCDICHSUDUNG");
            DropForeignKey("MPLIS21.DC_THUEDAT", "MUCDICHSUDUNGID", "MPLIS21.DM_MUCDICHSUDUNG");
            DropForeignKey("MPLIS21.DC_THUEDAT", "BIENDONGID", "MPLIS21.DC_BIENDONG");
            DropForeignKey("MPLIS21.DC_BD_CHUYENMDSDD", "MUCDICHSUDUNGID", "MPLIS21.DM_MUCDICHSUDUNG");
            DropForeignKey("MPLIS21.DC_BD_CHUYENMDSDD", "BIENDONGID", "MPLIS21.DC_BIENDONG");
            DropForeignKey("MPLIS21.DC_MUCDICHSUDUNGDAT", "HINHTHUCSUDUNGID", "MPLIS21.DM_HINHTHUCSUDUNGDAT");
            DropForeignKey("MPLIS21.DC_BD_CHUYENHTSDD", "HINHTHUCSUDUNGID", "MPLIS21.DM_HINHTHUCSUDUNGDAT");
            DropForeignKey("MPLIS21.DC_BD_CHUYENHTSDD", "BIENDONGID", "MPLIS21.DC_BIENDONG");
            DropForeignKey("MPLIS21.DC_VITRITHUADAT", "MUCDICHSUDUNGDATID", "MPLIS21.DC_MUCDICHSUDUNGDAT");
            DropForeignKey("MPLIS21.DC_QUYENSUDUNGDAT", "NGUOIID", "MPLIS21.DC_NGUOI");
            DropForeignKey("MPLIS21.DC_QUYENSUDUNGDAT", "MUCDICHSUDUNGDATID", "MPLIS21.DC_MUCDICHSUDUNGDAT");
            DropForeignKey("MPLIS21.DC_QUYENSUDUNGDAT", "BDTHECHAPID", "MPLIS21.DC_BD_THECHAP");
            DropForeignKey("MPLIS21.DC_NGUONGOCSUDUNG", "LOAINGUONGOCSUDUNGID", "MPLIS21.DM_LOAINGUONGOCSUDUNG");
            DropForeignKey("MPLIS21.DC_NGUONGOCSUDUNG", "MUCDICHSUDUNGDATID", "MPLIS21.DC_MUCDICHSUDUNGDAT");
            DropForeignKey("MPLIS21.DC_QUYENQUANLYDAT", "GIAYCHUNGNHANID", "MPLIS21.DC_GIAYCHUNGNHAN");
            DropForeignKey("MPLIS21.DC_QUYENQUANLYDAT", "BDTHECHAPID", "MPLIS21.DC_BD_THECHAP");
            DropForeignKey("MPLIS21.DC_BD_THECHAP", "BIENDONGID", "MPLIS21.DC_BIENDONG");
            DropForeignKey("MPLIS21.DC_TAISAN_DIACHI", "DIACHIID", "MPLIS21.DC_DIACHI");
            DropForeignKey("MPLIS21.DC_GCN_TILESH", "LOAIDTMIENGIAMID", "MPLIS21.DM_LOAIDTMIENGIAM");
            DropForeignKey("MPLIS21.DC_MIENGIAMNVTC", "LOAINGHIAVUTAICHINHID", "MPLIS21.DM_LOAINGHIAVUTAICHINH");
            DropForeignKey("MPLIS21.DC_MIENGIAMNVTC", "LOAIDTMIENGIAMID", "MPLIS21.DM_LOAIDTMIENGIAM");
            DropForeignKey("MPLIS21.DC_MIENGIAMNVTC", "NGUOIID", "MPLIS21.DC_NGUOI");
            DropForeignKey("MPLIS21.DC_MIENGIAMNVTC", "NGHIAVUTAICHINHID", "MPLIS21.DC_NGHIAVUTAICHINH");
            DropForeignKey("MPLIS21.DC_NONVTC", "LOAINGHIAVUTAICHINHID", "MPLIS21.DM_LOAINGHIAVUTAICHINH");
            DropForeignKey("MPLIS21.DC_NONVTC", "NGUOIID", "MPLIS21.DC_NGUOI");
            DropForeignKey("MPLIS21.DC_NONVTC", "NGHIAVUTAICHINHID", "MPLIS21.DC_NGHIAVUTAICHINH");
            DropForeignKey("MPLIS21.DC_NGHIAVUTAICHINH", "LOAINGHIAVUTAICHINHID", "MPLIS21.DC_LOAINGHIAVUTAICHINH");
            DropForeignKey("MPLIS21.DC_KHOANDUOCTRU", "NGUOIID", "MPLIS21.DC_NGUOI");
            DropForeignKey("MPLIS21.DC_KHOANDUOCTRU", "NGHIAVUTAICHINHID", "MPLIS21.DC_NGHIAVUTAICHINH");
            DropForeignKey("MPLIS21.DC_GTKEMTHEO", "NGHIAVUTAICHINHID", "MPLIS21.DC_NGHIAVUTAICHINH");
            DropForeignKey("MPLIS21.DC_GCN_TILESH", "NGUOIID", "MPLIS21.DC_NGUOI");
            DropForeignKey("MPLIS21.DC_GCN_TILESH", "GIAYCHUNGNHANID", "MPLIS21.DC_GIAYCHUNGNHAN");
            DropForeignKey("MPLIS21.DC_DANGKY_NGUOI", "NGUOIID", "MPLIS21.DC_NGUOI");
            DropForeignKey("MPLIS21.DC_DANGKY_NGUOI", "DONDANGKYID", "MPLIS21.DC_DONDANGKY");
            DropForeignKey("MPLIS21.DC_YKIENXACNHAN", "XACNHANDONDANGKYID", "MPLIS21.DC_XACNHANDONDANGKY");
            DropForeignKey("MPLIS21.DC_XACNHANDONDANGKY", "DONDANGKYID", "MPLIS21.DC_DONDANGKY");
            DropForeignKey("MPLIS21.DC_DANGKY_THUA", "DONDANGKYID", "MPLIS21.DC_DONDANGKY");
            DropForeignKey("MPLIS21.DC_DANGKY_GCN", "GIAYCHUNGNHANID", "MPLIS21.DC_GIAYCHUNGNHAN");
            DropForeignKey("MPLIS21.DC_DANGKY_GCN", "DONDANGKYID", "MPLIS21.DC_DONDANGKY");
            DropForeignKey("MPLIS21.DC_BD_CHU", "BIENDONGID", "MPLIS21.DC_BIENDONG");
            DropForeignKey("MPLIS21.HT_TOCHUC_NHOMCHUCNANG", "NHOMCHUCNANGID", "MPLIS21.HT_NHOMCHUCNANG");
            DropForeignKey("MPLIS21.HT_NHOMCHUCNANG_MENU", "NHOMCHUCNANGID", "MPLIS21.HT_NHOMCHUCNANG");
            DropForeignKey("MPLIS21.HT_NHOMCHUCNANG_MENU", "MENUID", "MPLIS21.HT_MENU");
            DropForeignKey("MPLIS21.HT_MENU", "KHOACHAID", "MPLIS21.HT_MENU");
            DropForeignKey("MPLIS21.HT_CHUCNANG_NHOMCHUCNANG", "CHUCNANGID", "MPLIS21.HT_CHUCNANG");
            DropForeignKey("MPLIS21.HT_NGUOIDUNG_QUYEN", "NGUOIDUNGID", "MPLIS21.HT_NGUOIDUNG");
            DropForeignKey("MPLIS21.HT_LICHSUTRUYCAP", "NGUOIDUNGID", "MPLIS21.HT_NGUOIDUNG");
            DropForeignKey("MPLIS21.HT_CAUHINHNGUOIDUNG", "NGUOIDUNGID", "MPLIS21.HT_NGUOIDUNG");
            DropForeignKey("MPLIS21.CS_CHUKYSO", "NHACUNGCAPID", "MPLIS21.CS_NHACUNGCAP");
            DropForeignKey("MPLIS21.CS_LICHSUGIAHAN", "CHUKYSOID", "MPLIS21.CS_CHUKYSO");
            DropForeignKey("MPLIS21.CS_GIAYTOXACMINH", "CHUKYSOID", "MPLIS21.CS_CHUKYSO");
            DropIndex("MPLIS21.QH_DINHKEMQUYHOACHQPAN", new[] { "QUYHOACHQPANID" });
            DropIndex("MPLIS21.QH_DINHKEMQUYHOACHCAPTW", new[] { "QUYHOACHCAPTWID" });
            DropIndex("MPLIS21.QH_DINHKEMQUYHOACHCAPTINH", new[] { "QUYHOACHCAPTINHID" });
            DropIndex("MPLIS21.QH_DINHKEMQUYHOACHCAPHUYEN", new[] { "QUYHOACHCAPHUYENID" });
            DropIndex("MPLIS21.QH_DINHKEMKCNCAPTINH", new[] { "KHUCHUCNANGCAPTINHID" });
            DropIndex("MPLIS21.QH_DINHKEMKCNCAPHUYEN", new[] { "KHUCHUCNANGCAPHUYENID" });
            DropIndex("MPLIS21.GD_BANGGIADAT", new[] { "QDGIADATID" });
            DropIndex("MPLIS21.DC_NHOMNGUOI_THANHVIEN", new[] { "NHOMNGUOIID" });
            DropIndex("MPLIS21.DC_NHARIENGLE", new[] { "LOAINHAID" });
            DropIndex("MPLIS21.DC_NHARIENGLE", new[] { "LOAICAPHANGID" });
            DropIndex("MPLIS21.DC_HOGIADINH_THANHVIEN", new[] { "QHVOICHUHOID" });
            DropIndex("MPLIS21.DC_HANCHE", new[] { "LOAIHANCHEID" });
            DropIndex("MPLIS21.DC_HANGMUCCONGTRINH", new[] { "CONGTRINHXAYDUNGID" });
            DropIndex("MPLIS21.DC_CHITIETCONGKHAI", new[] { "DANHSACHCONGKHAIID" });
            DropIndex("MPLIS21.DC_DONKIENNGHI", new[] { "DANHSACHCONGKHAIID" });
            DropIndex("MPLIS21.DC_CANHO", new[] { "NHACHUNGCUID" });
            DropIndex("MPLIS21.DC_CANHO_HANGMUCNCH", new[] { "HANGMUCSOHUUCHUNGID" });
            DropIndex("MPLIS21.DC_HANGMUCNGOAICANHO", new[] { "NHACHUNGCUID" });
            DropIndex("MPLIS21.DC_NHACHUNGCU", new[] { "KHUCHUNGCUID" });
            DropIndex("MPLIS21.DC_CANHO_HANGMUCNCH", new[] { "CANHOID" });
            DropIndex("MPLIS21.DC_CANHAN", new[] { "QUOCTICHID" });
            DropIndex("MPLIS21.DC_CANHAN", new[] { "DANTOCID" });
            DropIndex("MPLIS21.CS_CHUKYSO", new[] { "TOCHUCID" });
            DropIndex("MPLIS21.CS_CHUKYSO", new[] { "NGUOIDUNGID" });
            DropIndex("MPLIS21.HT_NGUOIDUNG_QUYEN", new[] { "QUYENID" });
            DropIndex("MPLIS21.HT_QUYEN", new[] { "CHUCNANGID" });
            DropIndex("MPLIS21.HT_CHUCNANG", new[] { "KHOACHAID" });
            DropIndex("MPLIS21.HT_CHUCNANG_NHOMCHUCNANG", new[] { "NHOMCHUCNANGID" });
            DropIndex("MPLIS21.HT_NHOMCHUCNANG", new[] { "UNGDUNGID" });
            DropIndex("MPLIS21.HT_TOCHUC_NHOMCHUCNANG", new[] { "TOCHUCID" });
            DropIndex("MPLIS21.HT_TOCHUC", new[] { "HT_TOCHUC2_TOCHUCID" });
            DropIndex("MPLIS21.HT_TOCHUC_NGUOIDUNG", new[] { "TOCHUCID" });
            DropIndex("MPLIS21.HT_TOCHUC_NGUOIDUNG", new[] { "NGUOIDUNGID" });
            DropIndex("MPLIS21.DC_GIAYCHUNGNHAN", new[] { "CHUKYSOID" });
            DropIndex("MPLIS21.DC_GIAYCHUNGNHAN", new[] { "NGUOIID" });
            DropIndex("MPLIS21.DC_BD_GCN_GCN", new[] { "GCNCHAID" });
            DropIndex("MPLIS21.DC_BD_GCN_GCN", new[] { "GIAYCHUNGNHANID" });
            DropIndex("MPLIS21.DC_BD_GCN", new[] { "GIAYCHUNGNHANID" });
            DropIndex("MPLIS21.DC_BD_GCN", new[] { "BIENDONGID" });
            DropIndex("MPLIS21.LS_TC_THUA", new[] { "BOHOSOID" });
            DropIndex("MPLIS21.LS_TC_HOSO", new[] { "BOHOSOID" });
            DropIndex("MPLIS21.LS_TC_GCN", new[] { "BOHOSOID" });
            DropIndex("MPLIS21.LS_TC_CHU", new[] { "BOHOSOID" });
            DropIndex("MPLIS21.LS_BOHOSO", new[] { "BIENDONGID" });
            DropIndex("MPLIS21.LS_BD_THUA", new[] { "BIENDONGID" });
            DropIndex("MPLIS21.LS_BD_GCN", new[] { "BIENDONGID" });
            DropIndex("MPLIS21.DC_BIENDONG", new[] { "NOICONGCHUNGID" });
            DropIndex("MPLIS21.DC_BIENDONG", new[] { "LOAIBIENDONGID" });
            DropIndex("MPLIS21.DC_BD_TREN_GCN", new[] { "GIAYCHUNGNHANID" });
            DropIndex("MPLIS21.DC_BD_TREN_GCN", new[] { "BIENDONGID" });
            DropIndex("MPLIS21.DC_BD_CHU", new[] { "NGUOIID" });
            DropIndex("MPLIS21.DC_NGUOI", new[] { "DOITUONGSUDUNGID" });
            DropIndex("MPLIS21.DC_NGUOI_DIACHI", new[] { "NGUOIID" });
            DropIndex("MPLIS21.DC_NGUOI_DIACHI", new[] { "DIACHIID" });
            DropIndex("MPLIS21.DC_TAISAN_DIACHI", new[] { "TAISANGANLIENVOIDATID" });
            DropIndex("MPLIS21.DC_THUATAISAN", new[] { "THUADATID" });
            DropIndex("MPLIS21.DC_THUADAT", new[] { "KVHCID" });
            DropIndex("MPLIS21.GD_GIATHUADAT", new[] { "LOAIGIADATID" });
            DropIndex("MPLIS21.GD_GIATHUADAT", new[] { "THUADATID" });
            DropIndex("MPLIS21.DC_TRANHCHAP", new[] { "THUADATID" });
            DropIndex("MPLIS21.DC_THUADAT_TAISAN", new[] { "THUADATID" });
            DropIndex("MPLIS21.DC_THUADAT", new[] { "TAILIEUDODACID" });
            DropIndex("MPLIS21.DC_THUADAT", new[] { "KHUVUCID" });
            DropIndex("MPLIS21.DC_KHUVUC", new[] { "KVHCID" });
            DropIndex("MPLIS21.HT_XA_TOCHUC", new[] { "TOCHUCID" });
            DropIndex("MPLIS21.HT_XA_TOCHUC", new[] { "KVHCID" });
            DropIndex("MPLIS21.HT_XA_NGUOIDUNG", new[] { "NGUOIDUNGID" });
            DropIndex("MPLIS21.HT_XA_NGUOIDUNG", new[] { "KVHCID" });
            DropIndex("MPLIS21.HS_HOSO", new[] { "HOSOTIEPNHANID" });
            DropIndex("MPLIS21.QT_HOSOTIEPNHAN", new[] { "THUTUCHANHCHINHID" });
            DropIndex("MPLIS21.QT_FILEDINHKEMHOSO", new[] { "HOSOTIEPNHANID" });
            DropIndex("MPLIS21.QT_FILEDINHKEMHOSO", new[] { "GIAYTOTHEOTTHCID" });
            DropIndex("MPLIS21.QT_GIAYTOTHEOTTHC", new[] { "THUTUCHANHCHINHID" });
            DropIndex("MPLIS21.QT_TTHC_QUYTRINH", new[] { "THUTUCHANHCHINHID" });
            DropIndex("MPLIS21.QT_TTHC_QUYTRINH", new[] { "QUYTRINHID" });
            DropIndex("MPLIS21.QT_QUYTRINH", new[] { "NHOMQUYTRINHID" });
            DropIndex("MPLIS21.QT_BUOCQUYTRINH", new[] { "QUYTRINHID" });
            DropIndex("MPLIS21.QT_CONGVIECTHUCHIEN", new[] { "LUANCHUYENHOSOID" });
            DropIndex("MPLIS21.QT_LUANCHUYEN_HOSO", new[] { "QUYTRINHID" });
            DropIndex("MPLIS21.QT_LUANCHUYEN_HOSO", new[] { "HOSOTIEPNHANID" });
            DropIndex("MPLIS21.QT_LUANCHUYEN_HOSO", new[] { "HOSOXULYID" });
            DropIndex("MPLIS21.QT_HOSO_LANXULY", new[] { "QUYTRINHID" });
            DropIndex("MPLIS21.QT_HOSO_LANXULY", new[] { "HOSOTIEPNHANID" });
            DropIndex("MPLIS21.QT_GHICHUXULY", new[] { "QUYTRINHID" });
            DropIndex("MPLIS21.QT_GHICHUXULY", new[] { "HOSOTIEPNHANID" });
            DropIndex("MPLIS21.QT_GHICHUXULY", new[] { "HOSOXULYID" });
            DropIndex("MPLIS21.QT_GHICHUXULY", new[] { "BUOCQUYTRINHID" });
            DropIndex("MPLIS21.QT_GHICHUXULY", new[] { "NGUOIDUNGID" });
            DropIndex("MPLIS21.QT_LUANCHUYEN_HOSO", new[] { "BUOCQUYTRINHID" });
            DropIndex("MPLIS21.QT_LUANCHUYEN_HOSO", new[] { "NGUOIDUNGID" });
            DropIndex("MPLIS21.QT_CONGVIECTHUCHIEN", new[] { "CONGVIECTHEOBUOCID" });
            DropIndex("MPLIS21.QT_CONGVIECTHEOBUOC", new[] { "BUOCQUYTRINHID" });
            DropIndex("MPLIS21.QT_BUOCQT_CAUHINH", new[] { "BUOCQUYTRINHID" });
            DropIndex("MPLIS21.QT_BUOCQT_CAUHINH", new[] { "NGUOIDUNGID" });
            DropIndex("MPLIS21.QT_BUOCQT_CAUHINH", new[] { "KVHCID" });
            DropIndex("MPLIS21.QT_THUTUCHANHCHINH", new[] { "TOCHUCID" });
            DropIndex("MPLIS21.QT_THUTUCHANHCHINH", new[] { "BOTHUTUCHANHCHINHID" });
            DropIndex("MPLIS21.QT_HOSOTIEPNHAN", new[] { "TOCHUCID" });
            DropIndex("MPLIS21.HS_THANHPHANHOSO", new[] { "HOSOID" });
            DropIndex("MPLIS21.HS_TC_GCN", new[] { "HOSOID" });
            DropIndex("MPLIS21.HS_TC_CHU", new[] { "HOSOID" });
            DropIndex("MPLIS21.HS_LIENKETTHUADAT", new[] { "HOSOID" });
            DropIndex("MPLIS21.HS_LIENKETTHUADAT", new[] { "KVHCID" });
            DropIndex("MPLIS21.HS_LICHSU", new[] { "HOSOID" });
            DropIndex("MPLIS21.HS_LICHSU", new[] { "KVHCID" });
            DropIndex("MPLIS21.HS_HOSO", new[] { "KVHCID" });
            DropIndex("MPLIS21.HC_DMKVHC", new[] { "HUYENID" });
            DropIndex("MPLIS21.HC_HUYEN", new[] { "TINHID" });
            DropIndex("MPLIS21.HC_TINHTHAMSO", new[] { "TINHID" });
            DropIndex("MPLIS21.DC_TAILIEUDODAC", new[] { "KVHCID" });
            DropIndex("MPLIS21.DC_TAILIEUDODAC", new[] { "LOAIBANDODIACHINHID" });
            DropIndex("MPLIS21.DC_THUADAT_TAILIEUDODAC", new[] { "THUADATID" });
            DropIndex("MPLIS21.DC_THUADAT_TAILIEUDODAC", new[] { "TAILIEUDODACID" });
            DropIndex("MPLIS21.DC_THUADAT", new[] { "DOANDUONGID" });
            DropIndex("MPLIS21.DC_BD_THUA_THUA", new[] { "THUACHAID" });
            DropIndex("MPLIS21.DC_BD_THUA_THUA", new[] { "THUADATID" });
            DropIndex("MPLIS21.DC_BD_THUA", new[] { "THUADATID" });
            DropIndex("MPLIS21.DC_BD_THUA", new[] { "BIENDONGID" });
            DropIndex("MPLIS21.DC_THUATAISAN", new[] { "TAISANGANLIENVOIDATID" });
            DropIndex("MPLIS21.DC_QUYENSOHUUTAISAN", new[] { "TAISANGANLIENVOIDATID" });
            DropIndex("MPLIS21.DC_QUYENSOHUUTAISAN", new[] { "NGUOIID" });
            DropIndex("MPLIS21.DC_QUYENSOHUUTAISAN", new[] { "GIAYCHUNGNHANID" });
            DropIndex("MPLIS21.DC_QUYENSOHUUTAISAN", new[] { "BDTHECHAPID" });
            DropIndex("MPLIS21.DC_QUYENQUANLYDAT", new[] { "NGUOIID" });
            DropIndex("MPLIS21.DC_QUYENQUANLYDAT", new[] { "MUCDICHSUDUNGID" });
            DropIndex("MPLIS21.DC_MUCDICHSUDUNGDAT", new[] { "MUCDICHSUDUNGQHID" });
            DropIndex("MPLIS21.DC_MUCDICHSUDUNGDAT", new[] { "MUCDICHSUDUNGID" });
            DropIndex("MPLIS21.DC_THUEDAT", new[] { "MUCDICHSUDUNGID" });
            DropIndex("MPLIS21.DC_THUEDAT", new[] { "BIENDONGID" });
            DropIndex("MPLIS21.DC_BD_CHUYENMDSDD", new[] { "MUCDICHSUDUNGID" });
            DropIndex("MPLIS21.DC_BD_CHUYENMDSDD", new[] { "BIENDONGID" });
            DropIndex("MPLIS21.DC_MUCDICHSUDUNGDAT", new[] { "HINHTHUCSUDUNGID" });
            DropIndex("MPLIS21.DC_BD_CHUYENHTSDD", new[] { "HINHTHUCSUDUNGID" });
            DropIndex("MPLIS21.DC_BD_CHUYENHTSDD", new[] { "BIENDONGID" });
            DropIndex("MPLIS21.DC_VITRITHUADAT", new[] { "MUCDICHSUDUNGDATID" });
            DropIndex("MPLIS21.DC_QUYENSUDUNGDAT", new[] { "NGUOIID" });
            DropIndex("MPLIS21.DC_QUYENSUDUNGDAT", new[] { "MUCDICHSUDUNGDATID" });
            DropIndex("MPLIS21.DC_QUYENSUDUNGDAT", new[] { "BDTHECHAPID" });
            DropIndex("MPLIS21.DC_NGUONGOCSUDUNG", new[] { "LOAINGUONGOCSUDUNGID" });
            DropIndex("MPLIS21.DC_NGUONGOCSUDUNG", new[] { "MUCDICHSUDUNGDATID" });
            DropIndex("MPLIS21.DC_QUYENQUANLYDAT", new[] { "GIAYCHUNGNHANID" });
            DropIndex("MPLIS21.DC_QUYENQUANLYDAT", new[] { "BDTHECHAPID" });
            DropIndex("MPLIS21.DC_BD_THECHAP", new[] { "BIENDONGID" });
            DropIndex("MPLIS21.DC_TAISAN_DIACHI", new[] { "DIACHIID" });
            DropIndex("MPLIS21.DC_GCN_TILESH", new[] { "LOAIDTMIENGIAMID" });
            DropIndex("MPLIS21.DC_MIENGIAMNVTC", new[] { "LOAINGHIAVUTAICHINHID" });
            DropIndex("MPLIS21.DC_MIENGIAMNVTC", new[] { "LOAIDTMIENGIAMID" });
            DropIndex("MPLIS21.DC_MIENGIAMNVTC", new[] { "NGUOIID" });
            DropIndex("MPLIS21.DC_MIENGIAMNVTC", new[] { "NGHIAVUTAICHINHID" });
            DropIndex("MPLIS21.DC_NONVTC", new[] { "LOAINGHIAVUTAICHINHID" });
            DropIndex("MPLIS21.DC_NONVTC", new[] { "NGUOIID" });
            DropIndex("MPLIS21.DC_NONVTC", new[] { "NGHIAVUTAICHINHID" });
            DropIndex("MPLIS21.DC_NGHIAVUTAICHINH", new[] { "LOAINGHIAVUTAICHINHID" });
            DropIndex("MPLIS21.DC_KHOANDUOCTRU", new[] { "NGUOIID" });
            DropIndex("MPLIS21.DC_KHOANDUOCTRU", new[] { "NGHIAVUTAICHINHID" });
            DropIndex("MPLIS21.DC_GTKEMTHEO", new[] { "NGHIAVUTAICHINHID" });
            DropIndex("MPLIS21.DC_GCN_TILESH", new[] { "NGUOIID" });
            DropIndex("MPLIS21.DC_GCN_TILESH", new[] { "GIAYCHUNGNHANID" });
            DropIndex("MPLIS21.DC_DANGKY_NGUOI", new[] { "NGUOIID" });
            DropIndex("MPLIS21.DC_DANGKY_NGUOI", new[] { "DONDANGKYID" });
            DropIndex("MPLIS21.DC_YKIENXACNHAN", new[] { "XACNHANDONDANGKYID" });
            DropIndex("MPLIS21.DC_XACNHANDONDANGKY", new[] { "DONDANGKYID" });
            DropIndex("MPLIS21.DC_DANGKY_THUA", new[] { "DONDANGKYID" });
            DropIndex("MPLIS21.DC_DANGKY_GCN", new[] { "GIAYCHUNGNHANID" });
            DropIndex("MPLIS21.DC_DANGKY_GCN", new[] { "DONDANGKYID" });
            DropIndex("MPLIS21.DC_BD_CHU", new[] { "BIENDONGID" });
            DropIndex("MPLIS21.HT_TOCHUC_NHOMCHUCNANG", new[] { "NHOMCHUCNANGID" });
            DropIndex("MPLIS21.HT_NHOMCHUCNANG_MENU", new[] { "NHOMCHUCNANGID" });
            DropIndex("MPLIS21.HT_NHOMCHUCNANG_MENU", new[] { "MENUID" });
            DropIndex("MPLIS21.HT_MENU", new[] { "KHOACHAID" });
            DropIndex("MPLIS21.HT_CHUCNANG_NHOMCHUCNANG", new[] { "CHUCNANGID" });
            DropIndex("MPLIS21.HT_NGUOIDUNG_QUYEN", new[] { "NGUOIDUNGID" });
            DropIndex("MPLIS21.HT_LICHSUTRUYCAP", new[] { "NGUOIDUNGID" });
            DropIndex("MPLIS21.HT_CAUHINHNGUOIDUNG", new[] { "NGUOIDUNGID" });
            DropIndex("MPLIS21.CS_CHUKYSO", new[] { "NHACUNGCAPID" });
            DropIndex("MPLIS21.CS_LICHSUGIAHAN", new[] { "CHUKYSOID" });
            DropIndex("MPLIS21.CS_GIAYTOXACMINH", new[] { "CHUKYSOID" });
            DropTable("MPLIS21.LOAIHOSO_DONVIAPDUNG");
            DropTable("MPLIS21.QT_NGAYNGHI");
            DropTable("MPLIS21.QH_VUNGQUYHOACHCAPTINH");
            DropTable("MPLIS21.QH_MDSD_CT");
            DropTable("MPLIS21.QH_MDSD");
            DropTable("MPLIS21.QH_KHUCHUCNANGCAPTINHGEO");
            DropTable("MPLIS21.QH_KHUCHUCNANGCAPHUYENGEO");
            DropTable("MPLIS21.QH_QUYHOACHQPAN");
            DropTable("MPLIS21.QH_DINHKEMQUYHOACHQPAN");
            DropTable("MPLIS21.QH_QUYHOACHCAPTW");
            DropTable("MPLIS21.QH_DINHKEMQUYHOACHCAPTW");
            DropTable("MPLIS21.QH_QUYHOACHCAPTINH");
            DropTable("MPLIS21.QH_DINHKEMQUYHOACHCAPTINH");
            DropTable("MPLIS21.QH_QUYHOACHCAPHUYEN");
            DropTable("MPLIS21.QH_DINHKEMQUYHOACHCAPHUYEN");
            DropTable("MPLIS21.QH_KHUCHUCNANGCAPTINH");
            DropTable("MPLIS21.QH_DINHKEMKCNCAPTINH");
            DropTable("MPLIS21.QH_KHUCHUCNANGCAPHUYEN");
            DropTable("MPLIS21.QH_DINHKEMKCNCAPHUYEN");
            DropTable("MPLIS21.QH_CAPTINH");
            DropTable("MPLIS21.QH_CAPHUYEN");
            DropTable("MPLIS21.QH_BIEUBANGCAPHUYEN");
            DropTable("MPLIS21.QH_BIEUBANG");
            DropTable("MPLIS21.MT_PHANPHOI");
            DropTable("MPLIS21.MT_METADATA");
            DropTable("MPLIS21.MT_LANDDATA");
            DropTable("MPLIS21.MT_HEQUYCHIEU");
            DropTable("MPLIS21.MT_GIOIHAN");
            DropTable("MPLIS21.MT_DONVI");
            DropTable("MPLIS21.MT_CHATLUONG");
            DropTable("MPLIS21.HT_THONGBAO");
            DropTable("MPLIS21.HT_MAUGIAYTOKEMTHEOHS");
            DropTable("MPLIS21.HT_CAUHINH");
            DropTable("MPLIS21.HS_VITRILUUTRU");
            DropTable("MPLIS21.GD_KHUNGGIADAT");
            DropTable("MPLIS21.GD_HSDCGIADAT");
            DropTable("MPLIS21.GD_QDGIADAT");
            DropTable("MPLIS21.GD_BANGGIADAT");
            DropTable("MPLIS21.GD_BANDOGIADAT");
            DropTable("MPLIS21.DM_TRANGTHAIHOSO");
            DropTable("MPLIS21.DM_SEQUENCE");
            DropTable("MPLIS21.DM_LOAIVUNGTHUYHE");
            DropTable("MPLIS21.DM_LOAITRANGTHAIDANGKYCAPGCN");
            DropTable("MPLIS21.DM_LOAITOCHUC");
            DropTable("MPLIS21.DM_LOAITAISANGANLIENVOIDAT");
            DropTable("MPLIS21.DM_LOAIQUYHOACH");
            DropTable("MPLIS21.DM_LOAIMOCBIENGIOIDIAGIOI");
            DropTable("MPLIS21.DM_LOAIMOC");
            DropTable("MPLIS21.DM_LOAIKHUVUCTONGHOP");
            DropTable("MPLIS21.DM_LOAIKHUCHUCNANGCAPTINH");
            DropTable("MPLIS21.DM_LOAIKHUCHUCNANGCAPHUYEN");
            DropTable("MPLIS21.DM_LOAIKETCAU");
            DropTable("MPLIS21.DM_LOAIHANHLANGANTOANBAOVE");
            DropTable("MPLIS21.DM_LOAIHANHDONG");
            DropTable("MPLIS21.DM_LOAIGIAYTOTUYTHAN");
            DropTable("MPLIS21.DM_LOAIDUONGTHUYHE");
            DropTable("MPLIS21.DM_LOAIDUONG");
            DropTable("MPLIS21.DM_LOAIDIEMTOADO");
            DropTable("MPLIS21.DM_LOAIDIEMDOCAO");
            DropTable("MPLIS21.DM_LOAIDIADANH");
            DropTable("MPLIS21.DM_LOAIDATHIENTRANG");
            DropTable("MPLIS21.DM_LOAIBIENDONG");
            DropTable("MPLIS21.DM_GIAYTOKEMTHEOHS");
            DropTable("MPLIS21.DC_XA_TENDUONG");
            DropTable("MPLIS21.DC_VOCHONG");
            DropTable("MPLIS21.DC_TOCHUC");
            DropTable("MPLIS21.DC_THUADATLS");
            DropTable("MPLIS21.DC_THONGTINNGANCHAN");
            DropTable("MPLIS21.DC_TENDUONG");
            DropTable("MPLIS21.DC_TAISANGANLIENVOIDATLS");
            DropTable("MPLIS21.DC_TAISANGANLIENVOIDATLICHSU");
            DropTable("MPLIS21.DC_SODIACHINHDIENTU_THUADAT");
            DropTable("MPLIS21.DC_SODIACHINHDIENTU_CANHO");
            DropTable("MPLIS21.DC_RUNGTRONG");
            DropTable("MPLIS21.DC_QUYETDINH");
            DropTable("MPLIS21.DC_QUYENSUDUNGDATSAUBD");
            DropTable("MPLIS21.DC_QUYENSUDUNGDATLS");
            DropTable("MPLIS21.DC_QUYENSOHUUTAISANLS");
            DropTable("MPLIS21.DC_NHOMNGUOI_THANHVIEN");
            DropTable("MPLIS21.DC_NHOMNGUOI");
            DropTable("MPLIS21.DM_LOAINHA");
            DropTable("MPLIS21.DM_LOAICAPHANG");
            DropTable("MPLIS21.DC_NHARIENGLE");
            DropTable("MPLIS21.DC_NGUOILS");
            DropTable("MPLIS21.DC_NGANCHANTHUADAT");
            DropTable("MPLIS21.DC_NGANCHANTAISAN");
            DropTable("MPLIS21.DC_NGANCHANNGUOI");
            DropTable("MPLIS21.DC_NGANCHANGIAYCHUNGNHAN");
            DropTable("MPLIS21.DC_MUCDICHSUDUNGDATLS");
            DropTable("MPLIS21.DC_LOAICHEDONO");
            DropTable("MPLIS21.DC_LOAICHEDOMIENGIAM");
            DropTable("MPLIS21.DM_QHVOICHUHO");
            DropTable("MPLIS21.DC_HOGIADINH_THANHVIEN");
            DropTable("MPLIS21.DC_HOGIADINH");
            DropTable("MPLIS21.DC_LOAIHANCHE");
            DropTable("MPLIS21.DC_HANCHE");
            DropTable("MPLIS21.DC_GIAYTOTUYTHAN");
            DropTable("MPLIS21.DC_DANGKY_TAISAN");
            DropTable("MPLIS21.DC_HANGMUCCONGTRINH");
            DropTable("MPLIS21.DC_CONGTRINHXAYDUNG");
            DropTable("MPLIS21.DC_CONGTRINHNGAM");
            DropTable("MPLIS21.DC_CONGDONG");
            DropTable("MPLIS21.DC_DONKIENNGHI");
            DropTable("MPLIS21.DC_DANHSACHCONGKHAI");
            DropTable("MPLIS21.DC_CHITIETCONGKHAI");
            DropTable("MPLIS21.DC_CAYLAUNAM");
            DropTable("MPLIS21.DC_KHUCHUNGCU");
            DropTable("MPLIS21.DC_NHACHUNGCU");
            DropTable("MPLIS21.DC_HANGMUCNGOAICANHO");
            DropTable("MPLIS21.DC_CANHO_HANGMUCNCH");
            DropTable("MPLIS21.DC_CANHO");
            DropTable("MPLIS21.DM_QUOCTICH");
            DropTable("MPLIS21.DM_DANTOC");
            DropTable("MPLIS21.DC_CANHAN");
            DropTable("MPLIS21.HT_UNGDUNG");
            DropTable("MPLIS21.HT_TOCHUC_NGUOIDUNG");
            DropTable("MPLIS21.DC_BD_GCN_GCN");
            DropTable("MPLIS21.LS_TC_THUA");
            DropTable("MPLIS21.LS_TC_HOSO");
            DropTable("MPLIS21.LS_TC_GCN");
            DropTable("MPLIS21.LS_TC_CHU");
            DropTable("MPLIS21.LS_BOHOSO");
            DropTable("MPLIS21.LS_BD_THUA");
            DropTable("MPLIS21.LS_BD_GCN");
            DropTable("MPLIS21.DC_NOICONGCHUNG");
            DropTable("MPLIS21.DC_LOAIBIENDONG");
            DropTable("MPLIS21.DC_BD_TREN_GCN");
            DropTable("MPLIS21.DM_DOITUONGSUDUNG");
            DropTable("MPLIS21.GD_DMLOAIGIADAT");
            DropTable("MPLIS21.GD_GIATHUADAT");
            DropTable("MPLIS21.DC_TRANHCHAP");
            DropTable("MPLIS21.DC_THUADAT_TAISAN");
            DropTable("MPLIS21.HT_XA_TOCHUC");
            DropTable("MPLIS21.HT_XA_NGUOIDUNG");
            DropTable("MPLIS21.QT_NHOMQUYTRINH");
            DropTable("MPLIS21.QT_GHICHUXULY");
            DropTable("MPLIS21.QT_HOSO_LANXULY");
            DropTable("MPLIS21.QT_LUANCHUYEN_HOSO");
            DropTable("MPLIS21.QT_CONGVIECTHUCHIEN");
            DropTable("MPLIS21.QT_CONGVIECTHEOBUOC");
            DropTable("MPLIS21.QT_BUOCQT_CAUHINH");
            DropTable("MPLIS21.QT_BUOCQUYTRINH");
            DropTable("MPLIS21.QT_QUYTRINH");
            DropTable("MPLIS21.QT_TTHC_QUYTRINH");
            DropTable("MPLIS21.DM_BOTHUTUCHANHCHINH");
            DropTable("MPLIS21.QT_THUTUCHANHCHINH");
            DropTable("MPLIS21.QT_GIAYTOTHEOTTHC");
            DropTable("MPLIS21.QT_FILEDINHKEMHOSO");
            DropTable("MPLIS21.QT_HOSOTIEPNHAN");
            DropTable("MPLIS21.HS_THANHPHANHOSO");
            DropTable("MPLIS21.HS_TC_GCN");
            DropTable("MPLIS21.HS_TC_CHU");
            DropTable("MPLIS21.HS_LIENKETTHUADAT");
            DropTable("MPLIS21.HS_LICHSU");
            DropTable("MPLIS21.HS_HOSO");
            DropTable("MPLIS21.HC_TINHTHAMSO");
            DropTable("MPLIS21.HC_TINH");
            DropTable("MPLIS21.HC_HUYEN");
            DropTable("MPLIS21.DM_LOAIBANDODIACHINH");
            DropTable("MPLIS21.DC_THUADAT_TAILIEUDODAC");
            DropTable("MPLIS21.DC_TAILIEUDODAC");
            DropTable("MPLIS21.HC_DMKVHC");
            DropTable("MPLIS21.DC_KHUVUC");
            DropTable("MPLIS21.DC_DOANDUONG");
            DropTable("MPLIS21.DC_BD_THUA_THUA");
            DropTable("MPLIS21.DC_BD_THUA");
            DropTable("MPLIS21.DC_THUADAT");
            DropTable("MPLIS21.DC_THUATAISAN");
            DropTable("MPLIS21.DM_MUCDICHSUDUNGQH");
            DropTable("MPLIS21.DC_THUEDAT");
            DropTable("MPLIS21.DC_BD_CHUYENMDSDD");
            DropTable("MPLIS21.DM_MUCDICHSUDUNG");
            DropTable("MPLIS21.DC_BD_CHUYENHTSDD");
            DropTable("MPLIS21.DM_HINHTHUCSUDUNGDAT");
            DropTable("MPLIS21.DC_VITRITHUADAT");
            DropTable("MPLIS21.DC_QUYENSUDUNGDAT");
            DropTable("MPLIS21.DM_LOAINGUONGOCSUDUNG");
            DropTable("MPLIS21.DC_NGUONGOCSUDUNG");
            DropTable("MPLIS21.DC_MUCDICHSUDUNGDAT");
            DropTable("MPLIS21.DC_QUYENQUANLYDAT");
            DropTable("MPLIS21.DC_BD_THECHAP");
            DropTable("MPLIS21.DC_QUYENSOHUUTAISAN");
            DropTable("MPLIS21.DC_TAISANGANLIENVOIDAT");
            DropTable("MPLIS21.DC_TAISAN_DIACHI");
            DropTable("MPLIS21.DC_DIACHI");
            DropTable("MPLIS21.DC_NGUOI_DIACHI");
            DropTable("MPLIS21.DM_LOAINGHIAVUTAICHINH");
            DropTable("MPLIS21.DC_NONVTC");
            DropTable("MPLIS21.DC_LOAINGHIAVUTAICHINH");
            DropTable("MPLIS21.DC_KHOANDUOCTRU");
            DropTable("MPLIS21.DC_GTKEMTHEO");
            DropTable("MPLIS21.DC_NGHIAVUTAICHINH");
            DropTable("MPLIS21.DC_MIENGIAMNVTC");
            DropTable("MPLIS21.DM_LOAIDTMIENGIAM");
            DropTable("MPLIS21.DC_GCN_TILESH");
            DropTable("MPLIS21.DC_YKIENXACNHAN");
            DropTable("MPLIS21.DC_XACNHANDONDANGKY");
            DropTable("MPLIS21.DC_DANGKY_THUA");
            DropTable("MPLIS21.DC_DANGKY_GCN");
            DropTable("MPLIS21.DC_DONDANGKY");
            DropTable("MPLIS21.DC_DANGKY_NGUOI");
            DropTable("MPLIS21.DC_NGUOI");
            DropTable("MPLIS21.DC_BD_CHU");
            DropTable("MPLIS21.DC_BIENDONG");
            DropTable("MPLIS21.DC_BD_GCN");
            DropTable("MPLIS21.DC_GIAYCHUNGNHAN");
            DropTable("MPLIS21.HT_TOCHUC");
            DropTable("MPLIS21.HT_TOCHUC_NHOMCHUCNANG");
            DropTable("MPLIS21.HT_MENU");
            DropTable("MPLIS21.HT_NHOMCHUCNANG_MENU");
            DropTable("MPLIS21.HT_NHOMCHUCNANG");
            DropTable("MPLIS21.HT_CHUCNANG_NHOMCHUCNANG");
            DropTable("MPLIS21.HT_CHUCNANG");
            DropTable("MPLIS21.HT_QUYEN");
            DropTable("MPLIS21.HT_NGUOIDUNG_QUYEN");
            DropTable("MPLIS21.HT_LICHSUTRUYCAP");
            DropTable("MPLIS21.HT_CAUHINHNGUOIDUNG");
            DropTable("MPLIS21.HT_NGUOIDUNG");
            DropTable("MPLIS21.CS_NHACUNGCAP");
            DropTable("MPLIS21.CS_LICHSUGIAHAN");
            DropTable("MPLIS21.CS_GIAYTOXACMINH");
            DropTable("MPLIS21.CS_CHUKYSO");
        }
    }
}
