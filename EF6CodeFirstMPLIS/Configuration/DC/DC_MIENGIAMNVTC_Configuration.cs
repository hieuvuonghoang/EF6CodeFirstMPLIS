namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_MIENGIAMNVTC_Configuration : EntityTypeConfiguration<DC_MIENGIAMNVTC>
    {
        public DC_MIENGIAMNVTC_Configuration()
        {
            this.HasKey(t => t.MIENGIAMNVTCID);

            this.Property(t => t.MIENGIAMNVTCID)
                .HasColumnName("MIENGIAMNVTCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGHIAVUTAICHINHID)
                .HasColumnName("NGHIAVUTAICHINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LOAICHEDOMIENGIAMID)
                .HasColumnName("LOAICHEDOMIENGIAMID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.SOTIENMIENGIAM)
                .HasColumnName("SOTIENMIENGIAM");
            this.Property(t => t.SOQUYETDINHMIENGIAM)
                .HasColumnName("SOQUYETDINHMIENGIAM")
                .IsUnicode(false)
                .HasMaxLength(15);
            this.Property(t => t.NGAYRAQUYETDINHMIENGIAM)
                .HasColumnName("NGAYRAQUYETDINHMIENGIAM");
            this.Property(t => t.COQUANRAQUYETDINHMIENGIAM)
                .HasColumnName("COQUANRAQUYETDINHMIENGIAM")
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
            this.Property(t => t.LOAIDTMIENGIAMID)
                .HasColumnName("LOAIDTMIENGIAMID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LOAINGHIAVUTAICHINHID)
                .HasColumnName("LOAINGHIAVUTAICHINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TYLEMIENGIAM)
                .HasColumnName("TYLEMIENGIAM");
            this.Property(t => t.THOIGIANMIENGIAM)
                .HasColumnName("THOIGIANMIENGIAM");
            this.Property(t => t.NGUOIID)
                .HasColumnName("NGUOIID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<DC_NGUOI>(t => t.DC_NGUOI)
                .WithMany(m => m.DC_MIENGIAMNVTC)
                .HasForeignKey(m => m.NGUOIID);
            this.HasRequired<DM_LOAINGHIAVUTAICHINH>(t => t.DM_LOAINGHIAVUTAICHINH)
                .WithMany(m => m.DC_MIENGIAMNVTC)
                .HasForeignKey(m => m.LOAINGHIAVUTAICHINHID);
            this.HasRequired<DM_LOAIDTMIENGIAM>(t => t.DM_LOAIDTMIENGIAM)
                .WithMany(m => m.DC_MIENGIAMNVTC)
                .HasForeignKey(m => m.LOAIDTMIENGIAMID);
            this.HasRequired<DC_NGHIAVUTAICHINH>(t => t.DC_NGHIAVUTAICHINH)
                .WithMany(m => m.DC_MIENGIAMNVTC)
                .HasForeignKey(m => m.NGHIAVUTAICHINHID);

            this.ToTable("DC_MIENGIAMNVTC");
        }
    }
}
