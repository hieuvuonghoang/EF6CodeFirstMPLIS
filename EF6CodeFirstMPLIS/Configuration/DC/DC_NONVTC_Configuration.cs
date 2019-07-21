namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_NONVTC_Configuration : EntityTypeConfiguration<DC_NONVTC>
    {
        public DC_NONVTC_Configuration()
        {
            this.HasKey(t => t.NONVTCID);

            this.Property(t => t.NONVTCID)
                .HasColumnName("NONVTCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.DIENTICH)
                .HasColumnName("DIENTICH");
            this.Property(t => t.NGAYGHINO)
                .HasColumnName("NGAYGHINO");
            this.Property(t => t.NOIDUNG)
                .HasColumnName("NOIDUNG")
                .IsUnicode(false)
                .HasMaxLength(2000);
            this.Property(t => t.NGUOIID)
                .HasColumnName("NGUOIID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LOAINGHIAVUTAICHINHID)
                .HasColumnName("LOAINGHIAVUTAICHINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.SOTIENNO)
                .HasColumnName("SOTIENNO");
            this.Property(t => t.NGHIAVUTAICHINHID)
                .HasColumnName("NGHIAVUTAICHINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.DATRA)
                .HasColumnName("DATRA")
                .IsUnicode(false)
                .HasMaxLength(1);

            this.HasRequired<DC_NGHIAVUTAICHINH>(t => t.DC_NGHIAVUTAICHINH)
                .WithMany(m => m.DC_NONVTC)
                .HasForeignKey(m => m.NGHIAVUTAICHINHID);
            this.HasRequired<DC_NGUOI>(t => t.DC_NGUOI)
                .WithMany(m => m.DC_NONVTC)
                .HasForeignKey(m => m.NGUOIID);
            this.HasRequired<DM_LOAINGHIAVUTAICHINH>(t => t.DM_LOAINGHIAVUTAICHINH)
                .WithMany(m => m.DC_NONVTC)
                .HasForeignKey(m => m.LOAINGHIAVUTAICHINHID);

            this.ToTable("DC_NONVTC");
        }
    }
}
