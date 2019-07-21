namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_LOAINGHIAVUTAICHINH_Configuration : EntityTypeConfiguration<DC_LOAINGHIAVUTAICHINH>
    {
        public DC_LOAINGHIAVUTAICHINH_Configuration()
        {
            this.HasKey(t => t.LOAINGHIAVUTAICHINHID);

            this.Property(t => t.LOAINGHIAVUTAICHINHID)
                .HasColumnName("LOAINGHIAVUTAICHINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENLOAINGHIAVUTAICHINH)
                .HasColumnName("TENLOAINGHIAVUTAICHINH")
                .IsUnicode(false)
                .HasMaxLength(200);
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

            this.ToTable("DC_LOAINGHIAVUTAICHINH");
        }
    }
}
