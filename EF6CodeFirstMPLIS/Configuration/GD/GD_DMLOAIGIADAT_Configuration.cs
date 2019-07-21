namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class GD_DMLOAIGIADAT_Configuration : EntityTypeConfiguration<GD_DMLOAIGIADAT> 
	{ 
		public GD_DMLOAIGIADAT_Configuration() 
		{ 
			this.HasKey(t => t.LOAIGIADATID); 
			
			this.Property(t => t.LOAIGIADATID)
				.HasColumnName("LOAIGIADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAIGIADAT)
				.HasColumnName("LOAIGIADAT")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);

			this.ToTable("GD_DMLOAIGIADAT"); 
		} 
	} 
}