namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_KHOANDUOCTRU_Configuration : EntityTypeConfiguration<DC_KHOANDUOCTRU>
    {
        public DC_KHOANDUOCTRU_Configuration()
        {
            this.HasKey(t => t.KHOANDUOCTRUID);

            this.Property(t => t.KHOANDUOCTRUID)
                .HasColumnName("KHOANDUOCTRUID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENKHOANDUOCTRU)
                .HasColumnName("TENKHOANDUOCTRU")
                .IsUnicode(false)
                .HasMaxLength(200);
            this.Property(t => t.SOTIEN)
                .HasColumnName("SOTIEN");
            this.Property(t => t.GHICHU)
                .HasColumnName("GHICHU")
                .IsUnicode(false)
                .HasMaxLength(200);
            this.Property(t => t.NGUOIID)
                .HasColumnName("NGUOIID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGHIAVUTAICHINHID)
                .HasColumnName("NGHIAVUTAICHINHID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<DC_NGUOI>(t => t.DC_NGUOI)
                .WithMany(m => m.DC_KHOANDUOCTRU)
                .HasForeignKey(m => m.NGUOIID);
            this.HasRequired<DC_NGHIAVUTAICHINH>(t => t.DC_NGHIAVUTAICHINH)
                .WithMany(m => m.DC_KHOANDUOCTRU)
                .HasForeignKey(m => m.NGHIAVUTAICHINHID);

            this.ToTable("DC_KHOANDUOCTRU");
        }
    }
}
