namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIGIAYTOTUYTHAN_Configuration : EntityTypeConfiguration<DM_LOAIGIAYTOTUYTHAN> 
	{ 
		public DM_LOAIGIAYTOTUYTHAN_Configuration() 
		{ 
			this.HasKey(t => t.LOAIGIAYTOTUYTHANID); 
			
			this.Property(t => t.LOAIGIAYTOTUYTHANID)
				.HasColumnName("LOAIGIAYTOTUYTHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIGIAYTOTUYTHAN)
				.HasColumnName("MALOAIGIAYTOTUYTHAN")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIGIAYTOTUYTHAN)
				.HasColumnName("TENLOAIGIAYTOTUYTHAN")
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

			this.ToTable("DM_LOAIGIAYTOTUYTHAN"); 
		} 
	} 
}