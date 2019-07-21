namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QT_QUYTRINH_Configuration : EntityTypeConfiguration<QT_QUYTRINH> 
	{ 
		public QT_QUYTRINH_Configuration() 
		{ 
			this.HasKey(t => t.QUYTRINHID); 
			
			this.Property(t => t.QUYTRINHID)
				.HasColumnName("QUYTRINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NHOMQUYTRINHID)
				.HasColumnName("NHOMQUYTRINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.CAPQUYTRINH)
                .HasColumnName("CAPQUYTRINH");
			this.Property(t => t.DONVIHANHCHINHID)
				.HasColumnName("DONVIHANHCHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENQUYTRINH)
				.HasColumnName("TENQUYTRINH")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.THOIHANGIAIQUYETTOIDA)
				.HasColumnName("THOIHANGIAIQUYETTOIDA");
			this.Property(t => t.XML)
				.HasColumnName("XML");
			this.Property(t => t.SVG)
				.HasColumnName("SVG");
			this.Property(t => t.PHAPLY)
				.HasColumnName("PHAPLY")
				.IsUnicode(false)
				.HasMaxLength(1000);
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
			this.Property(t => t.KYHIEU)
				.HasColumnName("KYHIEU")
				.IsUnicode(false)
				.HasMaxLength(15); 
			
			this.HasRequired<QT_NHOMQUYTRINH>(t => t.QT_NHOMQUYTRINH)
				.WithMany(m => m.QT_QUYTRINH)
				.HasForeignKey(m => m.NHOMQUYTRINHID);  

			this.ToTable("QT_QUYTRINH"); 
		} 
	} 
}