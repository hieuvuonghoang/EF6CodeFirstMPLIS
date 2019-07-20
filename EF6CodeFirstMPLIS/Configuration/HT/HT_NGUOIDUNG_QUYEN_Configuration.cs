namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HT_NGUOIDUNG_QUYEN_Configuration : EntityTypeConfiguration<HT_NGUOIDUNG_QUYEN>
    {
        public HT_NGUOIDUNG_QUYEN_Configuration()
        {
            this.HasKey(t => t.NGUOIDUNGQUYENID);

            this.Property(t => t.NGUOIDUNGQUYENID)
                .HasColumnName("NGUOIDUNGQUYENID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOIDUNGID)
                .HasColumnName("NGUOIDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.QUYENID)
                .HasColumnName("QUYENID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.KICHHOATQUYEN)
                .HasColumnName("KICHHOATQUYEN");
            this.Property(t => t.UID)
                .HasColumnName("UID")
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

            this.HasRequired<HT_NGUOIDUNG>(t => t.HT_NGUOIDUNG)
                .WithMany(m => m.HT_NGUOIDUNG_QUYEN)
                .HasForeignKey(m => m.NGUOIDUNGID);
            this.HasRequired<HT_QUYEN>(t => t.HT_QUYEN)
                .WithMany(m => m.HT_NGUOIDUNG_QUYEN)
                .HasForeignKey(m => m.QUYENID);

            this.ToTable("HT_NGUOIDUNG_QUYEN");
        }
    }
}
