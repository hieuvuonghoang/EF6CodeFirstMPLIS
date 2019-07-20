namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class CS_NHACUNGCAP_Configuration : EntityTypeConfiguration<CS_NHACUNGCAP>
    {
        public CS_NHACUNGCAP_Configuration()
        {
            this.HasKey(t => t.NHACUNGCAPID);

            this.Property(t => t.NHACUNGCAPID)
                .HasColumnName("NHACUNGCAPID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENNHACUNGCAP)
                .HasColumnName("TENNHACUNGCAP")
                .IsUnicode(false)
                .HasMaxLength(100);
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
            this.Property(t => t.ROOTCA)
                .HasColumnName("ROOTCA");

            this.ToTable("CS_NHACUNGCAP");
        }
    }
}
