namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class QT_BUOCQT_CAUHINH_Configuration : EntityTypeConfiguration<QT_BUOCQT_CAUHINH>
    {
        public QT_BUOCQT_CAUHINH_Configuration()
        {
            this.HasKey(t => t.BUOCQTCAUHINHID);

            this.Property(t => t.BUOCQTCAUHINHID)
                .HasColumnName("BUOCQTCAUHINHID")
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
            this.Property(t => t.KVHCID)
                .HasColumnName("KVHCID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<HT_NGUOIDUNG>(t => t.HT_NGUOIDUNG)
                .WithMany(m => m.QT_BUOCQT_CAUHINH)
                .HasForeignKey(m => m.NGUOIDUNGID);
            this.HasRequired<HC_DMKVHC>(t => t.HC_DMKVHC)
                .WithMany(m => m.QT_BUOCQT_CAUHINH)
                .HasForeignKey(m => m.KVHCID);
            this.HasRequired<QT_BUOCQUYTRINH>(t => t.QT_BUOCQUYTRINH)
                .WithMany(m => m.QT_BUOCQT_CAUHINH)
                .HasForeignKey(m => m.BUOCQUYTRINHID);

            this.ToTable("QT_BUOCQT_CAUHINH");
        }
    }
}
