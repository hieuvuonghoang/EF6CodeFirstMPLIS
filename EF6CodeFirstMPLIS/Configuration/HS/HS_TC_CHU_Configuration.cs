namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HS_TC_CHU_Configuration : EntityTypeConfiguration<HS_TC_CHU> 
	{ 
		public HS_TC_CHU_Configuration() 
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
			this.Property(t => t.CHUID)
				.HasColumnName("CHUID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOGIAYTOXM)
				.HasColumnName("SOGIAYTOXM")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.HOSOID)
				.HasColumnName("HOSOID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<HS_HOSO>(t => t.HS_HOSO)
				.WithMany(m => m.HS_TC_CHU)
				.HasForeignKey(m => m.HOSOID);  

			this.ToTable("HS_TC_CHU"); 
		} 
	} 
}