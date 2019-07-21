namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_QHVOICHUHO_Configuration : EntityTypeConfiguration<DM_QHVOICHUHO> 
	{ 
		public DM_QHVOICHUHO_Configuration() 
		{ 
			this.HasKey(t => t.QHVOICHUHOID); 
			
			this.Property(t => t.QHVOICHUHOID)
				.HasColumnName("QHVOICHUHOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENQUANHE)
				.HasColumnName("TENQUANHE")
				.IsUnicode(false)
				.HasMaxLength(120);
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.STT)
				.HasColumnName("STT");

			this.ToTable("DM_QHVOICHUHO"); 
		} 
	} 
}