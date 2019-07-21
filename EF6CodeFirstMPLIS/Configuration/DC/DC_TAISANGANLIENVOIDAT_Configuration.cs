namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_TAISANGANLIENVOIDAT_Configuration : EntityTypeConfiguration<DC_TAISANGANLIENVOIDAT>
    {
        public DC_TAISANGANLIENVOIDAT_Configuration()
        {
            this.HasKey(t => t.TAISANGANLIENVOIDATID);

            this.Property(t => t.TAISANGANLIENVOIDATID)
                .HasColumnName("TAISANGANLIENVOIDATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TAISANID)
                .HasColumnName("TAISANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LOAITAISAN)
                .HasColumnName("LOAITAISAN")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENTAISAN)
                .HasColumnName("TENTAISAN")
                .IsUnicode(false)
                .HasMaxLength(150);
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
            this.Property(t => t.TRANGTHAI)
                .HasColumnName("TRANGTHAI")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.TAISANGOCID)
                .HasColumnName("TAISANGOCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.SOLANCAPQUYEN)
                .HasColumnName("SOLANCAPQUYEN");

            this.ToTable("DC_TAISANGANLIENVOIDAT");
        }
    }
}
