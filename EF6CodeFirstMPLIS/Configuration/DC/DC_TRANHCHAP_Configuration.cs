namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_TRANHCHAP_Configuration : EntityTypeConfiguration<DC_TRANHCHAP> 
	{ 
		public DC_TRANHCHAP_Configuration() 
		{ 
			this.HasKey(t => t.TRANHCHAPID); 
			
			this.Property(t => t.TRANHCHAPID)
				.HasColumnName("TRANHCHAPID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NOIDUNG)
				.HasColumnName("NOIDUNG")
				.IsUnicode(false)
				.HasMaxLength(4000);
			this.Property(t => t.NGAYPHATSINH)
				.HasColumnName("NGAYPHATSINH");
			this.Property(t => t.CONTRANHCHAP)
				.HasColumnName("CONTRANHCHAP")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.THUADATID)
				.HasColumnName("THUADATID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<DC_THUADAT>(t => t.DC_THUADAT)
				.WithMany(m => m.DC_TRANHCHAP)
				.HasForeignKey(m => m.THUADATID);  

			this.ToTable("DC_TRANHCHAP"); 
		} 
	} 
}