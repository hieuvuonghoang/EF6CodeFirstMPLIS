namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DM_LOAIDTMIENGIAM_Configuration : EntityTypeConfiguration<DM_LOAIDTMIENGIAM>
    {
        public DM_LOAIDTMIENGIAM_Configuration()
        {
            this.HasKey(t => t.LOAIDTMIENGIAMID);

            this.Property(t => t.LOAIDTMIENGIAMID)
                .HasColumnName("LOAIDTMIENGIAMID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENLOAIDOITUONG)
                .HasColumnName("TENLOAIDOITUONG")
                .IsUnicode(false)
                .HasMaxLength(200);
            this.Property(t => t.GHICHU)
                .HasColumnName("GHICHU")
                .IsUnicode(false)
                .HasMaxLength(200);

            this.ToTable("DM_LOAIDTMIENGIAM");
        }
    }
}
