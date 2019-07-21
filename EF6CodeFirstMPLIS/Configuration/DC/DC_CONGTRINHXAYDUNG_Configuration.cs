namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_CONGTRINHXAYDUNG_Configuration : EntityTypeConfiguration<DC_CONGTRINHXAYDUNG> 
	{ 
		public DC_CONGTRINHXAYDUNG_Configuration() 
		{ 
			this.HasKey(t => t.CONGTRINHXAYDUNGID); 
			
			this.Property(t => t.CONGTRINHXAYDUNGID)
				.HasColumnName("CONGTRINHXAYDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MAXA)
				.HasColumnName("MAXA")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENCONGTRINH)
				.HasColumnName("TENCONGTRINH")
				.IsUnicode(false)
				.HasMaxLength(200);
            this.Property(t => t.DIENTICHXAYDUNG)
                .HasColumnName("DIENTICHXAYDUNG");
            this.Property(t => t.DIENTICHSAN)
                .HasColumnName("DIENTICHSAN");
			this.Property(t => t.SOTANG)
				.HasColumnName("SOTANG")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.SOTANGHAM)
				.HasColumnName("SOTANGHAM");
			this.Property(t => t.NAMXAYDUNG)
				.HasColumnName("NAMXAYDUNG");
			this.Property(t => t.NAMHOANTHANH)
				.HasColumnName("NAMHOANTHANH");
			this.Property(t => t.THOIHANSOHUU)
				.HasColumnName("THOIHANSOHUU")
				.IsUnicode(false)
				.HasMaxLength(30);
			this.Property(t => t.CAPHANG)
				.HasColumnName("CAPHANG")
				.IsUnicode(false)
				.HasMaxLength(50);
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
			this.Property(t => t.HINHTHUCSOHUU)
				.HasColumnName("HINHTHUCSOHUU")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(200);

			this.ToTable("DC_CONGTRINHXAYDUNG"); 
		} 
	} 
}