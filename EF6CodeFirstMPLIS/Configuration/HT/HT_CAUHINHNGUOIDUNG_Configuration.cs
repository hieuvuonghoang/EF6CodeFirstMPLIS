namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HT_CAUHINHNGUOIDUNG_Configuration : EntityTypeConfiguration<HT_CAUHINHNGUOIDUNG>
    {
        public HT_CAUHINHNGUOIDUNG_Configuration()
        {
            this.HasKey(t => t.CAUHINHNGUOIDUNGID);

            this.Property(t => t.CAUHINHNGUOIDUNGID)
                .HasColumnName("CAUHINHNGUOIDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOIDUNGID)
                .HasColumnName("NGUOIDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENCAUHINH)
                .HasColumnName("TENCAUHINH")
                .IsUnicode(false)
                .HasMaxLength(50);
            this.Property(t => t.GIATRI)
                .HasColumnName("GIATRI")
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

            this.HasRequired<HT_NGUOIDUNG>(t => t.HT_NGUOIDUNG)
                .WithMany(m => m.HT_CAUHINHNGUOIDUNG)
                .HasForeignKey(m => m.NGUOIDUNGID);

            this.ToTable("HT_CAUHINHNGUOIDUNG");
        }
    }
}
