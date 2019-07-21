namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_NGANCHANNGUOI_Configuration : EntityTypeConfiguration<DC_NGANCHANNGUOI> 
	{ 
		public DC_NGANCHANNGUOI_Configuration() 
		{ 
			this.HasKey(t => t.NGANCHANNGUOIID); 
			
			this.Property(t => t.NGANCHANNGUOIID)
				.HasColumnName("NGANCHANNGUOIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THONGTINNGANCHANID)
				.HasColumnName("THONGTINNGANCHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGUOIID)
				.HasColumnName("NGUOIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HOVATEN)
				.HasColumnName("HOVATEN")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.SOGIAYTO)
				.HasColumnName("SOGIAYTO")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.DAICHI)
				.HasColumnName("DAICHI")
				.IsUnicode(false)
				.HasMaxLength(256);
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(256);
			this.Property(t => t.QUOCTICHID)
				.HasColumnName("QUOCTICHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DVHCID)
				.HasColumnName("DVHCID")
				.IsUnicode(false)
				.HasMaxLength(10);
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");

			this.ToTable("DC_NGANCHANNGUOI"); 
		} 
	} 
}