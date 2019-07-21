namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_GIAYCHUNGNHAN_Configuration : EntityTypeConfiguration<DC_GIAYCHUNGNHAN>
    {
        public DC_GIAYCHUNGNHAN_Configuration()
        {
            this.HasKey(t => t.GIAYCHUNGNHANID);

            this.Property(t => t.GIAYCHUNGNHANID)
                .HasColumnName("GIAYCHUNGNHANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.SOPHATHANH)
                .HasColumnName("SOPHATHANH")
                .IsUnicode(false)
                .HasMaxLength(20);
            this.Property(t => t.MAVACH)
                .HasColumnName("MAVACH")
                .IsUnicode(false)
                .HasMaxLength(25);
            this.Property(t => t.BANQUET)
                .HasColumnName("BANQUET")
                .IsUnicode(false)
                .HasMaxLength(2000);
            this.Property(t => t.NGUOIID)
                .HasColumnName("NGUOIID")
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
            this.Property(t => t.SOVAOSO)
                .HasColumnName("SOVAOSO")
                .IsUnicode(false)
                .HasMaxLength(10);
            this.Property(t => t.NGAYCAP)
                .HasColumnName("NGAYCAP");
            this.Property(t => t.TRANGTHAIXULY)
                .HasColumnName("TRANGTHAIXULY")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.TRANGTHAIPL)
                .HasColumnName("TRANGTHAIPL")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.MAXA)
                .HasColumnName("MAXA")
                .IsUnicode(false)
                .HasMaxLength(5);
            this.Property(t => t.HSKTFILEPATH)
                .HasColumnName("HSKTFILEPATH")
                .IsUnicode(false)
                .HasMaxLength(500);
            this.Property(t => t.GHICHU)
                .HasColumnName("GHICHU")
                .IsUnicode(false)
                .HasMaxLength(2000);
            this.Property(t => t.SOHUUCHUNGID)
                .HasColumnName("SOHUUCHUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TOCHUCID)
                .HasColumnName("CHUKYSOID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NONVTC)
                .HasColumnName("NONVTC")
                .IsUnicode(false)
                .HasMaxLength(1);

            this.HasRequired<DC_NGUOI>(t => t.DC_NGUOI)
                .WithMany(m => m.DC_GIAYCHUNGNHAN)
                .HasForeignKey(m => m.NGUOIID);
            this.HasRequired<HT_TOCHUC>(t => t.HT_TOCHUC)
                .WithMany(m => m.DC_GIAYCHUNGNHAN)
                .HasForeignKey(m => m.TOCHUCID);

            this.ToTable("DC_GIAYCHUNGNHAN");
        }
    }
}
