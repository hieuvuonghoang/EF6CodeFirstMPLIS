namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class LS_BD_THUA_Configuration : EntityTypeConfiguration<LS_BD_THUA> 
	{ 
		public LS_BD_THUA_Configuration() 
		{ 
			this.HasKey(t => t.BDTHUAID);

            this.Property(t => t.BDTHUAID)
                .HasColumnName("BDTHUAID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LICHSUTHUAID)
				.HasColumnName("LICHSUTHUAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUAHIENTAIID)
				.HasColumnName("THUAHIENTAIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUAID)
				.HasColumnName("THUAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUACHAID)
				.HasColumnName("THUACHAID")
				.IsUnicode(false)
				.HasMaxLength(36);
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
				.WithMany(m => m.LS_BD_THUA)
				.HasForeignKey(m => m.BIENDONGID);  

			this.ToTable("LS_BD_THUA"); 
		} 
	} 
}