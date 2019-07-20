namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HC_HUYEN_Configuration : EntityTypeConfiguration<HC_HUYEN>
    {
        public HC_HUYEN_Configuration()
        {
            this.HasKey(t => t.HUYENID);

            this.Property(t => t.HUYENID)
                .HasColumnName("HUYENID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TINHID)
                .HasColumnName("TINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MAHUYEN)
                .HasColumnName("MAHUYEN")
                .IsUnicode(false)
                .HasMaxLength(3);
            this.Property(t => t.TENHUYEN)
                .HasColumnName("TENHUYEN")
                .IsUnicode(false)
                .HasMaxLength(80);
            this.Property(t => t.PHANLOAI)
                .HasColumnName("PHANLOAI")
                .IsUnicode(false)
                .HasMaxLength(20);
            this.Property(t => t.THUTUSAPXEP)
                .HasColumnName("THUTUSAPXEP")
                .IsUnicode(false)
                .HasMaxLength(3);
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

            this.HasRequired<HC_TINH>(t => t.HC_TINH)
                .WithMany(m => m.HC_HUYEN)
                .HasForeignKey(m => m.TINHID);

            this.ToTable("HC_HUYEN");
        }
    }
}
