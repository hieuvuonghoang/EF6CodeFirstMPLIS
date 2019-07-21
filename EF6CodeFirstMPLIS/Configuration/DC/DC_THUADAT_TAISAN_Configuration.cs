namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_THUADAT_TAISAN_Configuration : EntityTypeConfiguration<DC_THUADAT_TAISAN> 
	{ 
		public DC_THUADAT_TAISAN_Configuration() 
		{ 
			this.HasKey(t => t.THUADATTAISANID);

            this.Property(t => t.THUADATTAISANID)
                .HasColumnName("THUADATTAISANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TAISANID)
				.HasColumnName("TAISANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUADATID)
				.HasColumnName("THUADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MOTA)
				.HasColumnName("MOTA")
				.IsUnicode(false)
				.HasMaxLength(150);
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
			
			this.HasRequired<DC_THUADAT>(t => t.DC_THUADAT)
				.WithMany(m => m.DC_THUADAT_TAISAN)
				.HasForeignKey(m => m.THUADATID);

			this.ToTable("DC_THUADAT_TAISAN"); 
		} 
	} 
}