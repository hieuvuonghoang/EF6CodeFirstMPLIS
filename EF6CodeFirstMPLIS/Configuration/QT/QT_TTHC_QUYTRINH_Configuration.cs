namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QT_TTHC_QUYTRINH_Configuration : EntityTypeConfiguration<QT_TTHC_QUYTRINH> 
	{ 
		public QT_TTHC_QUYTRINH_Configuration() 
		{ 
			this.HasKey(t => t.TTHCQUYTRINHID);

            this.Property(t => t.TTHCQUYTRINHID)
                .HasColumnName("TTHCQUYTRINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.QUYTRINHID)
				.HasColumnName("QUYTRINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUTUCHANHCHINHID)
				.HasColumnName("THUTUCHANHCHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
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
			this.Property(t => t.ISACTIVE)
				.HasColumnName("ISACTIVE")
				.IsUnicode(false)
				.HasMaxLength(1); 
			
			this.HasRequired<QT_QUYTRINH>(t => t.QT_QUYTRINH)
				.WithMany(m => m.QT_TTHC_QUYTRINH)
				.HasForeignKey(m => m.QUYTRINHID);
            this.HasRequired<QT_THUTUCHANHCHINH>(t => t.QT_THUTUCHANHCHINH)
                .WithMany(m => m.QT_TTHC_QUYTRINH)
                .HasForeignKey(m => m.THUTUCHANHCHINHID);

            this.ToTable("QT_TTHC_QUYTRINH"); 
		} 
	} 
}