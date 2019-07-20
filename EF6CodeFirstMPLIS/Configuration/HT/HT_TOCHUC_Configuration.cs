namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HT_TOCHUC_Configuration : EntityTypeConfiguration<HT_TOCHUC>
    {
        public HT_TOCHUC_Configuration()
        {
            this.HasKey(t => t.TOCHUCID);

            this.Property(t => t.TOCHUCID)
                .HasColumnName("TOCHUCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.KHOACHAID)
                .HasColumnName("KHOACHAID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENTOCHUC)
                .HasColumnName("TENTOCHUC")
                .IsUnicode(false)
                .HasMaxLength(150);
            this.Property(t => t.MOTA)
                .HasColumnName("MOTA")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.THUTUSAPXEP)
                .HasColumnName("THUTUSAPXEP")
                .IsUnicode(false)
                .HasMaxLength(10);
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
            this.Property(t => t.DONVIHANHCHINHID)
                .HasColumnName("DONVIHANHCHINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.CAPTOCHUC)
                .HasColumnName("CAPTOCHUC");
            this.Property(t => t.MATOCHUC)
                .HasColumnName("MATOCHUC")
                .IsUnicode(false)
                .HasMaxLength(30);

            this.ToTable("HT_TOCHUC");
        }
    }
}
