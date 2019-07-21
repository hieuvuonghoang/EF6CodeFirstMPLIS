namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIDUONG_Configuration : EntityTypeConfiguration<DM_LOAIDUONG> 
	{ 
		public DM_LOAIDUONG_Configuration() 
		{ 
			this.HasKey(t => t.LOAIDUONGID); 
			
			this.Property(t => t.LOAIDUONGID)
				.HasColumnName("LOAIDUONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIDUONG)
				.HasColumnName("MALOAIDUONG")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIDUONG)
				.HasColumnName("TENLOAIDUONG")
				.IsUnicode(false)
				.HasMaxLength(40);
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

			this.ToTable("DM_LOAIDUONG"); 
		} 
	} 
}