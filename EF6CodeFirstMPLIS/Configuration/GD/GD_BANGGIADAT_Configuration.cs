namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class GD_BANGGIADAT_Configuration : EntityTypeConfiguration<GD_BANGGIADAT> 
	{ 
		public GD_BANGGIADAT_Configuration() 
		{ 
			this.HasKey(t => t.BANGGIADATID); 
			
			this.Property(t => t.BANGGIADATID)
				.HasColumnName("BANGGIADATID")
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
			this.Property(t => t.BANGSO)
				.HasColumnName("BANGSO");
			this.Property(t => t.FILEDINHKEM)
				.HasColumnName("FILEDINHKEM")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.QDGIADATID)
				.HasColumnName("QDGIADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
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
			
			this.HasRequired<GD_QDGIADAT>(t => t.GD_QDGIADAT)
				.WithMany(m => m.GD_BANGGIADAT)
				.HasForeignKey(m => m.QDGIADATID);  

			this.ToTable("GD_BANGGIADAT"); 
		} 
	} 
}