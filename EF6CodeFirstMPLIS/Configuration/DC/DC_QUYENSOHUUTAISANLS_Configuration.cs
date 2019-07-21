namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_QUYENSOHUUTAISANLS_Configuration : EntityTypeConfiguration<DC_QUYENSOHUUTAISANLS> 
	{ 
		public DC_QUYENSOHUUTAISANLS_Configuration() 
		{ 
			this.HasKey(t => t.QUYENSOHUUTAISANLSID); 
			
			this.Property(t => t.QUYENSOHUUTAISANLSID)
				.HasColumnName("QUYENSOHUUTAISANLSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.BIENDONGID)
				.HasColumnName("BIENDONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TRUOCBIENDONG)
				.HasColumnName("TRUOCBIENDONG");
			this.Property(t => t.NGUOILSID)
				.HasColumnName("NGUOILSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TAISANGANLIENVOIDATLSID)
				.HasColumnName("TAISANGANLIENVOIDATLSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGHIAVUTAICHINHLSID)
				.HasColumnName("NGHIAVUTAICHINHLSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.GIAYCHUNGNHANLSID)
				.HasColumnName("GIAYCHUNGNHANLSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HANCHEQUYENSOHUULSID)
				.HasColumnName("HANCHEQUYENSOHUULSID")
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
			this.Property(t => t.DONDANGKYID)
				.HasColumnName("DONDANGKYID")
				.IsUnicode(false)
				.HasMaxLength(36);

			this.ToTable("DC_QUYENSOHUUTAISANLS"); 
		} 
	} 
}