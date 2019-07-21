namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_BD_CHU_Configuration : EntityTypeConfiguration<DC_BD_CHU>
    {
        public DC_BD_CHU_Configuration()
        {
            this.HasKey(t => t.BDCHUID);

            this.Property(t => t.BDCHUID)
                .HasColumnName("BDGCNID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOIID)
                .HasColumnName("NGUOIID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.BIENDONGID)
                .HasColumnName("BIENDONGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.VAITROCHU)
                .HasColumnName("VAITROCHU")
                .IsUnicode(false)
                .HasMaxLength(1);

            this.HasRequired<DC_BIENDONG>(t => t.DC_BIENDONG)
                .WithMany(m => m.DC_BD_CHU)
                .HasForeignKey(m => m.BIENDONGID);
            this.HasRequired<DC_NGUOI>(t => t.DC_NGUOI)
                .WithMany(m => m.DC_BD_CHU)
                .HasForeignKey(m => m.NGUOIID);

            this.ToTable("DC_BD_CHU");

        }
    }
}
