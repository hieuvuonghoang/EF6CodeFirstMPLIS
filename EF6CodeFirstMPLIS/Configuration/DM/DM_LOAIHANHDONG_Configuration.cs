namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIHANHDONG_Configuration : EntityTypeConfiguration<DM_LOAIHANHDONG> 
	{ 
		public DM_LOAIHANHDONG_Configuration() 
		{ 
			this.HasKey(t => t.LOAIHANHDONGID); 
			
			this.Property(t => t.LOAIHANHDONGID)
				.HasColumnName("LOAIHANHDONGID")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.MOTA)
				.HasColumnName("MOTA")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.URL)
				.HasColumnName("URL")
				.IsUnicode(false)
				.HasMaxLength(1000);
			this.Property(t => t.UID)
				.HasColumnName("UID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.NGUOICAPNHATIF)
				.HasColumnName("NGUOICAPNHATIF")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");

			this.ToTable("DM_LOAIHANHDONG"); 
		} 
	} 
}