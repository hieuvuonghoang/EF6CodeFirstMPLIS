namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HT_TOCHUC_NHOMCHUCNANG_Configuration : EntityTypeConfiguration<HT_TOCHUC_NHOMCHUCNANG>
    {
        public HT_TOCHUC_NHOMCHUCNANG_Configuration()
        {
            this.HasKey(t => t.TOCHUCNHOMCHUCNANGID);

            this.Property(t => t.TOCHUCNHOMCHUCNANGID)
                .HasColumnName("TOCHUCNHOMCHUCNANGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TOCHUCID)
                .HasColumnName("TOCHUCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NHOMCHUCNANGID)
                .HasColumnName("NHOMCHUCNANGID")
                .IsUnicode(false)
                .HasMaxLength(36);
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

            this.HasRequired<HT_NHOMCHUCNANG>(t => t.HT_NHOMCHUCNANG)
                .WithMany(m => m.HT_TOCHUC_NHOMCHUCNANG)
                .HasForeignKey(m => m.NHOMCHUCNANGID);
            this.HasRequired<HT_TOCHUC>(t => t.HT_TOCHUC)
                .WithMany(m => m.HT_TOCHUC_NHOMCHUCNANG)
                .HasForeignKey(m => m.TOCHUCID);

            this.ToTable("HT_TOCHUC_NHOMCHUCNANG");
        }
    }
}
