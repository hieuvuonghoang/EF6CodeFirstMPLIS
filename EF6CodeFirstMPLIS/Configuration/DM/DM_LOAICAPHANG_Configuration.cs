namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAICAPHANG_Configuration : EntityTypeConfiguration<DM_LOAICAPHANG> 
	{ 
		public DM_LOAICAPHANG_Configuration() 
		{ 
			this.HasKey(t => t.LOAICAPHANGID); 
			
			this.Property(t => t.LOAICAPHANGID)
				.HasColumnName("LOAICAPHANGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAICAPHANG)
				.HasColumnName("MALOAICAPHANG")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAICAPHANG)
				.HasColumnName("TENLOAICAPHANG")
				.IsUnicode(false)
				.HasMaxLength(20);
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

			this.ToTable("DM_LOAICAPHANG"); 
		} 
	} 
}