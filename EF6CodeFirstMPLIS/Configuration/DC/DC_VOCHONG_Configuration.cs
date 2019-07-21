namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_VOCHONG_Configuration : EntityTypeConfiguration<DC_VOCHONG> 
	{ 
		public DC_VOCHONG_Configuration() 
		{ 
			this.HasKey(t => t.VOCHONGID); 
			
			this.Property(t => t.VOCHONGID)
				.HasColumnName("VOCHONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.CHONG)
				.HasColumnName("CHONG")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.VO)
				.HasColumnName("VO")
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
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.CMTCHONG)
				.HasColumnName("CMTCHONG")
				.IsUnicode(false)
				.HasMaxLength(30);
			this.Property(t => t.CMTVO)
				.HasColumnName("CMTVO")
				.IsUnicode(false)
				.HasMaxLength(30);

			this.ToTable("DC_VOCHONG"); 
		} 
	} 
}