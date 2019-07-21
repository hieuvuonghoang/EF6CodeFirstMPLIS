namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QT_FILEDINHKEMHOSO_Configuration : EntityTypeConfiguration<QT_FILEDINHKEMHOSO> 
	{ 
		public QT_FILEDINHKEMHOSO_Configuration() 
		{ 
			this.HasKey(t => t.FILEDINHKEMHOSOID); 
			
			this.Property(t => t.FILEDINHKEMHOSOID)
				.HasColumnName("FILEDINHKEMHOSOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HOSOTIEPNHANID)
				.HasColumnName("HOSOTIEPNHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SODOQUYTRINHID)
				.HasColumnName("SODOQUYTRINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.BUOCQUYTRINHID)
				.HasColumnName("BUOCQUYTRINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENFILE)
				.HasColumnName("TENFILE")
				.IsUnicode(false)
				.HasMaxLength(150);
			this.Property(t => t.NGAYTAOFILE)
				.HasColumnName("NGAYTAOFILE");
			this.Property(t => t.NGUOITAOFILEID)
				.HasColumnName("NGUOITAOFILEID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.LOAI)
                .HasColumnName("LOAI");
			this.Property(t => t.SOLUONG)
				.HasColumnName("SOLUONG");
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.DUONGDANFILE)
				.HasColumnName("DUONGDANFILE")
				.IsUnicode(false)
				.HasMaxLength(2000);
			this.Property(t => t.UID)
				.HasColumnName("UID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.LOAIBAOCAO)
				.HasColumnName("LOAIBAOCAO");
			this.Property(t => t.GIAYTOTHEOTTHCID)
				.HasColumnName("GIAYTOTHEOTTHCID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<QT_HOSOTIEPNHAN>(t => t.QT_HOSOTIEPNHAN)
				.WithMany(m => m.QT_FILEDINHKEMHOSO)
				.HasForeignKey(m => m.HOSOTIEPNHANID);
            this.HasRequired<QT_GIAYTOTHEOTTHC>(t => t.QT_GIAYTOTHEOTTHC)
                .WithMany(m => m.QT_FILEDINHKEMHOSO)
                .HasForeignKey(m => m.GIAYTOTHEOTTHCID);

            this.ToTable("QT_FILEDINHKEMHOSO"); 
		} 
	} 
}