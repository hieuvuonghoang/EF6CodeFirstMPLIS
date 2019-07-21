namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_CONGDONG_Configuration : EntityTypeConfiguration<DC_CONGDONG> 
	{ 
		public DC_CONGDONG_Configuration() 
		{ 
			this.HasKey(t => t.CONGDONGID); 
			
			this.Property(t => t.CONGDONGID)
				.HasColumnName("CONGDONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENCONGDONG)
				.HasColumnName("TENCONGDONG")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGUOIDAIDIENID)
				.HasColumnName("NGUOIDAIDIENID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
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
			this.Property(t => t.CMTNGUOIDAIDIEN)
				.HasColumnName("CMTNGUOIDAIDIEN")
				.IsUnicode(false)
				.HasMaxLength(30);

			this.ToTable("DC_CONGDONG"); 
		} 
	} 
}