namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_GTKEMTHEO_Configuration : EntityTypeConfiguration<DC_GTKEMTHEO>
    {
        public DC_GTKEMTHEO_Configuration()
        {
            this.HasKey(t => t.GTKEMTHEOID);

            this.Property(t => t.GTKEMTHEOID)
                .HasColumnName("GTKEMTHEOID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENGIAYTO)
                .HasColumnName("TENGIAYTO")
                .IsUnicode(false)
                .HasMaxLength(200);
            this.Property(t => t.FILEDINHKEM)
                .HasColumnName("FILEDINHKEM")
                .IsUnicode(false)
                .HasMaxLength(2000);
            this.Property(t => t.TENFILE)
                .HasColumnName("TENFILE")
                .IsUnicode(false)
                .HasMaxLength(200);
            this.Property(t => t.NGHIAVUTAICHINHID)
                .HasColumnName("NGHIAVUTAICHINHID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<DC_NGHIAVUTAICHINH>(t => t.DC_NGHIAVUTAICHINH)
                .WithMany(m => m.DC_GTKEMTHEO)
                .HasForeignKey(m => m.NGHIAVUTAICHINHID);

            this.ToTable("DC_GTKEMTHEO");
        }
    }
}
