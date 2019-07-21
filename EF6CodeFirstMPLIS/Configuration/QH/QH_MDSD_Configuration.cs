namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_MDSD_Configuration : EntityTypeConfiguration<QH_MDSD> 
	{ 
		public QH_MDSD_Configuration() 
		{ 
			this.HasKey(t => t.MDSDID); 
			
			this.Property(t => t.MDSDID)
				.HasColumnName("MDSDID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MAMDSD)
				.HasColumnName("MAMDSD")
				.IsUnicode(false)
				.HasMaxLength(3);
            this.Property(t => t.DIENTICH)
                .HasColumnName("DIENTICH");
			this.Property(t => t.BIEUBANGID)
				.HasColumnName("BIEUBANGID")
				.IsUnicode(false)
				.HasMaxLength(36);

			this.ToTable("QH_MDSD"); 
		} 
	} 
}