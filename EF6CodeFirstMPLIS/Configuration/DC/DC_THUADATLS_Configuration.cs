namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_THUADATLS_Configuration : EntityTypeConfiguration<DC_THUADATLS> 
	{ 
		public DC_THUADATLS_Configuration() 
		{ 
			this.HasKey(t => t.THUADATLSID); 
			
			this.Property(t => t.THUADATLSID)
				.HasColumnName("THUADATLSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MAXA)
				.HasColumnName("MAXA")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.SOHIEUTOBANDO)
				.HasColumnName("SOHIEUTOBANDO");
			this.Property(t => t.SOTHUTUTHUA)
				.HasColumnName("SOTHUTUTHUA");
			this.Property(t => t.SOHIEUTOBANDOCU)
				.HasColumnName("SOHIEUTOBANDOCU")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.SOTHUTUTHUACU)
				.HasColumnName("SOTHUTUTHUACU")
				.IsUnicode(false)
				.HasMaxLength(50);
            this.Property(t => t.DIENTICH)
                .HasColumnName("DIENTICH");
            this.Property(t => t.DIENTICHPHAPLY)
                .HasColumnName("DIENTICHPHAPLY");
			this.Property(t => t.TAILIEUDODACID)
				.HasColumnName("TAILIEUDODACID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LADOITUONGCHIEMDAT)
				.HasColumnName("LADOITUONGCHIEMDAT");
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
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(150);

			this.ToTable("DC_THUADATLS"); 
		} 
	} 
}