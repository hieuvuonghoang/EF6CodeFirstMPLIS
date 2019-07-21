namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_DOANDUONG_Configuration : EntityTypeConfiguration<DC_DOANDUONG> 
	{ 
		public DC_DOANDUONG_Configuration() 
		{ 
			this.HasKey(t => t.DOANDUONGID); 
			
			this.Property(t => t.DOANDUONGID)
				.HasColumnName("DOANDUONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENDUONGID)
				.HasColumnName("TENDUONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TINHID)
				.HasColumnName("TINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HUYENID)
				.HasColumnName("HUYENID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MADOANDUONG)
				.HasColumnName("MADOANDUONG")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.MADOANDUONG_THUE)
				.HasColumnName("MADOANDUONG_THUE")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.TENDOANDUONG)
				.HasColumnName("TENDOANDUONG")
				.IsUnicode(false)
				.HasMaxLength(500);
			this.Property(t => t.NAMBATDAU)
				.HasColumnName("NAMBATDAU");
			this.Property(t => t.NAMKETTHUC)
				.HasColumnName("NAMKETTHUC");
            this.Property(t => t.TRANGTHAI)
                .HasColumnName("TRANGTHAI");
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

			this.ToTable("DC_DOANDUONG"); 
		} 
	} 
}