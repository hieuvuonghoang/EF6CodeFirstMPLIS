namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HS_TC_GCN_Configuration : EntityTypeConfiguration<HS_TC_GCN> 
	{ 
		public HS_TC_GCN_Configuration() 
		{ 
			this.HasKey(t => t.TCGCNID);

            this.Property(t => t.TCGCNID)
                .HasColumnName("TCGCNID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.SOPHATHANH)
				.HasColumnName("SOPHATHANH")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.SOVAOSO)
				.HasColumnName("SOVAOSO")
				.IsUnicode(false)
				.HasMaxLength(10);
			this.Property(t => t.MAVACH)
				.HasColumnName("MAVACH")
				.IsUnicode(false)
				.HasMaxLength(25);
			this.Property(t => t.GCNID)
				.HasColumnName("GCNID")
				.IsUnicode(false)
				.HasMaxLength(40);
			this.Property(t => t.MAKVHC)
				.HasColumnName("MAKVHC")
				.IsUnicode(false)
				.HasMaxLength(10);
			this.Property(t => t.HOSOID)
				.HasColumnName("HOSOID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<HS_HOSO>(t => t.HS_HOSO)
				.WithMany(m => m.HS_TC_GCN)
				.HasForeignKey(m => m.HOSOID);  

			this.ToTable("HS_TC_GCN"); 
		} 
	} 
}