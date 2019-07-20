namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HT_NGUOIDUNG_Configuration : EntityTypeConfiguration<HT_NGUOIDUNG>
    {
        public HT_NGUOIDUNG_Configuration()
        {
            this.HasKey(t => t.NGUOIDUNGID);

            this.Property(t => t.NGUOIDUNGID)
                .HasColumnName("NGUOIDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENDANGNHAP)
                .HasColumnName("TENDANGNHAP")
                .IsUnicode(false)
                .HasMaxLength(20);
            this.Property(t => t.MATKHAU)
                .HasColumnName("MATKHAU")
                .IsUnicode(false)
                .HasMaxLength(100);
            this.Property(t => t.HOTENNGUOIDUNG)
                .HasColumnName("HOTENNGUOIDUNG")
                .IsUnicode(false)
                .HasMaxLength(100);
            this.Property(t => t.GIOITINH)
                .HasColumnName("GIOITINH")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.SODIENTHOAI)
                .HasColumnName("SODIENTHOAI")
                .IsUnicode(false)
                .HasMaxLength(15);
            this.Property(t => t.SODIENTHOAI2)
                .HasColumnName("SODIENTHOAI2")
                .IsUnicode(false)
                .HasMaxLength(15);
            this.Property(t => t.EMAIL)
                .HasColumnName("EMAIL")
                .IsUnicode(false)
                .HasMaxLength(50);
            this.Property(t => t.DIACHI)
                .HasColumnName("DIACHI")
                .IsUnicode(false)
                .HasMaxLength(150);
            this.Property(t => t.READONLY)
                .HasColumnName("READONLY");
            this.Property(t => t.ANHBIEUTUONG)
                .HasColumnName("ANHBIEUTUONG");
            this.Property(t => t.PHAITHAYDOIMATKHAU)
                .HasColumnName("PHAITHAYDOIMATKHAU")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.THOIDIEMMATKHAUCOHIEULUC)
                .HasColumnName("THOIDIEMMATKHAUCOHIEULUC");
            this.Property(t => t.THOIDIEMMATKHAUHETHIEULUC)
                .HasColumnName("THOIDIEMMATKHAUHETHIEULUC");
            this.Property(t => t.CHOPHEPSUDUNG)
                .HasColumnName("CHOPHEPSUDUNG")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.MOTA)
                .HasColumnName("MOTA")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.uId)
                .HasColumnName("uId")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THOIDIEMKHOITAO)
                .HasColumnName("THOIDIEMKHOITAO");
            this.Property(t => t.THOIDIEMCAPNHAT)
                .HasColumnName("THOIDIEMCAPNHAT");
            this.Property(t => t.NGUOICAPNHATID)
                .HasColumnName("NGUOICAPNHATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.CAPNGUOIDUNG)
                .HasColumnName("CAPNGUOIDUNG")
                .IsUnicode(false)
                .HasMaxLength(2);
            this.Property(t => t.DONVIHANHCHINHID)
                .HasColumnName("DONVIHANHCHINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LOAINGUOIDUNG)
                .HasColumnName("LOAINGUOIDUNG");

            this.ToTable("HT_NGUOIDUNG");
        }
    }
}
