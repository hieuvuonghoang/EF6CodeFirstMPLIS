namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_BD_TREN_GCN_Configuration : EntityTypeConfiguration<DC_BD_TREN_GCN> 
	{ 
		public DC_BD_TREN_GCN_Configuration() 
		{ 
			this.HasKey(t => t.BDTRENGCNID); 
			
			this.Property(t => t.BDTRENGCNID)
				.HasColumnName("BDTRENGCNID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.GIAYCHUNGNHANID)
				.HasColumnName("GIAYCHUNGNHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.BIENDONGID)
				.HasColumnName("BIENDONGID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<DC_BIENDONG>(t => t.DC_BIENDONG)
				.WithMany(m => m.DC_BD_TREN_GCN)
				.HasForeignKey(m => m.BIENDONGID);
            this.HasRequired<DC_GIAYCHUNGNHAN>(t => t.DC_GIAYCHUNGNHAN)
                .WithMany(m => m.DC_BD_TREN_GCN)
                .HasForeignKey(m => m.GIAYCHUNGNHANID);

            this.ToTable("DC_BD_TREN_GCN"); 
		} 
	} 
}