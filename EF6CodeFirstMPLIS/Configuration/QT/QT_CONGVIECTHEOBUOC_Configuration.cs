namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QT_CONGVIECTHEOBUOC_Configuration : EntityTypeConfiguration<QT_CONGVIECTHEOBUOC> 
	{ 
		public QT_CONGVIECTHEOBUOC_Configuration() 
		{ 
			this.HasKey(t => t.CONGVIECTHEOBUOCID); 
			
			this.Property(t => t.CONGVIECTHEOBUOCID)
				.HasColumnName("CONGVIECTHEOBUOCID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.STT)
				.HasColumnName("STT");
			this.Property(t => t.TENCONGVIEC)
				.HasColumnName("TENCONGVIEC")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.BUOCQUYTRINHID)
				.HasColumnName("BUOCQUYTRINHID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<QT_BUOCQUYTRINH>(t => t.QT_BUOCQUYTRINH)
				.WithMany(m => m.QT_CONGVIECTHEOBUOC)
				.HasForeignKey(m => m.BUOCQUYTRINHID);  

			this.ToTable("QT_CONGVIECTHEOBUOC"); 
		} 
	} 
}