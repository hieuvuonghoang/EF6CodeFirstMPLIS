namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_TAISANGANLIENVOIDATLS_Configuration : EntityTypeConfiguration<DC_TAISANGANLIENVOIDATLS> 
	{ 
		public DC_TAISANGANLIENVOIDATLS_Configuration() 
		{ 
			this.HasKey(t => t.TAISANGANLIENVOIDATLSID); 
			
			this.Property(t => t.TAISANGANLIENVOIDATLSID)
				.HasColumnName("TAISANGANLIENVOIDATLSID")
				.IsUnicode(false)
				.HasMaxLength(36);
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

			this.ToTable("DC_TAISANGANLIENVOIDATLS"); 
		} 
	} 
}