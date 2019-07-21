namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DM_LOAINGHIAVUTAICHINH_Configuration : EntityTypeConfiguration<DM_LOAINGHIAVUTAICHINH>
    {
        public DM_LOAINGHIAVUTAICHINH_Configuration()
        {
            this.HasKey(t => t.LOAINGHIAVUTAICHINHID);

            this.Property(t => t.LOAINGHIAVUTAICHINHID)
                .HasColumnName("LOAINGHIAVUTAICHINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENNGHIAVUTAICHINH)
                .HasColumnName("TENNGHIAVUTAICHINH")
                .IsUnicode(false)
                .HasMaxLength(200);
            this.Property(t => t.GHICHU)
                .HasColumnName("GHICHU")
                .IsUnicode(false)
                .HasMaxLength(200);

            this.ToTable("DM_LOAINGHIAVUTAICHINH");
        }
    }
}
