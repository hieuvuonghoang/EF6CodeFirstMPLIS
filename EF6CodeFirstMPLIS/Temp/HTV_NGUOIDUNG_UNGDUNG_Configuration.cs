namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HTV_NGUOIDUNG_UNGDUNG_Configuration : EntityTypeConfiguration<HTV_NGUOIDUNG_UNGDUNG> 
	{ 
		public HTV_NGUOIDUNG_UNGDUNG_Configuration() 
		{ 
			this.HasKey(t => t.); 
			
			this.Property(t => t.NOID)
				.HasColumnName("NOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NOID)
				.HasColumnName("NOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NOID)
				.HasColumnName("NOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NOID)
				.HasColumnName("NOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NOID)
				.HasColumnName("NOID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<>(t => t.)
				.WithMany(m => m.HTV_NGUOIDUNG_UNGDUNG)
				.HasForeignKey(m => m.);  

			this.ToTable("HTV_NGUOIDUNG_UNGDUNG"); 
		} 
	} 
}