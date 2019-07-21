namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HT_NHOMCHUCNANG_Configuration : EntityTypeConfiguration<HT_NHOMCHUCNANG>
    {
        public HT_NHOMCHUCNANG_Configuration()
        {
            this.HasKey(t => t.NHOMCHUCNANGID);

            this.Property(t => t.NHOMCHUCNANGID)
                .HasColumnName("NHOMCHUCNANGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.UNGDUNGID)
                .HasColumnName("UNGDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.URL)
                .HasColumnName("URL")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.TENNHOM)
                .HasColumnName("TENNHOM")
                .IsUnicode(false)
                .HasMaxLength(255);
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

            this.HasRequired<HT_UNGDUNG>(t => t.HT_UNGDUNG)
                .WithMany(m => m.HT_NHOMCHUCNANG)
                .HasForeignKey(m => m.UNGDUNGID);

            this.ToTable("HT_NHOMCHUCNANG");
        }
    }
}
