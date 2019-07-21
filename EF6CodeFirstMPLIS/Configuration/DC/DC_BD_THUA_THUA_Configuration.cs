namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_BD_THUA_THUA_Configuration : EntityTypeConfiguration<DC_BD_THUA_THUA> 
	{ 
		public DC_BD_THUA_THUA_Configuration() 
		{ 
			this.HasKey(t => t.BDTHUATHUAID); 
			
			this.Property(t => t.BDTHUATHUAID)
				.HasColumnName("BDTHUATHUAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUACHAID)
				.HasColumnName("THUACHAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUADATID)
				.HasColumnName("THUADATID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<DC_THUADAT>(t => t.DC_THUADAT)
				.WithMany(m => m.DC_BD_THUA_THUA)
				.HasForeignKey(m => m.THUADATID);
            this.HasRequired<DC_THUADAT>(t => t.DC_THUADAT1)
                .WithMany(m => m.DC_BD_THUA_THUA)
                .HasForeignKey(m => m.THUACHAID);

            this.ToTable("DC_BD_THUA_THUA"); 
		} 
	} 
}