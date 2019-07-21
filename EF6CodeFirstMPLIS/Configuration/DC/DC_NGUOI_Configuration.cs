namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_NGUOI_Configuration : EntityTypeConfiguration<DC_NGUOI>
    {
        public DC_NGUOI_Configuration()
        {
            this.HasKey(t => t.NGUOIID);

            this.Property(t => t.NGUOIID)
                .HasColumnName("NGUOIID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.CHITIETID)
                .HasColumnName("CHITIETID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LOAIDOITUONGID)
                .HasColumnName("LOAIDOITUONGID")
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
            this.Property(t => t.DOITUONGSUDUNGID)
                .HasColumnName("DOITUONGSUDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MADINHDANH)
                .HasColumnName("MADINHDANH")
                .IsUnicode(false)
                .HasMaxLength(20);
            this.Property(t => t.MASOTHUE)
                .HasColumnName("MASOTHUE")
                .IsUnicode(false)
                .HasMaxLength(20);

            this.HasRequired<DM_DOITUONGSUDUNG>(t => t.DM_DOITUONGSUDUNG)
                .WithMany(m => m.DC_NGUOI)
                .HasForeignKey(m => m.DOITUONGSUDUNGID);

            this.ToTable("DC_NGUOI");
        }
    }
}
