namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_SEQUENCE_Configuration : EntityTypeConfiguration<DM_SEQUENCE> 
	{ 
		public DM_SEQUENCE_Configuration() 
		{ 
			this.HasKey(t => t.SEQUENCEID); 
			
			this.Property(t => t.SEQUENCEID)
				.HasColumnName("SEQUENCEID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MATINH)
				.HasColumnName("MATINH")
				.IsUnicode(false)
				.HasMaxLength(32);
			this.Property(t => t.MAHUYEN)
				.HasColumnName("MAHUYEN")
				.IsUnicode(false)
				.HasMaxLength(32);
			this.Property(t => t.MAXA)
				.HasColumnName("MAXA")
				.IsUnicode(false)
				.HasMaxLength(32);
			this.Property(t => t.SOHIEUTOBANDO)
				.HasColumnName("SOHIEUTOBANDO");
			this.Property(t => t.SOTHUTUTHUA)
				.HasColumnName("SOTHUTUTHUA");
            this.Property(t => t.STT)
                .HasColumnName("STT");

			this.ToTable("DM_SEQUENCE"); 
		} 
	} 
}