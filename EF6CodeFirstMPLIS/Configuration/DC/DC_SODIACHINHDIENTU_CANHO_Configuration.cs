namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_SODIACHINHDIENTU_CANHO_Configuration : EntityTypeConfiguration<DC_SODIACHINHDIENTU_CANHO> 
	{ 
		public DC_SODIACHINHDIENTU_CANHO_Configuration() 
		{ 
			this.HasKey(t => t.SODIACHINHCANHOID); 
			
			this.Property(t => t.SODIACHINHCANHOID)
				.HasColumnName("SODIACHINHCANHOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENTAISAN)
				.HasColumnName("TENTAISAN")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.LOAITAISAN)
				.HasColumnName("LOAITAISAN")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.TAISANID)
				.HasColumnName("TAISANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MADVHC)
				.HasColumnName("MADVHC")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.FILEPATH)
				.HasColumnName("FILEPATH")
				.IsUnicode(false)
				.HasMaxLength(256);
			this.Property(t => t.NGAYTAO)
				.HasColumnName("NGAYTAO");
			this.Property(t => t.THOIDIEMKY)
				.HasColumnName("THOIDIEMKY");
			this.Property(t => t.NGUOIKY)
				.HasColumnName("NGUOIKY")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.TINHTRANG)
				.HasColumnName("TINHTRANG")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);

			this.ToTable("DC_SODIACHINHDIENTU_CANHO"); 
		} 
	} 
}