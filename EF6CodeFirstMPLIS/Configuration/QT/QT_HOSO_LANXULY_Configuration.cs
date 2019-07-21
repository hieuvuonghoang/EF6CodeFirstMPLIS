namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QT_HOSO_LANXULY_Configuration : EntityTypeConfiguration<QT_HOSO_LANXULY> 
	{ 
		public QT_HOSO_LANXULY_Configuration() 
		{ 
			this.HasKey(t => t.HOSOXULYID); 
			
			this.Property(t => t.HOSOXULYID)
				.HasColumnName("HOSOXULYID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HOSOTIEPNHANID)
				.HasColumnName("HOSOTIEPNHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.QUYTRINHID)
				.HasColumnName("QUYTRINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGAYBATDAUXL)
				.HasColumnName("NGAYBATDAUXL");
			this.Property(t => t.NGAYKETTHUCXL)
				.HasColumnName("NGAYKETTHUCXL");
			this.Property(t => t.TRANGTHAI)
				.HasColumnName("TRANGTHAI")
				.IsUnicode(false)
				.HasMaxLength(1); 
			
			this.HasRequired<QT_HOSOTIEPNHAN>(t => t.QT_HOSOTIEPNHAN)
				.WithMany(m => m.QT_HOSO_LANXULY)
				.HasForeignKey(m => m.HOSOTIEPNHANID);
            this.HasRequired<QT_QUYTRINH>(t => t.QT_QUYTRINH)
                .WithMany(m => m.QT_HOSO_LANXULY)
                .HasForeignKey(m => m.QUYTRINHID);

            this.ToTable("QT_HOSO_LANXULY"); 
		} 
	} 
}