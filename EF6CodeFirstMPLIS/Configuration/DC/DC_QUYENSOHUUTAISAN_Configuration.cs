namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_QUYENSOHUUTAISAN_Configuration : EntityTypeConfiguration<DC_QUYENSOHUUTAISAN>
    {
        public DC_QUYENSOHUUTAISAN_Configuration()
        {
            this.HasKey(t => t.QUYENSOHUUTAISANID);

            this.Property(t => t.QUYENSOHUUTAISANID)
                .HasColumnName("QUYENSOHUUTAISANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOIID)
                .HasColumnName("NGUOIID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TAISANGANLIENVOIDATID)
                .HasColumnName("TAISANGANLIENVOIDATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.GIAYCHUNGNHANID)
                .HasColumnName("GIAYCHUNGNHANID")
                .IsUnicode(false)
                .HasMaxLength(1);
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
            this.Property(t => t.NGUOICAPNHATID)
                .HasColumnName("NGUOICAPNHATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.DONDANGKYID)
                .HasColumnName("DONDANGKYID")
                .IsUnicode(false)
                .HasMaxLength(36);
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
            this.Property(t => t.QUYENSHTSGOCID)
                .HasColumnName("QUYENSHTSGOCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TILESOHUU)
                .HasColumnName("TILESOHUU");

            this.HasRequired<DC_BD_THECHAP>(t => t.DC_BD_THECHAP)
                .WithMany(m => m.DC_QUYENSOHUUTAISAN)
                .HasForeignKey(m => m.BDTHECHAPID);
            this.HasRequired<DC_GIAYCHUNGNHAN>(t => t.DC_GIAYCHUNGNHAN)
                .WithMany(m => m.DC_QUYENSOHUUTAISAN)
                .HasForeignKey(m => m.GIAYCHUNGNHANID);
            this.HasRequired<DC_NGUOI>(t => t.DC_NGUOI)
                .WithMany(m => m.DC_QUYENSOHUUTAISAN)
                .HasForeignKey(m => m.NGUOIID)
                .WillCascadeOnDelete(false);
            this.HasRequired<DC_TAISANGANLIENVOIDAT>(t => t.DC_TAISANGANLIENVOIDAT)
                .WithMany(m => m.DC_QUYENSOHUUTAISAN)
                .HasForeignKey(m => m.TAISANGANLIENVOIDATID);

            this.ToTable("DC_QUYENSOHUUTAISAN");
        }
    }
}
