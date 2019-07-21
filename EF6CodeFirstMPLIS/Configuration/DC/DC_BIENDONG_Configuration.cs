namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class DC_BIENDONG_Configuration : EntityTypeConfiguration<DC_BIENDONG>
    {
        public DC_BIENDONG_Configuration()
        {
            this.HasKey(t => t.BIENDONGID);

            this.Property(t => t.BIENDONGID)
                .HasColumnName("BIENDONGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LOAIBIENDONGID)
                .HasColumnName("LOAIBIENDONGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THOIDIEMBIENDONG)
                .HasColumnName("THOIDIEMBIENDONG");
            this.Property(t => t.MACOQUANTHUCHIEN)
                .HasColumnName("MACOQUANTHUCHIEN")
                .IsUnicode(false)
                .HasMaxLength(10);
            this.Property(t => t.SOTHUTU)
                .HasColumnName("SOTHUTU");
            this.Property(t => t.MABIENDONG)
                .HasColumnName("MABIENDONG")
                .IsUnicode(false)
                .HasMaxLength(30);
            this.Property(t => t.NOIDUNGBIENDONG)
                .HasColumnName("NOIDUNGBIENDONG")
                .IsUnicode(false)
                .HasMaxLength(2000);
            this.Property(t => t.SOHOPDONG)
                .HasColumnName("SOHOPDONG")
                .IsUnicode(false)
                .HasMaxLength(30);
            this.Property(t => t.NGAYHOPDONG)
                .HasColumnName("NGAYHOPDONG");
            this.Property(t => t.NOIDUNGHOPDONG)
                .HasColumnName("NOIDUNGHOPDONG")
                .IsUnicode(false)
                .HasMaxLength(2000);
            this.Property(t => t.SOCONGCHUNG)
                .HasColumnName("SOCONGCHUNG")
                .IsUnicode(false)
                .HasMaxLength(20);
            this.Property(t => t.QUYENCONGCHUNG)
                .HasColumnName("QUYENCONGCHUNG")
                .IsUnicode(false)
                .HasMaxLength(20);
            this.Property(t => t.NGAYCONGCHUNG)
                .HasColumnName("NGAYCONGCHUNG");
            this.Property(t => t.NOICONGCHUNGID)
                .HasColumnName("NOICONGCHUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NOICONGCHUNGID)
                .HasColumnName("NOICONGCHUNGID")
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
            this.Property(t => t.QUYETDINHID)
                .HasColumnName("QUYETDINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.HOSOTIEPNHANID)
                .HasColumnName("HOSOTIEPNHANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.COTHUAXULY)
                .HasColumnName("COTHUAXULY")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.SOTHUTUBIENDONG)
                .HasColumnName("SOTHUTUBIENDONG");
            this.Property(t => t.MAHSTTDANGKY)
                .HasColumnName("MAHSTTDANGKY")
                .IsUnicode(false)
                .HasMaxLength(30);
            this.Property(t => t.NGAYTRUOCBA)
                .HasColumnName("NGAYTRUOCBA");
            this.Property(t => t.LYDOBIENDONG)
                .HasColumnName("LYDOBIENDONG")
                .IsUnicode(false)
                .HasMaxLength(50);
            this.Property(t => t.MAHOSOTHUTUCDANGKY)
                .HasColumnName("MAHOSOTHUTUCDANGKY")
                .IsUnicode(false)
                .HasMaxLength(100);
            this.Property(t => t.NOICONGCHUNG)
                .HasColumnName("NOICONGCHUNG")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.MAKVHC)
                .HasColumnName("MAKVHC")
                .IsUnicode(false)
                .HasMaxLength(10);

            this.HasRequired<DC_LOAIBIENDONG>(t => t.DC_LOAIBIENDONG)
                .WithMany(m => m.DC_BIENDONG)
                .HasForeignKey(m => m.LOAIBIENDONGID);
            this.HasRequired<DC_NOICONGCHUNG>(t => t.DC_NOICONGCHUNG)
                .WithMany(m => m.DC_BIENDONG)
                .HasForeignKey(m => m.NOICONGCHUNGID);

            this.ToTable("DC_BIENDONG");
        }
    }
}
