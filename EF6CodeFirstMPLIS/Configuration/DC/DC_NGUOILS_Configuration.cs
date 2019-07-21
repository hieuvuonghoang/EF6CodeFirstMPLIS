namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_NGUOILS_Configuration : EntityTypeConfiguration<DC_NGUOILS> 
	{ 
		public DC_NGUOILS_Configuration() 
		{ 
			this.HasKey(t => t.NGUOILSID); 
			
			this.Property(t => t.NGUOILSID)
				.HasColumnName("NGUOILSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.CHITIETID)
				.HasColumnName("CHITIETID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAIDOITUONGID)
				.HasColumnName("LOAIDOITUONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
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

			this.ToTable("DC_NGUOILS"); 
		} 
	} 
}