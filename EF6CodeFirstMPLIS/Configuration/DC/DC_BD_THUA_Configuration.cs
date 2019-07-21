namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_BD_THUA_Configuration : EntityTypeConfiguration<DC_BD_THUA> 
	{ 
		public DC_BD_THUA_Configuration() 
		{ 
			this.HasKey(t => t.BDTHUAID); 
			
			this.Property(t => t.BDTHUAID)
				.HasColumnName("BDTHUAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUADATID)
				.HasColumnName("THUADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAITHUABD)
				.HasColumnName("LOAITHUABD")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.LADULIEULS)
				.HasColumnName("LADULIEULS")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.BIENDONGID)
				.HasColumnName("BIENDONGID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<DC_BIENDONG>(t => t.DC_BIENDONG)
				.WithMany(m => m.DC_BD_THUA)
				.HasForeignKey(m => m.BIENDONGID);
            this.HasRequired<DC_THUADAT>(t => t.DC_THUADAT)
                .WithMany(m => m.DC_BD_THUA)
                .HasForeignKey(m => m.THUADATID);

            this.ToTable("DC_BD_THUA"); 
		} 
	} 
}