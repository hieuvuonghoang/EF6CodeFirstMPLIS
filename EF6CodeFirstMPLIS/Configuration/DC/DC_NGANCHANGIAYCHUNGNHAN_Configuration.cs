namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_NGANCHANGIAYCHUNGNHAN_Configuration : EntityTypeConfiguration<DC_NGANCHANGIAYCHUNGNHAN> 
	{ 
		public DC_NGANCHANGIAYCHUNGNHAN_Configuration() 
		{ 
			this.HasKey(t => t.NGANCHANGIAYID); 
			
			this.Property(t => t.NGANCHANGIAYID)
				.HasColumnName("NGANCHANGIAYID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THONGTINNGANCHANID)
				.HasColumnName("THONGTINNGANCHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.GIAYCHUNGNHANID)
				.HasColumnName("GIAYCHUNGNHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOHIEUGIAYCHUNGNHAN)
				.HasColumnName("SOHIEUGIAYCHUNGNHAN")
				.IsUnicode(false)
				.HasMaxLength(15);
			this.Property(t => t.SOHOSOGOC)
				.HasColumnName("SOHOSOGOC")
				.IsUnicode(false)
				.HasMaxLength(15);
			this.Property(t => t.SOVAOSO)
				.HasColumnName("SOVAOSO")
				.IsUnicode(false)
				.HasMaxLength(15);
			this.Property(t => t.CANCUCAPGIAY)
				.HasColumnName("CANCUCAPGIAY")
				.IsUnicode(false)
				.HasMaxLength(256);
			this.Property(t => t.NGAYCAPGIAYCHUNGNHAN)
				.HasColumnName("NGAYCAPGIAYCHUNGNHAN");
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(256);
			this.Property(t => t.DVHCID)
				.HasColumnName("DVHCID")
				.IsUnicode(false)
				.HasMaxLength(10);
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");

			this.ToTable("DC_NGANCHANGIAYCHUNGNHAN"); 
		} 
	} 
}