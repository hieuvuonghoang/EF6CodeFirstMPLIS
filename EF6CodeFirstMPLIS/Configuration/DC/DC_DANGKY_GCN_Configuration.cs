namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_DANGKY_GCN_Configuration : EntityTypeConfiguration<DC_DANGKY_GCN>
    {
        public DC_DANGKY_GCN_Configuration()
        {
            this.HasKey(t => t.DANGKYGCNID);

            this.Property(t => t.DANGKYGCNID)
                .HasColumnName("DANGKYGCNID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.DONDANGKYID)
                .HasColumnName("DONDANGKYID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.GIAYCHUNGNHANID)
                .HasColumnName("GIAYCHUNGNHANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THOIDIEMKHOITAO)
                .HasColumnName("THOIDIEMKHOITAO");
            this.Property(t => t.THOIDIEMCAPNHAT)
                .HasColumnName("THOIDIEMCAPNHAT");
            this.Property(t => t.NGUOICAPNHATID)
                .HasColumnName("NGUOICAPNHATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.uId)
                .HasColumnName("uId")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<DC_DONDANGKY>(t => t.DC_DONDANGKY)
                .WithMany(m => m.DC_DANGKY_GCN)
                .HasForeignKey(m => m.DONDANGKYID);
            this.HasRequired<DC_GIAYCHUNGNHAN>(t => t.DC_GIAYCHUNGNHAN)
                .WithMany(m => m.DC_DANGKY_GCN)
                .HasForeignKey(m => m.GIAYCHUNGNHANID);

            this.ToTable("DC_DANGKY_GCN");
        }
    }
}
