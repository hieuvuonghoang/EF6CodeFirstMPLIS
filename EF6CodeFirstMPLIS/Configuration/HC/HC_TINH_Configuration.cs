namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HC_TINH_Configuration : EntityTypeConfiguration<HC_TINH>
    {
        public HC_TINH_Configuration()
        {
            this.HasKey(t => t.TINHID);

            this.Property(t => t.TINHID)
                .HasColumnName("TINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MATINH)
                .HasColumnName("MATINH")
                .IsUnicode(false)
                .HasMaxLength(2);
            this.Property(t => t.TENTINH)
                .HasColumnName("TENTINH")
                .IsUnicode(false)
                .HasMaxLength(60);
            this.Property(t => t.PHANLOAI)
                .HasColumnName("PHANLOAI")
                .IsUnicode(false)
                .HasMaxLength(20);
            this.Property(t => t.THUTUSAPXEP)
                .HasColumnName("THUTUSAPXEP")
                .IsUnicode(false)
                .HasMaxLength(2);
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
            this.Property(t => t.MAKVHC)
                .HasColumnName("MAKVHC")
                .IsUnicode(false)
                .HasMaxLength(10);

            this.ToTable("HC_TINH");
        }
    }
}
