namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_QUYENSUDUNGDATLS_Configuration : EntityTypeConfiguration<DC_QUYENSUDUNGDATLS> 
	{ 
		public DC_QUYENSUDUNGDATLS_Configuration() 
		{ 
			this.HasKey(t => t.QUYENSUDUNGDATLSID); 
			
			this.Property(t => t.QUYENSUDUNGDATLSID)
				.HasColumnName("QUYENSUDUNGDATLSID")
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
			this.Property(t => t.THUADATLSID)
				.HasColumnName("THUADATLSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DAMUCDICHSUDUNGLSID)
				.HasColumnName("DAMUCDICHSUDUNGLSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGHIAVUTAICHINHLSID)
				.HasColumnName("NGHIAVUTAICHINHLSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HANCHEQUYENLSID)
				.HasColumnName("HANCHEQUYENLSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.GIAYCHUNGNHANLSID)
				.HasColumnName("GIAYCHUNGNHANLSID")
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
			this.Property(t => t.LAQUYENQUANLY)
				.HasColumnName("LAQUYENQUANLY")
				.IsUnicode(false)
				.HasMaxLength(1);

			this.ToTable("DC_QUYENSUDUNGDATLS"); 
		} 
	} 
}