namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_NOICONGCHUNG_Configuration : EntityTypeConfiguration<DC_NOICONGCHUNG> 
	{ 
		public DC_NOICONGCHUNG_Configuration() 
		{ 
			this.HasKey(t => t.NOICONGCHUNGID); 
			
			this.Property(t => t.NOICONGCHUNGID)
				.HasColumnName("NOICONGCHUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENNOICONGCHUNG)
				.HasColumnName("TENNOICONGCHUNG")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(200);
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

			this.ToTable("DC_NOICONGCHUNG"); 
		} 
	} 
}