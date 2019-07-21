namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_DONDANGKY_Configuration : EntityTypeConfiguration<DC_DONDANGKY>
    {
        public DC_DONDANGKY_Configuration()
        {
            this.HasKey(t => t.DONDANGKYID);

            this.Property(t => t.DONDANGKYID)
                .HasColumnName("DONDANGKYID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MADON)
                .HasColumnName("MADON")
                .IsUnicode(false)
                .HasMaxLength(100);
            this.Property(t => t.NGAYDANGKY)
                .HasColumnName("NGAYDANGKY");
            this.Property(t => t.GHICHU)
                .HasColumnName("GHICHU")
                .IsUnicode(false)
                .HasMaxLength(1000);
            this.Property(t => t.DACAPGIAY)
                .HasColumnName("DACAPGIAY")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.CANCUPHAPLY)
                .HasColumnName("CANCUPHAPLY")
                .IsUnicode(false)
                .HasMaxLength(30);
            this.Property(t => t.SOVAOSO)
                .HasColumnName("SOVAOSO")
                .IsUnicode(false)
                .HasMaxLength(10);
            this.Property(t => t.NGAYCAP)
                .HasColumnName("NGAYCAP");
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
            this.Property(t => t.HOSOTIEPNHANID)
                .HasColumnName("HOSOTIEPNHANID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.ToTable("DC_DONDANGKY");
        }
    }
}
