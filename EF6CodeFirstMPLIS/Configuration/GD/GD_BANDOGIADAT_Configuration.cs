namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class GD_BANDOGIADAT_Configuration : EntityTypeConfiguration<GD_BANDOGIADAT> 
	{ 
		public GD_BANDOGIADAT_Configuration() 
		{ 
			this.HasKey(t => t.BANDOGIADATID); 
			
			this.Property(t => t.BANDOGIADATID)
				.HasColumnName("BANDOGIADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MATINH)
				.HasColumnName("MATINH")
				.IsUnicode(false)
				.HasMaxLength(2);
			this.Property(t => t.MAHUYEN)
				.HasColumnName("MAHUYEN")
				.IsUnicode(false)
				.HasMaxLength(3);
			this.Property(t => t.MAXA)
				.HasColumnName("MAXA")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.FILEDINHKEM)
				.HasColumnName("FILEDINHKEM")
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
			this.Property(t => t.TENFILE)
				.HasColumnName("TENFILE")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.NOIDUNGTOMTAT)
				.HasColumnName("NOIDUNGTOMTAT")
				.IsUnicode(false)
				.HasMaxLength(4000);
			this.Property(t => t.NAM)
				.HasColumnName("NAM");

			this.ToTable("GD_BANDOGIADAT"); 
		} 
	} 
}