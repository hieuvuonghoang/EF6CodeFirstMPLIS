namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_THUADAT_TAILIEUDODAC_Configuration : EntityTypeConfiguration<DC_THUADAT_TAILIEUDODAC> 
	{ 
		public DC_THUADAT_TAILIEUDODAC_Configuration() 
		{ 
			this.HasKey(t => t.THUADATTAILIEUDODACID);

            this.Property(t => t.THUADATTAILIEUDODACID)
                .HasColumnName("THUADATTAILIEUDODACID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THUADATID)
				.HasColumnName("THUADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TAILIEUDODACID)
				.HasColumnName("TAILIEUDODACID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<DC_TAILIEUDODAC>(t => t.DC_TAILIEUDODAC)
				.WithMany(m => m.DC_THUADAT_TAILIEUDODAC)
				.HasForeignKey(m => m.TAILIEUDODACID);
            this.HasRequired<DC_THUADAT>(t => t.DC_THUADAT)
                .WithMany(m => m.DC_THUADAT_TAILIEUDODAC)
                .HasForeignKey(m => m.THUADATID);

            this.ToTable("DC_THUADAT_TAILIEUDODAC"); 
		} 
	} 
}