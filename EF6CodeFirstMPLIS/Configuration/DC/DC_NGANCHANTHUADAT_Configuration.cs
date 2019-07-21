namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_NGANCHANTHUADAT_Configuration : EntityTypeConfiguration<DC_NGANCHANTHUADAT> 
	{ 
		public DC_NGANCHANTHUADAT_Configuration() 
		{ 
			this.HasKey(t => t.NGANCHANTHUADATID); 
			
			this.Property(t => t.NGANCHANTHUADATID)
				.HasColumnName("NGANCHANTHUADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THONGTINNGANCHANID)
				.HasColumnName("THONGTINNGANCHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUADATID)
				.HasColumnName("THUADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DVHCID)
				.HasColumnName("DVHCID")
				.IsUnicode(false)
				.HasMaxLength(10);
			this.Property(t => t.SOTHUA)
				.HasColumnName("SOTHUA");
			this.Property(t => t.SOTOBANDO)
				.HasColumnName("SOTOBANDO");
			this.Property(t => t.DIACHITHUADAT)
				.HasColumnName("DIACHITHUADAT")
				.IsUnicode(false)
				.HasMaxLength(256);
			this.Property(t => t.SOTHUATAM)
				.HasColumnName("SOTHUATAM")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.SOTOBANDOTAM)
				.HasColumnName("SOTOBANDOTAM")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");

			this.ToTable("DC_NGANCHANTHUADAT"); 
		} 
	} 
}