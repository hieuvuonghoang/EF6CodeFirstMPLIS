namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class CS_GIAYTOXACMINH_Configuration : EntityTypeConfiguration<CS_GIAYTOXACMINH>
    {
        public CS_GIAYTOXACMINH_Configuration()
        {
            this.HasKey(t => t.GIAYTOXACMINHID);

            this.Property(t => t.GIAYTOXACMINHID)
                .HasColumnName("GIAYTOXACMINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.CHUKYSOID)
                .HasColumnName("CHUKYSOID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THOIDIEMNOPXACMINH)
                .HasColumnName("THOIDIEMNOPXACMINH");
            this.Property(t => t.FILESCAN)
                .HasColumnName("FILESCAN");
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
            this.Property(t => t.TENGIAYTO)
                .HasColumnName("TENGIAYTO")
                .IsUnicode(false)
                .HasMaxLength(150);

            this.HasRequired<CS_CHUKYSO>(t => t.CS_CHUKYSO)
                .WithMany(m => m.CS_GIAYTOXACMINH)
                .HasForeignKey(m => m.CHUKYSOID);

            this.ToTable("CS_GIAYTOXACMINH");
        }
    }
}
