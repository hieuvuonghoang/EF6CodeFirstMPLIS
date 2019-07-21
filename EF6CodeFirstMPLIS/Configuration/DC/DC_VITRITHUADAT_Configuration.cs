namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_VITRITHUADAT_Configuration : EntityTypeConfiguration<DC_VITRITHUADAT> 
	{ 
		public DC_VITRITHUADAT_Configuration() 
		{ 
			this.HasKey(t => t.VITRIID); 
			
			this.Property(t => t.VITRIID)
				.HasColumnName("VITRIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DUONG)
				.HasColumnName("DUONG")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.DOANDUONG)
				.HasColumnName("DOANDUONG")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.KHUVUC)
				.HasColumnName("KHUVUC")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.VITRI)
				.HasColumnName("VITRI");
            this.Property(t => t.CHIEUSAU)
                .HasColumnName("CHIEUSAU");
            this.Property(t => t.CHIEURONGNGOHEM)
                .HasColumnName("CHIEURONGNGOHEM");
			this.Property(t => t.MUCDICHSUDUNGDATID)
				.HasColumnName("MUCDICHSUDUNGDATID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<DC_MUCDICHSUDUNGDAT>(t => t.DC_MUCDICHSUDUNGDAT)
				.WithMany(m => m.DC_VITRITHUADAT)
				.HasForeignKey(m => m.MUCDICHSUDUNGDATID);  

			this.ToTable("DC_VITRITHUADAT"); 
		} 
	} 
}