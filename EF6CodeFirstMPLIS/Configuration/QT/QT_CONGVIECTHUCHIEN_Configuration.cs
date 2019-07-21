namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QT_CONGVIECTHUCHIEN_Configuration : EntityTypeConfiguration<QT_CONGVIECTHUCHIEN> 
	{ 
		public QT_CONGVIECTHUCHIEN_Configuration() 
		{ 
			this.HasKey(t => t.CONGVIECTHUCHIENID); 
			
			this.Property(t => t.CONGVIECTHUCHIENID)
				.HasColumnName("CONGVIECTHUCHIENID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TRANGTHAI)
				.HasColumnName("TRANGTHAI")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.NGAYTHUCHIEN)
				.HasColumnName("NGAYTHUCHIEN");
			this.Property(t => t.NGUOITHUCHIEN)
				.HasColumnName("NGUOITHUCHIEN")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.CONGVIECTHEOBUOCID)
				.HasColumnName("CONGVIECTHEOBUOCID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LUANCHUYENHOSOID)
				.HasColumnName("LUANCHUYENHOSOID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<QT_CONGVIECTHEOBUOC>(t => t.QT_CONGVIECTHEOBUOC)
				.WithMany(m => m.QT_CONGVIECTHUCHIEN)
				.HasForeignKey(m => m.CONGVIECTHEOBUOCID);
            this.HasRequired<QT_LUANCHUYEN_HOSO>(t => t.QT_LUANCHUYEN_HOSO)
                .WithMany(m => m.QT_CONGVIECTHUCHIEN)
                .HasForeignKey(m => m.LUANCHUYENHOSOID);

            this.ToTable("QT_CONGVIECTHUCHIEN"); 
		} 
	} 
}