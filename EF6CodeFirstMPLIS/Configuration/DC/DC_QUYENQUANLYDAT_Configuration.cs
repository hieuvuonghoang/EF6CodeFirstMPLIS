namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_QUYENQUANLYDAT_Configuration : EntityTypeConfiguration<DC_QUYENQUANLYDAT>
    {
        public DC_QUYENQUANLYDAT_Configuration()
        {
            this.HasKey(t => t.QUYENQUANLYDATID);

            this.Property(t => t.QUYENQUANLYDATID)
                .HasColumnName("QUYENQUANLYDATID")
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
            this.Property(t => t.MUCDICHSUDUNGID)
                .HasColumnName("MUCDICHSUDUNGID")
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
            this.Property(t => t.GIAYCHUNGNHANID)
                .HasColumnName("GIAYCHUNGNHANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.BDTHECHAPID)
                .HasColumnName("BDTHECHAPID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.QUYENQLDATGOCID)
                .HasColumnName("QUYENQLDATGOCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGAYDANGKYTC)
                .HasColumnName("NGAYDANGKYTC");
            this.Property(t => t.TRANGTHAIPL)
                .HasColumnName("TRANGTHAIPL")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TILESOHUU)
                .HasColumnName("TILESOHUU");

            this.HasRequired<DC_BD_THECHAP>(t => t.DC_BD_THECHAP)
                .WithMany(m => m.DC_QUYENQUANLYDAT)
                .HasForeignKey(m => m.BDTHECHAPID);
            this.HasRequired<DC_GIAYCHUNGNHAN>(t => t.DC_GIAYCHUNGNHAN)
                .WithMany(m => m.DC_QUYENQUANLYDAT)
                .HasForeignKey(m => m.GIAYCHUNGNHANID);
            this.HasRequired<DC_MUCDICHSUDUNGDAT>(t => t.DC_MUCDICHSUDUNGDAT)
                .WithMany(m => m.DC_QUYENQUANLYDAT)
                .HasForeignKey(m => m.MUCDICHSUDUNGID);
            this.HasRequired<DC_NGUOI>(t => t.DC_NGUOI)
                .WithMany(m => m.DC_QUYENQUANLYDAT)
                .HasForeignKey(m => m.NGUOIID);

            this.ToTable("DC_QUYENQUANLYDAT");
        }
    }
}