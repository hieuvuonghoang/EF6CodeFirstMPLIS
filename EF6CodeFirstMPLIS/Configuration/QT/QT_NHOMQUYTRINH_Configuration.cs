namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QT_NHOMQUYTRINH_Configuration : EntityTypeConfiguration<QT_NHOMQUYTRINH> 
	{ 
		public QT_NHOMQUYTRINH_Configuration() 
		{ 
			this.HasKey(t => t.NHOMQUYTRINHID); 
			
			this.Property(t => t.NHOMQUYTRINHID)
				.HasColumnName("NHOMQUYTRINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENNHOMQUYTRINH)
				.HasColumnName("TENNHOMQUYTRINH")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.KYHIEUNHOM)
				.HasColumnName("KYHIEUNHOM")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.THUTUSAPXEP)
				.HasColumnName("THUTUSAPXEP")
				.IsUnicode(false)
				.HasMaxLength(5);
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

			this.ToTable("QT_NHOMQUYTRINH"); 
		} 
	} 
}