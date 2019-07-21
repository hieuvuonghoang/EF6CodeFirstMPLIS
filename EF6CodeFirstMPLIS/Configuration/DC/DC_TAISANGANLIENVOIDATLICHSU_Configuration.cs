namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_TAISANGANLIENVOIDATLICHSU_Configuration : EntityTypeConfiguration<DC_TAISANGANLIENVOIDATLICHSU> 
	{ 
		public DC_TAISANGANLIENVOIDATLICHSU_Configuration() 
		{ 
			this.HasKey(t => t.TAISANGANLIENVOIDATLICHSUID); 
			
			this.Property(t => t.TAISANGANLIENVOIDATLICHSUID)
				.HasColumnName("TAISANGANLIENVOIDATLICHSUID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.BIENDONGID)
				.HasColumnName("BIENDONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TRUOCBIENDONG)
				.HasColumnName("TRUOCBIENDONG")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.TAISANLSID)
				.HasColumnName("TAISANLSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAITAISAN)
				.HasColumnName("LOAITAISAN")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENTAISAN)
				.HasColumnName("TENTAISAN")
				.IsUnicode(false)
				.HasMaxLength(150);
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

			this.ToTable("DC_TAISANGANLIENVOIDATLICHSU"); 
		} 
	} 
}