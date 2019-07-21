namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_MUCDICHSUDUNGDATLS_Configuration : EntityTypeConfiguration<DC_MUCDICHSUDUNGDATLS> 
	{ 
		public DC_MUCDICHSUDUNGDATLS_Configuration() 
		{ 
			this.HasKey(t => t.MUCDICHSUDUNGDATLSID); 
			
			this.Property(t => t.MUCDICHSUDUNGDATLSID)
				.HasColumnName("MUCDICHSUDUNGDATLSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUADATLSID)
				.HasColumnName("THUADATLSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOTHUTUMDSD)
				.HasColumnName("SOTHUTUMDSD");
			this.Property(t => t.MUCDICHSUDUNGID)
				.HasColumnName("MUCDICHSUDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MUCDICHSUDUNGQHID)
				.HasColumnName("MUCDICHSUDUNGQHID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.DIENTICH)
                .HasColumnName("DIENTICH");
			this.Property(t => t.SUDUNGCHUNG)
				.HasColumnName("SUDUNGCHUNG");
			this.Property(t => t.THOIHANSUDUNG)
				.HasColumnName("THOIHANSUDUNG")
				.IsUnicode(false)
				.HasMaxLength(50);
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

			this.ToTable("DC_MUCDICHSUDUNGDATLS"); 
		} 
	} 
}