namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_RUNGTRONG_Configuration : EntityTypeConfiguration<DC_RUNGTRONG> 
	{ 
		public DC_RUNGTRONG_Configuration() 
		{ 
			this.HasKey(t => t.RUNGTRONGID); 
			
			this.Property(t => t.RUNGTRONGID)
				.HasColumnName("RUNGTRONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENRUNG)
				.HasColumnName("TENRUNG")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.LOAICAYRUNG)
				.HasColumnName("LOAICAYRUNG")
				.IsUnicode(false)
				.HasMaxLength(255);
            this.Property(t => t.DIENTICH)
                .HasColumnName("DIENTICH");
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.THOIHANSOHUU)
				.HasColumnName("THOIHANSOHUU")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.HINHTHUCSOHUU)
				.HasColumnName("HINHTHUCSOHUU")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(200);

			this.ToTable("DC_RUNGTRONG"); 
		} 
	} 
}