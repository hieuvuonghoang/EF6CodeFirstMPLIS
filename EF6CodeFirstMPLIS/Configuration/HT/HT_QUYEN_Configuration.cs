namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HT_QUYEN_Configuration : EntityTypeConfiguration<HT_QUYEN>
    {
        public HT_QUYEN_Configuration()
        {
            this.HasKey(t => t.QUYENID);

            this.Property(t => t.QUYENID)
                .HasColumnName("QUYENID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.CHUCNANGID)
                .HasColumnName("CHUCNANGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THUTUSAPXEP)
                .HasColumnName("THUTUSAPXEP")
                .IsUnicode(false)
                .HasMaxLength(15);
            this.Property(t => t.CONTROLLERNAME)
                .HasColumnName("CONTROLLERNAME")
                .IsUnicode(false)
                .HasMaxLength(150);
            this.Property(t => t.ACTIONNAME)
                .HasColumnName("ACTIONNAME")
                .IsUnicode(false)
                .HasMaxLength(150);
            this.Property(t => t.MOTA)
                .HasColumnName("MOTA")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.uId)
                .HasColumnName("uId")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THOIDIEMKHOITAO)
                .HasColumnName("THOIDIEMKHOITAO");
            this.Property(t => t.THOIDIEMCAPNHAT)
                .HasColumnName("THOIDIEMKHOITAO");
            this.Property(t => t.NGUOICAPNHATID)
                .HasColumnName("NGUOICAPNHATID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<HT_CHUCNANG>(t => t.HT_CHUCNANG)
                .WithMany(m => m.HT_QUYEN)
                .HasForeignKey(m => m.CHUCNANGID);

            this.ToTable("HT_QUYEN");
        }
    }
}
