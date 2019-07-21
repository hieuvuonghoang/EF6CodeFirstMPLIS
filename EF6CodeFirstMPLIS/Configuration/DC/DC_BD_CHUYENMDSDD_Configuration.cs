namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_BD_CHUYENMDSDD_Configuration : EntityTypeConfiguration<DC_BD_CHUYENMDSDD> 
	{ 
		public DC_BD_CHUYENMDSDD_Configuration() 
		{ 
			this.HasKey(t => t.BDCHUYENMDSDID); 
			
			this.Property(t => t.BDCHUYENMDSDID)
				.HasColumnName("BDCHUYENMDSDID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MUCDICHSUDUNGID)
				.HasColumnName("MUCDICHSUDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.BIENDONGID)
				.HasColumnName("BIENDONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LAMDSDTRUOCKHICHUYEN)
				.HasColumnName("LAMDSDTRUOCKHICHUYEN")
				.IsUnicode(false)
				.HasMaxLength(1);
            this.Property(t => t.DIENTICHCHUYENMDSDD)
                .HasColumnName("DIENTICHCHUYENMDSDD");
			
			this.HasRequired<DC_BIENDONG>(t => t.DC_BIENDONG)
				.WithMany(m => m.DC_BD_CHUYENMDSDD)
				.HasForeignKey(m => m.BIENDONGID);
            this.HasRequired<DM_MUCDICHSUDUNG>(t => t.DM_MUCDICHSUDUNG)
               .WithMany(m => m.DC_BD_CHUYENMDSDD)
               .HasForeignKey(m => m.MUCDICHSUDUNGID);

            this.ToTable("DC_BD_CHUYENMDSDD"); 
		} 
	} 
}