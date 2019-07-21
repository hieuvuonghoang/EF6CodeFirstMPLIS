namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HT_CHUCNANG_Configuration : EntityTypeConfiguration<HT_CHUCNANG>
    {
        public HT_CHUCNANG_Configuration()
        {
            this.HasKey(t => t.CHUCNANGID);

            this.Property(t => t.CHUCNANGID)
                .HasColumnName("CHUCNANGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.KHOACHAID)
                .HasColumnName("KHOACHAID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MACHUCNANG)
                .HasColumnName("MACHUCNANG")
                .IsUnicode(false)
                .HasMaxLength(30);
            this.Property(t => t.TENCHUCNANG)
                .HasColumnName("TENCHUCNANG")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.URL)
                .HasColumnName("URL")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.MOTA)
                .HasColumnName("MOTA")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.THUTUSAPXEP)
                .HasColumnName("THUTUSAPXEP")
                .IsUnicode(false)
                .HasMaxLength(15);
            this.Property(t => t.CHOPHEPSUDUNG)
                .HasColumnName("CHOPHEPSUDUNG")
                .IsUnicode(false)
                .HasMaxLength(1);
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
            this.Property(t => t.THUCHIENTHUCONG)
                .HasColumnName("THUCHIENTHUCONG");
            this.Property(t => t.CACBIENDAUVAO)
                .HasColumnName("CACBIENDAUVAO")
                .IsUnicode(false)
                .HasMaxLength(120);
            this.Property(t => t.CACBIENDAURA)
                .HasColumnName("CACBIENDAURA")
                .IsUnicode(false)
                .HasMaxLength(120);

            this.HasRequired<HT_CHUCNANG>(t => t.HT_CHUCNANG2)
                .WithMany(m => m.HT_CHUCNANG1)
                .HasForeignKey(m => m.KHOACHAID);

            this.ToTable("HT_CHUCNANG");
        }
    }
}
