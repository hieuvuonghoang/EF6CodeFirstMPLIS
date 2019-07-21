namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_HINHTHUCSUDUNGDAT_Configuration : EntityTypeConfiguration<DM_HINHTHUCSUDUNGDAT> 
	{ 
		public DM_HINHTHUCSUDUNGDAT_Configuration() 
		{ 
			this.HasKey(t => t.HINHTHUCSUDUNGID); 
			
			this.Property(t => t.HINHTHUCSUDUNGID)
				.HasColumnName("HINHTHUCSUDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENHINHTHUCSUDUNG)
				.HasColumnName("TENHINHTHUCSUDUNG")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.STT)
				.HasColumnName("STT");

			this.ToTable("DM_HINHTHUCSUDUNGDAT"); 
		} 
	} 
}