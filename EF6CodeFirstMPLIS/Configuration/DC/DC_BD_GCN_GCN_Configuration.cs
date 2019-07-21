namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_BD_GCN_GCN_Configuration : EntityTypeConfiguration<DC_BD_GCN_GCN> 
	{ 
		public DC_BD_GCN_GCN_Configuration() 
		{ 
			this.HasKey(t => t.BDGCNGCNID); 
			
			this.Property(t => t.BDGCNGCNID)
				.HasColumnName("BDGCNGCNID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.GCNCHAID)
				.HasColumnName("GCNCHAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.GIAYCHUNGNHANID)
				.HasColumnName("GIAYCHUNGNHANID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<DC_GIAYCHUNGNHAN>(t => t.DC_GIAYCHUNGNHAN)
				.WithMany(m => m.DC_BD_GCN_GCN)
				.HasForeignKey(m => m.GIAYCHUNGNHANID);
            this.HasRequired<DC_GIAYCHUNGNHAN>(t => t.DC_GIAYCHUNGNHAN1)
                .WithMany(m => m.DC_BD_GCN_GCN1)
                .HasForeignKey(m => m.GCNCHAID)
                .WillCascadeOnDelete(false);

            this.ToTable("DC_BD_GCN_GCN"); 
		} 
	} 
}