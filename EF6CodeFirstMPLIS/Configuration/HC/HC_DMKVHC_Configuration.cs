namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HC_DMKVHC_Configuration : EntityTypeConfiguration<HC_DMKVHC>
    {
        public HC_DMKVHC_Configuration()
        {
            this.HasKey(t => t.KVHCID);

            this.Property(t => t.KVHCID)
                .HasColumnName("KVHCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.HUYENID)
                .HasColumnName("HUYENID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MAXA)
                .HasColumnName("MAXA")
                .IsUnicode(false)
                .HasMaxLength(5);
            this.Property(t => t.TENKVHC)
                .HasColumnName("TENKVHC")
                .IsUnicode(false)
                .HasMaxLength(100);
            this.Property(t => t.PHANLOAI)
                .HasColumnName("PHANLOAI")
                .IsUnicode(false)
                .HasMaxLength(20);
            this.Property(t => t.THUTUSAPXEP)
                .HasColumnName("THUTUSAPXEP")
                .IsUnicode(false)
                .HasMaxLength(5);
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

            this.HasRequired<HC_HUYEN>(t => t.HC_HUYEN)
                .WithMany(m => m.HC_DMKVHC)
                .HasForeignKey(m => m.HUYENID);

            this.ToTable("HC_DMKVHC");

        }
    }
}
