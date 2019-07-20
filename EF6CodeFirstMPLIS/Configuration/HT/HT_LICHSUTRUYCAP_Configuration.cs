namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HT_LICHSUTRUYCAP_Configuration : EntityTypeConfiguration<HT_LICHSUTRUYCAP>
    {
        public HT_LICHSUTRUYCAP_Configuration()
        {
            this.HasKey(t => t.LICHSUTRUYCAPID);

            this.Property(t => t.LICHSUTRUYCAPID)
                .HasColumnName("LICHSUTRUYCAPID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOIDUNGID)
                .HasColumnName("NGUOIDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NAM)
                .HasColumnName("NAM");
            this.Property(t => t.LOAIHANHDONG)
                .HasColumnName("LOAIHANHDONG")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.MOTA)
                .HasColumnName("MOTA")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.uId)
                .HasColumnName("uId")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.THOIDIEMKHOITAO)
                .HasColumnName("THOIDIEMKHOITAO");
            this.Property(t => t.THOIDIEMCAPNHAT)
                .HasColumnName("THOIDIEMCAPNHAT");
            this.Property(t => t.NGUOICAPNHATID)
                .HasColumnName("NGUOICAPNHATID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<HT_NGUOIDUNG>(t => t.HT_NGUOIDUNG)
                .WithMany(m => m.HT_LICHSUTRUYCAP)
                .HasForeignKey(m => m.NGUOIDUNGID);

            this.ToTable("HT_LICHSUTRUYCAP");

        }
    }
}
