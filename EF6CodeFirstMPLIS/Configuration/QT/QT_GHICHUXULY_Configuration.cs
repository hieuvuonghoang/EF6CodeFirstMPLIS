namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class QT_GHICHUXULY_Configuration : EntityTypeConfiguration<QT_GHICHUXULY>
    {
        public QT_GHICHUXULY_Configuration()
        {
            this.HasKey(t => t.GHICHUXULYID);

            this.Property(t => t.GHICHUXULYID)
                .HasColumnName("GHICHUXULYID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.HOSOXULYID)
                .HasColumnName("HOSOXULYID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.QUYTRINHID)
                .HasColumnName("QUYTRINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.HOSOTIEPNHANID)
                .HasColumnName("HOSOTIEPNHANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.BUOCQUYTRINHID)
                .HasColumnName("BUOCQUYTRINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOIDUNGID)
                .HasColumnName("NGUOIDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.GHICHUXL)
                .HasColumnName("GHICHUXL")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGAYGHICHU)
                .HasColumnName("NGAYGHICHU");

            this.HasRequired<HT_NGUOIDUNG>(t => t.HT_NGUOIDUNG)
                .WithMany(m => m.QT_GHICHUXULY)
                .HasForeignKey(m => m.NGUOIDUNGID);
            this.HasRequired<QT_BUOCQUYTRINH>(t => t.QT_BUOCQUYTRINH)
                .WithMany(m => m.QT_GHICHUXULY)
                .HasForeignKey(m => m.BUOCQUYTRINHID);
            this.HasRequired<QT_HOSO_LANXULY>(t => t.QT_HOSO_LANXULY)
                .WithMany(m => m.QT_GHICHUXULY)
                .HasForeignKey(m => m.HOSOXULYID);
            this.HasRequired<QT_HOSOTIEPNHAN>(t => t.QT_HOSOTIEPNHAN)
                .WithMany(m => m.QT_GHICHUXULY)
                .HasForeignKey(m => m.HOSOTIEPNHANID);
            this.HasRequired<QT_QUYTRINH>(t => t.QT_QUYTRINH)
                .WithMany(m => m.QT_GHICHUXULY)
                .HasForeignKey(m => m.QUYTRINHID);

            this.ToTable("QT_GHICHUXULY");
        }
    }
}
