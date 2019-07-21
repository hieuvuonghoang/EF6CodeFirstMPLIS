namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class LS_TC_CHU_Configuration : EntityTypeConfiguration<LS_TC_CHU> 
	{ 
		public LS_TC_CHU_Configuration() 
		{ 
			this.HasKey(t => t.TCCHUID);

            this.Property(t => t.TCCHUID)
                .HasColumnName("TCCHUID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENCHU)
				.HasColumnName("TENCHU")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.BOHOSOID)
				.HasColumnName("BOHOSOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.CHUID)
				.HasColumnName("CHUID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOGIAYTOXM)
				.HasColumnName("SOGIAYTOXM")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.MAKVHC)
				.HasColumnName("MAKVHC")
				.IsUnicode(false)
				.HasMaxLength(10); 
			
			this.HasRequired<LS_BOHOSO>(t => t.LS_BOHOSO)
				.WithMany(m => m.LS_TC_CHU)
				.HasForeignKey(m => m.BOHOSOID);  

			this.ToTable("LS_TC_CHU"); 
		} 
	} 
}