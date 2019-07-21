namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_GCN_TILESH_Configuration : EntityTypeConfiguration<DC_GCN_TILESH>
    {
        public DC_GCN_TILESH_Configuration()
        {
            this.HasKey(t => t.GCNTILESHID);

            this.Property(t => t.GCNTILESHID)
                .HasColumnName("GCNTILESHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TILESOHUU)
                .HasColumnName("TILESOHUU");
            this.Property(t => t.GIAYCHUNGNHANID)
                .HasColumnName("GIAYCHUNGNHANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOIID)
                .HasColumnName("NGUOIID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THANHVIENID)
                .HasColumnName("THANHVIENID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LOAIDTMIENGIAMID)
                .HasColumnName("LOAIDTMIENGIAMID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<DC_GIAYCHUNGNHAN>(t => t.DC_GIAYCHUNGNHAN)
                .WithMany(m => m.DC_GCN_TILESH)
                .HasForeignKey(m => m.GIAYCHUNGNHANID);
            this.HasRequired<DC_NGUOI>(t => t.DC_NGUOI)
                .WithMany(m => m.DC_GCN_TILESH)
                .HasForeignKey(m => m.NGUOIID);
            this.HasRequired<DM_LOAIDTMIENGIAM>(t => t.DM_LOAIDTMIENGIAM)
                .WithMany(m => m.DC_GCN_TILESH)
                .HasForeignKey(m => m.LOAIDTMIENGIAMID);

            this.ToTable("DC_GCN_TILESH");
        }
    }
}
