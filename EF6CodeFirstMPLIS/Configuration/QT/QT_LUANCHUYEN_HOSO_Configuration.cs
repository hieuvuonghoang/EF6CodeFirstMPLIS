namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QT_LUANCHUYEN_HOSO_Configuration : EntityTypeConfiguration<QT_LUANCHUYEN_HOSO> 
	{ 
		public QT_LUANCHUYEN_HOSO_Configuration() 
		{ 
			this.HasKey(t => t.LUANCHUYENHOSOID); 
			
			this.Property(t => t.LUANCHUYENHOSOID)
				.HasColumnName("LUANCHUYENHOSOID")
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
			this.Property(t => t.QUYTRINHID)
				.HasColumnName("QUYTRINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HOSOXULYID)
				.HasColumnName("HOSOXULYID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGUOIDUNGID)
				.HasColumnName("NGUOIDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGAYTIEPNHAN)
				.HasColumnName("NGAYTIEPNHAN");
			this.Property(t => t.NGAYCHUYEN)
				.HasColumnName("NGAYCHUYEN");
			this.Property(t => t.TRANGTHAI)
				.HasColumnName("TRANGTHAI")
				.IsUnicode(false)
				.HasMaxLength(1); 
			
			this.HasRequired<HT_NGUOIDUNG>(t => t.HT_NGUOIDUNG)
				.WithMany(m => m.QT_LUANCHUYEN_HOSO)
				.HasForeignKey(m => m.NGUOIDUNGID);
            this.HasRequired<QT_BUOCQUYTRINH>(t => t.QT_BUOCQUYTRINH)
                .WithMany(m => m.QT_LUANCHUYEN_HOSO)
                .HasForeignKey(m => m.BUOCQUYTRINHID);
            this.HasRequired<QT_HOSO_LANXULY>(t => t.QT_HOSO_LANXULY)
                .WithMany(m => m.QT_LUANCHUYEN_HOSO)
                .HasForeignKey(m => m.HOSOXULYID);
            this.HasRequired<QT_HOSOTIEPNHAN>(t => t.QT_HOSOTIEPNHAN)
                .WithMany(m => m.QT_LUANCHUYEN_HOSO)
                .HasForeignKey(m => m.HOSOTIEPNHANID);
            this.HasRequired<QT_QUYTRINH>(t => t.QT_QUYTRINH)
                .WithMany(m => m.QT_LUANCHUYEN_HOSO)
                .HasForeignKey(m => m.QUYTRINHID);

            this.ToTable("QT_LUANCHUYEN_HOSO"); 
		} 
	} 
}