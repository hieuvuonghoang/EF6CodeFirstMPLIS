namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_BD_GCN_Configuration : EntityTypeConfiguration<DC_BD_GCN>
    {
        public DC_BD_GCN_Configuration()
        {
            this.HasKey(t => t.BDGCNID);

            this.Property(t => t.BDGCNID)
                .HasColumnName("BDGCNID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.GIAYCHUNGNHANID)
                .HasColumnName("GIAYCHUNGNHANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.BIENDONGID)
                .HasColumnName("BIENDONGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LAGCNVAO)
                .HasColumnName("LAGCNVAO")
                .IsUnicode(false)
                .HasMaxLength(1);

            this.HasRequired<DC_BIENDONG>(t => t.DC_BIENDONG)
                .WithMany(m => m.DC_BD_GCN)
                .HasForeignKey(m => m.BIENDONGID);
            this.HasRequired<DC_GIAYCHUNGNHAN>(t => t.DC_GIAYCHUNGNHAN)
                .WithMany(m => m.DC_BD_GCN)
                .HasForeignKey(m => m.GIAYCHUNGNHANID);

            this.ToTable("DC_BD_GCN");
        }
    }
}
