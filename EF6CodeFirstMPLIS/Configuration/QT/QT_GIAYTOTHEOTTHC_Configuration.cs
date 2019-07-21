namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QT_GIAYTOTHEOTTHC_Configuration : EntityTypeConfiguration<QT_GIAYTOTHEOTTHC> 
	{ 
		public QT_GIAYTOTHEOTTHC_Configuration() 
		{ 
			this.HasKey(t => t.GIAYTOTHEOTTHCID); 
			
			this.Property(t => t.GIAYTOTHEOTTHCID)
				.HasColumnName("GIAYTOTHEOTTHCID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUTUCHANHCHINHID)
				.HasColumnName("THUTUCHANHCHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENLOAIGIAYTO)
				.HasColumnName("TENLOAIGIAYTO")
				.IsUnicode(false)
				.HasMaxLength(2000);

            this.HasRequired<QT_THUTUCHANHCHINH>(t => t.QT_THUTUCHANHCHINH)
                .WithMany(m => m.QT_GIAYTOTHEOTTHC)
                .HasForeignKey(m => m.THUTUCHANHCHINHID)
                .WillCascadeOnDelete(false);

			this.ToTable("QT_GIAYTOTHEOTTHC"); 
		} 
	} 
}