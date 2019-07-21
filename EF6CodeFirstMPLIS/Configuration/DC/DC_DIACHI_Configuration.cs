namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_DIACHI_Configuration : EntityTypeConfiguration<DC_DIACHI>
    {
        public DC_DIACHI_Configuration()
        {
            this.HasKey(t => t.DIACHIID);

            this.Property(t => t.DIACHIID)
                .HasColumnName("DIACHIID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MAXA)
                .HasColumnName("MAXA")
                .IsUnicode(false)
                .HasMaxLength(5);
            this.Property(t => t.DIACHICHITIET)
                .HasColumnName("DIACHICHITIET")
                .IsUnicode(false)
                .HasMaxLength(150);
            this.Property(t => t.TENDUONGPHO)
                .HasColumnName("TENDUONGPHO")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.TENTODANPHO)
                .HasColumnName("TENTODANPHO")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.TENXA)
                .HasColumnName("TENXA")
                .IsUnicode(false)
                .HasMaxLength(50);
            this.Property(t => t.TENHUYEN)
                .HasColumnName("TENHUYEN")
                .IsUnicode(false)
                .HasMaxLength(50);
            this.Property(t => t.TENTINH)
                .HasColumnName("TENTINH")
                .IsUnicode(false)
                .HasMaxLength(50);
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
            this.Property(t => t.DIACHIDAYDU)
                .HasColumnName("DIACHIDAYDU")
                .IsUnicode(false)
                .HasMaxLength(255);

            this.ToTable("DC_DIACHI");
        }
    }
}
