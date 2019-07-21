namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HT_NHOMCHUCNANG_MENU_Configuration : EntityTypeConfiguration<HT_NHOMCHUCNANG_MENU>
    {
        public HT_NHOMCHUCNANG_MENU_Configuration()
        {
            this.HasKey(t => t.NHOMCHUCNANGMENUID);

            this.Property(t => t.NHOMCHUCNANGMENUID)
                .HasColumnName("NHOMCHUCNANGMENUID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MENUID)
                .HasColumnName("MENUID")
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

            this.HasRequired<HT_MENU>(t => t.HT_MENU)
                .WithMany(m => m.HT_NHOMCHUCNANG_MENU)
                .HasForeignKey(m => m.MENUID);
            this.HasRequired<HT_NHOMCHUCNANG>(t => t.HT_NHOMCHUCNANG)
                .WithMany(m => m.HT_NHOMCHUCNANG_MENU)
                .HasForeignKey(m => m.NHOMCHUCNANGID);

            this.ToTable("HT_NHOMCHUCNANG_MENU");
        }
    }
}
