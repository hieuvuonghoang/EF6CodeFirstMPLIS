namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_BD_THECHAP_Configuration : EntityTypeConfiguration<DC_BD_THECHAP>
    {
        public DC_BD_THECHAP_Configuration()
        {
            this.HasKey(t => t.BDTHECHAPID);

            this.Property(t => t.BDTHECHAPID)
                .HasColumnName("BDTHECHAPID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGAYNHANHS)
                .HasColumnName("NGAYNHANHS");
            this.Property(t => t.NGAYTHECHAP)
                .HasColumnName("NGAYTHECHAP");
            this.Property(t => t.QUYENSO)
                .HasColumnName("QUYENSO");
            this.Property(t => t.SOTHUTU)
                .HasColumnName("SOTHUTU");
            this.Property(t => t.SODANGKY)
                .HasColumnName("SODANGKY");
            this.Property(t => t.NGAYBATDAU)
                .HasColumnName("NGAYBATDAU");
            this.Property(t => t.NGAYKETTHUC)
                .HasColumnName("NGAYKETTHUC");
            this.Property(t => t.BIENDONGID)
                .HasColumnName("BIENDONGID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<DC_BIENDONG>(t => t.DC_BIENDONG)
                .WithMany(m => m.DC_BD_THECHAP)
                .HasForeignKey(m => m.BIENDONGID);

            this.ToTable("DC_BD_THECHAP");
        }
    }
}