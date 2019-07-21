namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_NHOMNGUOI_Configuration : EntityTypeConfiguration<DC_NHOMNGUOI> 
	{ 
		public DC_NHOMNGUOI_Configuration() 
		{ 
			this.HasKey(t => t.NHOMNGUOIID); 
			
			this.Property(t => t.NHOMNGUOIID)
				.HasColumnName("NHOMNGUOIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGUOIDAIDIEN)
				.HasColumnName("NGUOIDAIDIEN")
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
			this.Property(t => t.CMTNGUOIDAIDIEN)
				.HasColumnName("CMTNGUOIDAIDIEN")
				.IsUnicode(false)
				.HasMaxLength(30);

			this.ToTable("DC_NHOMNGUOI"); 
		} 
	} 
}