namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_DANGKY_THUA_Configuration : EntityTypeConfiguration<DC_DANGKY_THUA>
    {
        public DC_DANGKY_THUA_Configuration()
        {
            this.HasKey(t => t.DANGKYTHUAID);

            this.Property(t => t.DANGKYTHUAID)
                .HasColumnName("DANGKYTHUAID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.DONDANGKYID)
                .HasColumnName("DONDANGKYID")
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
            this.Property(t => t.HINHTHUCSUDUNG)
                .HasColumnName("HINHTHUCSUDUNG");
            this.Property(t => t.THOIHANSUDUNG)
                .HasColumnName("THOIHANSUDUNG")
                .IsUnicode(false)
                .HasMaxLength(150);
            this.Property(t => t.QUYENHANCHE)
                .HasColumnName("QUYENHANCHE")
                .IsUnicode(false)
                .HasMaxLength(500);
            this.Property(t => t.THOIDIEMSUDUNGDAT)
                .HasColumnName("THOIDIEMSUDUNGDAT")
                .IsUnicode(false)
                .HasMaxLength(150);
            this.Property(t => t.DUDIEUKIENCAPGIAY)
                .HasColumnName("DUDIEUKIENCAPGIAY");
            this.Property(t => t.LYDOKHONGDUDIEUKIEN)
                .HasColumnName("LYDOKHONGDUDIEUKIEN")
                .IsUnicode(false)
                .HasMaxLength(1000);
            this.Property(t => t.THUADATID)
                .HasColumnName("THUADATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.SOTHUTHUTHUA)
                .HasColumnName("SOTHUTHUTHUA");
            this.Property(t => t.SOHIEUTOBANDO)
                .HasColumnName("SOHIEUTOBANDO");
            this.Property(t => t.XAID)
                .HasColumnName("XAID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MUCDICHSUDUNGDATID)
                .HasColumnName("MUCDICHSUDUNGDATID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<DC_DONDANGKY>(t => t.DC_DONDANGKY)
                .WithMany(m => m.DC_DANGKY_THUA)
                .HasForeignKey(m => m.DONDANGKYID);

            this.ToTable("DC_DANGKY_THUA");
        }
    }
}
