namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIHANHLANGANTOANBAOVE_Configuration : EntityTypeConfiguration<DM_LOAIHANHLANGANTOANBAOVE> 
	{ 
		public DM_LOAIHANHLANGANTOANBAOVE_Configuration() 
		{ 
			this.HasKey(t => t.LOAIHANHLANGANTOANBAOVEID); 
			
			this.Property(t => t.LOAIHANHLANGANTOANBAOVEID)
				.HasColumnName("LOAIHANHLANGANTOANBAOVEID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIHANHLANGANTOANBAOVE)
				.HasColumnName("MALOAIHANHLANGANTOANBAOVE")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIHANHLANGANTOANBAOVE)
				.HasColumnName("TENLOAIHANHLANGANTOANBAOVE")
				.IsUnicode(false)
				.HasMaxLength(120);
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

			this.ToTable("DM_LOAIHANHLANGANTOANBAOVE"); 
		} 
	} 
}