namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIDUONGTHUYHE_Configuration : EntityTypeConfiguration<DM_LOAIDUONGTHUYHE> 
	{ 
		public DM_LOAIDUONGTHUYHE_Configuration() 
		{ 
			this.HasKey(t => t.LOAIDUONGTHUYHEID); 
			
			this.Property(t => t.LOAIDUONGTHUYHEID)
				.HasColumnName("LOAIDUONGTHUYHEID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIDUONGTHUYHE)
				.HasColumnName("MALOAIDUONGTHUYHE")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIDUONGTHUYHE)
				.HasColumnName("TENLOAIDUONGTHUYHE")
				.IsUnicode(false)
				.HasMaxLength(80);
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

			this.ToTable("DM_LOAIDUONGTHUYHE"); 
		} 
	} 
}