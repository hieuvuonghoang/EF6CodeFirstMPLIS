namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_NGHIAVUTAICHINH_Configuration : EntityTypeConfiguration<DC_NGHIAVUTAICHINH>
    {
        public DC_NGHIAVUTAICHINH_Configuration()
        {
            this.HasKey(t => t.NGHIAVUTAICHINHID);

            this.Property(t => t.NGHIAVUTAICHINHID)
                .HasColumnName("NGHIAVUTAICHINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.QUYENSUDUNGDATID)
                .HasColumnName("QUYENSUDUNGDATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.QUYENSOHUUTAISANID)
                .HasColumnName("QUYENSOHUUTAISANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LOAINGHIAVUTAICHINHID)
                .HasColumnName("LOAINGHIAVUTAICHINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TONGSOTIEN)
                .HasColumnName("TONGSOTIEN");
            this.Property(t => t.TONGSOTIENMIENGIAM)
                .HasColumnName("TONGSOTIENMIENGIAM");
            this.Property(t => t.TONGSOTIENNO)
                .HasColumnName("TONGSOTIENNO");
            this.Property(t => t.NGAYBATDAU)
                .HasColumnName("NGAYBATDAU");
            this.Property(t => t.HOANTHANH)
                .HasColumnName("HOANTHANH")
                .IsUnicode(false)
                .HasMaxLength(1);
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
            this.Property(t => t.SOPHIEUCHUYEN)
                .HasColumnName("SOPHIEUCHUYEN")
                .IsUnicode(false)
                .HasMaxLength(20);

            this.HasRequired<DC_LOAINGHIAVUTAICHINH>(t => t.DC_LOAINGHIAVUTAICHINH)
                .WithMany(m => m.DC_NGHIAVUTAICHINH)
                .HasForeignKey(m => m.LOAINGHIAVUTAICHINHID);

            this.ToTable("DC_NGHIAVUTAICHINH");
        }
    }
}
