namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class LS_BD_GCN_Configuration : EntityTypeConfiguration<LS_BD_GCN> 
	{ 
		public LS_BD_GCN_Configuration() 
		{ 
			this.HasKey(t => t.LSBDGCNID); 
			
			this.Property(t => t.LSBDGCNID)
				.HasColumnName("LSBDGCNID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.GCNHIENTAIID)
				.HasColumnName("GCNHIENTAIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.GCNID)
				.HasColumnName("GCNID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.GCNCHAID)
				.HasColumnName("GCNCHAID")
				.IsUnicode(false)
				.HasMaxLength(40);
			this.Property(t => t.NGAYPD)
				.HasColumnName("NGAYPD");
			this.Property(t => t.BIENDONGID)
				.HasColumnName("BIENDONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MAKVHC)
				.HasColumnName("MAKVHC")
				.IsUnicode(false)
				.HasMaxLength(10); 
			
			this.HasRequired<DC_BIENDONG>(t => t.DC_BIENDONG)
				.WithMany(m => m.LS_BD_GCN)
				.HasForeignKey(m => m.BIENDONGID);  

			this.ToTable("LS_BD_GCN"); 
		} 
	} 
}