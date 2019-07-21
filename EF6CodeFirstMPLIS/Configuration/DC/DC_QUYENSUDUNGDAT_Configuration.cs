namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_QUYENSUDUNGDAT_Configuration : EntityTypeConfiguration<DC_QUYENSUDUNGDAT>
    {
        public DC_QUYENSUDUNGDAT_Configuration()
        {
            this.HasKey(t => t.QUYENSUDUNGDATID);

            this.Property(t => t.QUYENSUDUNGDATID)
                .HasColumnName("QUYENSUDUNGDATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOIID)
                .HasColumnName("NGUOIID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THUADATID)
                .HasColumnName("THUADATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MUCDICHSUDUNGDATID)
                .HasColumnName("MUCDICHSUDUNGDATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.GIAYCHUNGNHANID)
                .HasColumnName("GIAYCHUNGNHANID")
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
            this.Property(t => t.DONDANGKYID)
                .HasColumnName("DONDANGKYID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LAQUYENQUANLY)
                .HasColumnName("LAQUYENQUANLY")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.TRANGTHAIPL)
                .HasColumnName("TRANGTHAIPL")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.NGAYDANGKYTC)
                .HasColumnName("NGAYDANGKYTC");
            this.Property(t => t.BDTHECHAPID)
                .HasColumnName("BDTHECHAPID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.QUYENSDDGOCID)
                .HasColumnName("QUYENSDDGOCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TILESOHUU)
                .HasColumnName("TILESOHUU");

            this.HasRequired<DC_BD_THECHAP>(t => t.DC_BD_THECHAP)
                .WithMany(m => m.DC_QUYENSUDUNGDAT)
                .HasForeignKey(m => m.BDTHECHAPID);
            this.HasRequired<DC_MUCDICHSUDUNGDAT>(t => t.DC_MUCDICHSUDUNGDAT)
                .WithMany(m => m.DC_QUYENSUDUNGDAT)
                .HasForeignKey(m => m.MUCDICHSUDUNGDATID);
            this.HasRequired<DC_NGUOI>(t => t.DC_NGUOI)
                .WithMany(m => m.DC_QUYENSUDUNGDAT)
                .HasForeignKey(m => m.NGUOIID);

            this.ToTable("DC_QUYENSUDUNGDAT");
        }
    }
}