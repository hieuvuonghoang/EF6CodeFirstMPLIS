namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_TAISAN_DIACHI_Configuration : EntityTypeConfiguration<DC_TAISAN_DIACHI>
    {
        public DC_TAISAN_DIACHI_Configuration()
        {
            this.HasKey(t => t.TAISANDIACHIID);

            this.Property(t => t.TAISANDIACHIID)
                .HasColumnName("TAISANDIACHIID")
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
            this.Property(t => t.TAISANGANLIENVOIDATID)
                .HasColumnName("TAISANGANLIENVOIDATID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<DC_DIACHI>(t => t.DC_DIACHI)
                .WithMany(m => m.DC_TAISAN_DIACHI)
                .HasForeignKey(m => m.DIACHIID);
            this.HasRequired<DC_TAISANGANLIENVOIDAT>(t => t.DC_TAISANGANLIENVOIDAT)
                .WithMany(m => m.DC_TAISAN_DIACHI)
                .HasForeignKey(m => m.TAISANGANLIENVOIDATID);

            this.ToTable("DC_TAISAN_DIACHI");
        }
    }
}
