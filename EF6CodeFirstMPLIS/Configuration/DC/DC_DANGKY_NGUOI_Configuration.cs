namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_DANGKY_NGUOI_Configuration : EntityTypeConfiguration<DC_DANGKY_NGUOI>
    {
        public DC_DANGKY_NGUOI_Configuration()
        {
            this.HasKey(t => t.DANGKYNGUOIID);

            this.Property(t => t.DANGKYNGUOIID)
                .HasColumnName("DANGKYNGUOIID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.DONDANGKYID)
                .HasColumnName("DONDANGKYID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOIID)
                .HasColumnName("NGUOIID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MOTATOMTAT)
                .HasColumnName("MOTATOMTAT")
                .IsUnicode(false)
                .HasMaxLength(150);
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
            this.Property(t => t.LOAI)
                .HasColumnName("LOAI");
            this.Property(t => t.DENGHIDANGKY)
                .HasColumnName("DENGHIDANGKY");
            this.Property(t => t.CONHUCAUGHINONVTC)
                .HasColumnName("CONHUCAUGHINONVTC");
            this.Property(t => t.DENGHIKHAC)
                .HasColumnName("DENGHIKHAC")
                .IsUnicode(false)
                .HasMaxLength(255);

            this.HasRequired<DC_DONDANGKY>(t => t.DC_DONDANGKY)
                .WithMany(m => m.DC_DANGKY_NGUOI)
                .HasForeignKey(m => m.DONDANGKYID);
            this.HasRequired<DC_NGUOI>(t => t.DC_NGUOI)
                .WithMany(m => m.DC_DANGKY_NGUOI)
                .HasForeignKey(m => m.NGUOIID);

            this.ToTable("DC_DANGKY_NGUOI");
        }
    }
}
