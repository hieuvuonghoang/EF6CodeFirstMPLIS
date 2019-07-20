namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class QT_BUOCQUYTRINH_Configuration : EntityTypeConfiguration<QT_BUOCQUYTRINH>
    {
        public QT_BUOCQUYTRINH_Configuration()
        {
            this.HasKey(t => t.BUOCQUYTRINHID);

            this.Property(t => t.BUOCQUYTRINHID)
                .HasColumnName("BUOCQUYTRINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MOTA)
                .HasColumnName("MOTA")
                .IsUnicode(true)
                .HasMaxLength(255);
            this.Property(t => t.BUOCQUYTRINHTRUOCIDS)
                .HasColumnName("BUOCQUYTRINHTRUOCIDS")
                .IsUnicode(false)
                .HasMaxLength(2000);
            this.Property(t => t.RECTX)
                .HasColumnName("RECTX");
            this.Property(t => t.RECTY)
                .HasColumnName("RECTY");
            this.Property(t => t.RECTWIDTH)
                .HasColumnName("RECTWIDTH");
            this.Property(t => t.RECTHEIGHT)
                .HasColumnName("RECTHEIGHT");
            this.Property(t => t.QUYTRINHID)
                .HasColumnName("QUYTRINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LOAIBUOCQT)
                .HasColumnName("LOAIBUOCQT")
                .HasMaxLength(1);
            this.Property(t => t.DIEUKIEN)
                .HasColumnName("DIEUKIEN");
            this.Property(t => t.THOIGIANQUYDINH)
                .HasColumnName("THOIGIANQUYDINH");
            this.Property(t => t.BUOCQUYTRINHSAUIDS)
                .HasColumnName("BUOCQUYTRINHSAUIDS")
                .IsUnicode(false)
                .HasMaxLength(2000);
            this.Property(t => t.THOIDIEMKHOITAO)
                .HasColumnName("THOIDIEMKHOITAO");
            this.Property(t => t.THOIDIEMCAPNHAT)
                .HasColumnName("THOIDIEMCAPNHAT");
            this.Property(t => t.NGUOICAPNHATID)
                .HasColumnName("NGUOICAPNHATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THOIDIEMCAPNHAT)
                .HasColumnName("THOIDIEMCAPNHAT");
            this.Property(t => t.BPMNID)
                .HasColumnName("BPMNID")
                .IsUnicode(false)
                .HasMaxLength(100);
            this.Property(t => t.TENBUOC)
                .HasColumnName("TENBUOC")
                .IsUnicode(true)
                .HasMaxLength(250);
            this.Property(t => t.UID)
                .HasColumnName("UID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.STT)
                .HasColumnName("STT");

            this.HasRequired<QT_QUYTRINH>(t => t.QT_QUYTRINH)
                .WithMany(m => m.QT_BUOCQUYTRINH)
                .HasForeignKey(m => m.QUYTRINHID);

            this.ToTable("QT_BUOCQUYTRINH");
        }
    }
}
