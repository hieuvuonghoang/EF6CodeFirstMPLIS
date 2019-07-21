namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class LS_BOHOSO_Configuration : EntityTypeConfiguration<LS_BOHOSO> 
	{ 
		public LS_BOHOSO_Configuration() 
		{ 
			this.HasKey(t => t.BOHOSOID); 
			
			this.Property(t => t.BOHOSOID)
				.HasColumnName("BOHOSOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DATA)
				.HasColumnName("DATA");
			this.Property(t => t.BIENDONGID)
				.HasColumnName("BIENDONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGAYPD)
				.HasColumnName("NGAYPD");
			this.Property(t => t.MAKVHC)
				.HasColumnName("MAKVHC")
				.IsUnicode(false)
				.HasMaxLength(10); 
			
			this.HasRequired<DC_BIENDONG>(t => t.DC_BIENDONG)
				.WithMany(m => m.LS_BOHOSO)
				.HasForeignKey(m => m.BIENDONGID);  

			this.ToTable("LS_BOHOSO"); 
		} 
	} 
}