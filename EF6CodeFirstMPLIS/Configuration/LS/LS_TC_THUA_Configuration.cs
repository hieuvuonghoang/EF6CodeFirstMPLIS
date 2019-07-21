namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class LS_TC_THUA_Configuration : EntityTypeConfiguration<LS_TC_THUA> 
	{ 
		public LS_TC_THUA_Configuration() 
		{ 
			this.HasKey(t => t.TCTHUAID);

            this.Property(t => t.TCTHUAID)
                .HasColumnName("TCTHUAID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.SHTOBD)
				.HasColumnName("SHTOBD")
				.IsUnicode(false)
				.HasMaxLength(10);
			this.Property(t => t.STTTHUA)
				.HasColumnName("STTTHUA")
				.IsUnicode(false)
				.HasMaxLength(10);
			this.Property(t => t.MAKVHC)
				.HasColumnName("MAKVHC")
				.IsUnicode(false)
				.HasMaxLength(10);
			this.Property(t => t.BOHOSOID)
				.HasColumnName("BOHOSOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUAID)
				.HasColumnName("THUAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<LS_BOHOSO>(t => t.LS_BOHOSO)
				.WithMany(m => m.LS_TC_THUA)
				.HasForeignKey(m => m.BOHOSOID);  

			this.ToTable("LS_TC_THUA"); 
		} 
	} 
}