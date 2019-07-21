namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_BD_CHUYENHTSDD_Configuration : EntityTypeConfiguration<DC_BD_CHUYENHTSDD>
    {
        public DC_BD_CHUYENHTSDD_Configuration()
        {
            this.HasKey(t => t.BDCHUYENHTSDDID);

            this.Property(t => t.BDCHUYENHTSDDID)
                .HasColumnName("BDCHUYENHTSDDID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.HINHTHUCSUDUNGID)
                .HasColumnName("HINHTHUCSUDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.BIENDONGID)
                .HasColumnName("BIENDONGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LAHTSDDTRUOCKHICHUYEN)
                .HasColumnName("LAHTSDDTRUOCKHICHUYEN")
                .IsUnicode(false)
                .HasMaxLength(1);

            this.HasRequired<DC_BIENDONG>(t => t.DC_BIENDONG)
                .WithMany(m => m.DC_BD_CHUYENHTSDD)
                .HasForeignKey(m => m.BIENDONGID);
            this.HasRequired<DM_HINHTHUCSUDUNGDAT>(t => t.DM_HINHTHUCSUDUNGDAT)
                .WithMany(m => m.DC_BD_CHUYENHTSDD)
                .HasForeignKey(m => m.HINHTHUCSUDUNGID);

            this.ToTable("DC_BD_CHUYENHTSDD");
        }
    }
}