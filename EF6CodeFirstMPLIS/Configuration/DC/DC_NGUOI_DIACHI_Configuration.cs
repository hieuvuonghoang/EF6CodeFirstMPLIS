namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_NGUOI_DIACHI_Configuration : EntityTypeConfiguration<DC_NGUOI_DIACHI>
    {
        public DC_NGUOI_DIACHI_Configuration()
        {
            this.HasKey(t => t.NGUOIDIACHIID);

            this.Property(t => t.NGUOIDIACHIID)
                .HasColumnName("NGUOIDIACHIID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOIID)
                .HasColumnName("NGUOIID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.DIACHIID)
                .HasColumnName("DIACHIID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MOTA)
                .HasColumnName("MOTA")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.THOIDIEMKHOITAO)
                .HasColumnName("THOIDIEMKHOITAO");
            this.Property(t => t.THOIDIEMCAPNHAT)
                .HasColumnName("THOIDIEMCAPNHAT");
            this.Property(t => t.NGUOICAPPHATID)
                .HasColumnName("NGUOICAPPHATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.uId)
                .HasColumnName("uId")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<DC_DIACHI>(t => t.DC_DIACHI)
                .WithMany(m => m.DC_NGUOI_DIACHI)
                .HasForeignKey(m => m.DIACHIID);
            this.HasRequired<DC_NGUOI>(t => t.DC_NGUOI)
                .WithMany(m => m.DC_NGUOI_DIACHI)
                .HasForeignKey(m => m.NGUOIID);

            this.ToTable("DC_NGUOI_DIACHI");
        }
    }
}
