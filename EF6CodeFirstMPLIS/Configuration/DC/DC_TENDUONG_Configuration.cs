namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_TENDUONG_Configuration : EntityTypeConfiguration<DC_TENDUONG> 
	{ 
		public DC_TENDUONG_Configuration() 
		{ 
			this.HasKey(t => t.TENDUONGID); 
			
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
			this.Property(t => t.LOAIDUONG)
				.HasColumnName("LOAIDUONG");
			this.Property(t => t.MADUONG)
				.HasColumnName("MADUONG")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.MADUONG_THUE)
				.HasColumnName("MADUONG_THUE")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.TENDUONG)
				.HasColumnName("TENDUONG")
				.IsUnicode(false)
				.HasMaxLength(255);
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

			this.ToTable("DC_TENDUONG"); 
		} 
	} 
}