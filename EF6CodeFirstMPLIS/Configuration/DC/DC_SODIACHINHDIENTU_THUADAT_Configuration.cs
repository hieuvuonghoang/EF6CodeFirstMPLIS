namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_SODIACHINHDIENTU_THUADAT_Configuration : EntityTypeConfiguration<DC_SODIACHINHDIENTU_THUADAT> 
	{ 
		public DC_SODIACHINHDIENTU_THUADAT_Configuration() 
		{ 
			this.HasKey(t => t.SODIACHINHTHUADATID); 
			
			this.Property(t => t.SODIACHINHTHUADATID)
				.HasColumnName("SODIACHINHTHUADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUADATID)
				.HasColumnName("THUADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOTHUA)
				.HasColumnName("SOTHUA")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.SOTOBANDO)
				.HasColumnName("SOTOBANDO")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.MADVHC)
				.HasColumnName("MADVHC")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.NGAYTAO)
				.HasColumnName("NGAYTAO");
			this.Property(t => t.FILEPATH)
				.HasColumnName("FILEPATH")
				.IsUnicode(false)
				.HasMaxLength(255);
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

			this.ToTable("DC_SODIACHINHDIENTU_THUADAT"); 
		} 
	} 
}