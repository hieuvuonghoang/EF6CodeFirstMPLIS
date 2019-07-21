namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_HANGMUCCONGTRINH_Configuration : EntityTypeConfiguration<DC_HANGMUCCONGTRINH> 
	{ 
		public DC_HANGMUCCONGTRINH_Configuration() 
		{ 
			this.HasKey(t => t.HANGMUCCONGTRINHID); 
			
			this.Property(t => t.HANGMUCCONGTRINHID)
				.HasColumnName("HANGMUCCONGTRINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.CONGTRINHXAYDUNGID)
				.HasColumnName("CONGTRINHXAYDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENHANGMUC)
				.HasColumnName("TENHANGMUC")
				.IsUnicode(false)
				.HasMaxLength(250);
			this.Property(t => t.CONGNANG)
				.HasColumnName("CONGNANG")
				.IsUnicode(false)
				.HasMaxLength(30);
            this.Property(t => t.DIENTICHXAYDUNG)
                .HasColumnName("DIENTICHXAYDUNG");
            this.Property(t => t.DIENTICHSAN)
                .HasColumnName("DIENTICHSAN");
			this.Property(t => t.SOTANG)
				.HasColumnName("SOTANG")
				.IsUnicode(false)
				.HasMaxLength(250);
			this.Property(t => t.SOTANGHAM)
				.HasColumnName("SOTANGHAM");
			this.Property(t => t.KETCAU)
				.HasColumnName("KETCAU")
				.IsUnicode(false)
				.HasMaxLength(250);
            this.Property(t => t.NAMXAYDUNG)
                .HasColumnName("NAMXAYDUNG");
            this.Property(t => t.NAMHOANTHANH)
                .HasColumnName("NAMHOANTHANH");
			this.Property(t => t.THOIHANSOHUU)
				.HasColumnName("THOIHANSOHUU")
				.IsUnicode(false)
				.HasMaxLength(150);
			this.Property(t => t.CAPHANG)
				.HasColumnName("CAPHANG")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.DIACHIID)
				.HasColumnName("DIACHIID")
				.IsUnicode(false)
				.HasMaxLength(36);
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
			
			this.HasRequired<DC_CONGTRINHXAYDUNG>(t => t.DC_CONGTRINHXAYDUNG)
				.WithMany(m => m.DC_HANGMUCCONGTRINH)
				.HasForeignKey(m => m.CONGTRINHXAYDUNGID);  

			this.ToTable("DC_HANGMUCCONGTRINH"); 
		} 
	} 
}