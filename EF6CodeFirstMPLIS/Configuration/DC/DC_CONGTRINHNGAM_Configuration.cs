namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_CONGTRINHNGAM_Configuration : EntityTypeConfiguration<DC_CONGTRINHNGAM> 
	{ 
		public DC_CONGTRINHNGAM_Configuration() 
		{ 
			this.HasKey(t => t.CONGTRINHNGAMID); 
			
			this.Property(t => t.CONGTRINHNGAMID)
				.HasColumnName("CONGTRINHNGAMID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MAXA)
				.HasColumnName("MAXA")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENCONGTRINH)
				.HasColumnName("TENCONGTRINH")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.LOAICONGTRINHNGAM)
				.HasColumnName("LOAICONGTRINHNGAM")
				.IsUnicode(false)
				.HasMaxLength(50);
            this.Property(t => t.DIENTICHCONGTRINH)
                .HasColumnName("DIENTICHCONGTRINH");
            this.Property(t => t.DOSAUTOIDA)
                .HasColumnName("DOSAUTOIDA");
			this.Property(t => t.VITRIDAUNOI)
				.HasColumnName("VITRIDAUNOI")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.NAMXAYDUNG)
				.HasColumnName("NAMXAYDUNG");
			this.Property(t => t.NAMHOANTHANH)
				.HasColumnName("NAMHOANTHANH");
			this.Property(t => t.THOIHANSOHUU)
				.HasColumnName("THOIHANSOHUU")
				.IsUnicode(false)
				.HasMaxLength(30);
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

			this.ToTable("DC_CONGTRINHNGAM"); 
		} 
	} 
}