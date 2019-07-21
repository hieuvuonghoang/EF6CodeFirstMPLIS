namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_YKIENXACNHAN_Configuration : EntityTypeConfiguration<DC_YKIENXACNHAN>
    {
        public DC_YKIENXACNHAN_Configuration()
        {
            this.HasKey(t => t.YKIENXACNHANID);

            this.Property(t => t.YKIENXACNHANID)
                .HasColumnName("YKIENXACNHANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.XACNHANDONDANGKYID)
                .HasColumnName("XACNHANDONDANGKYID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LOAIYKIEN)
                .HasColumnName("LOAIYKIEN")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.NOIDUNGYKIEN)
                .HasColumnName("NOIDUNGYKIEN")
                .IsUnicode(false)
                .HasMaxLength(2000);
            this.Property(t => t.uId)
                .HasColumnName("uId")
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

            this.HasRequired<DC_XACNHANDONDANGKY>(t => t.DC_XACNHANDONDANGKY)
                .WithMany(m => m.DC_YKIENXACNHAN)
                .HasForeignKey(m => m.XACNHANDONDANGKYID);

            this.ToTable("DC_YKIENXACNHAN");
        }
    }
}
