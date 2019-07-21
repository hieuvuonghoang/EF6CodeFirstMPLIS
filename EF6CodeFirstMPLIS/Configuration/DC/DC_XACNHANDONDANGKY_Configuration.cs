namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_XACNHANDONDANGKY_Configuration : EntityTypeConfiguration<DC_XACNHANDONDANGKY>
    {
        public DC_XACNHANDONDANGKY_Configuration()
        {
            this.HasKey(t => t.XACNHANDONDANGKYID);

            this.Property(t => t.XACNHANDONDANGKYID)
                .HasColumnName("XACNHANDONDANGKYID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.DONDANGKYID)
                .HasColumnName("DONDANGKYID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.CAPXACNHAN)
                .HasColumnName("CAPXACNHAN");
            this.Property(t => t.DONVIHANHCHINHID)
                .HasColumnName("DONVIHANHCHINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENCOQUANXACNHAN)
                .HasColumnName("TENCOQUANXACNHAN")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.CANBOYKIENID)
                .HasColumnName("CANBOYKIENID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.CANBOKIEMTRAID)
                .HasColumnName("CANBOKIEMTRAID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.CANBOPHEDUYETID)
                .HasColumnName("CANBOPHEDUYETID")
                .IsUnicode(false)
                .HasMaxLength(36);
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

            this.HasRequired<DC_DONDANGKY>(t => t.DC_DONDANGKY)
                .WithMany(m => m.DC_XACNHANDONDANGKY)
                .HasForeignKey(m => m.DONDANGKYID);

            this.ToTable("DC_XACNHANDONDANGKY");
        }
    }
}
