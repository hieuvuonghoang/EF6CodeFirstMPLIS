namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HT_CHUCNANG_NHOMCHUCNANG_Configuration : EntityTypeConfiguration<HT_CHUCNANG_NHOMCHUCNANG>
    {
        public HT_CHUCNANG_NHOMCHUCNANG_Configuration()
        {
            this.HasKey(t => t.CHUCNANGNHOMCHUCNANGID);

            this.Property(t => t.CHUCNANGNHOMCHUCNANGID)
                .HasColumnName("CHUCNANGNHOMCHUCNANGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NHOMCHUCNANGID)
                .HasColumnName("NHOMCHUCNANGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.CHUCNANGID)
                .HasColumnName("CHUCNANGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.uId)
                .HasColumnName("uId")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOICAPNHATID)
                .HasColumnName("NGUOICAPNHATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THOIDIEMKHOITAO)
                .HasColumnName("THOIDIEMKHOITAO");
            this.Property(t => t.THOIDIEMCAPNHAT)
                .HasColumnName("THOIDIEMCAPNHAT");

            this.HasRequired<HT_CHUCNANG>(t => t.HT_CHUCNANG)
                .WithMany(m => m.HT_CHUCNANG_NHOMCHUCNANG)
                .HasForeignKey(m => m.CHUCNANGID);
            this.HasRequired<HT_NHOMCHUCNANG>(t => t.HT_NHOMCHUCNANG)
                .WithMany(m => m.HT_CHUCNANG_NHOMCHUCNANG)
                .HasForeignKey(m => m.NHOMCHUCNANGID);

            this.ToTable("HT_CHUCNANG_NHOMCHUCNANG");
        }
    }
}
