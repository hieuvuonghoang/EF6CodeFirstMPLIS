namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_HOGIADINH_Configuration : EntityTypeConfiguration<DC_HOGIADINH> 
	{ 
		public DC_HOGIADINH_Configuration() 
		{ 
			this.HasKey(t => t.HOGIADINHID); 
			
			this.Property(t => t.HOGIADINHID)
				.HasColumnName("HOGIADINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.CHUHO)
				.HasColumnName("CHUHO")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.VOCHONG)
				.HasColumnName("VOCHONG")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.DIACHIID)
				.HasColumnName("DIACHIID")
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
			this.Property(t => t.CMTCHUHO)
				.HasColumnName("CMTCHUHO")
				.IsUnicode(false)
				.HasMaxLength(30);
			this.Property(t => t.CMTVOCHONG)
				.HasColumnName("CMTVOCHONG")
				.IsUnicode(false)
				.HasMaxLength(30);

			this.ToTable("DC_HOGIADINH"); 
		} 
	} 
}