namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HT_UNGDUNG_Configuration : EntityTypeConfiguration<HT_UNGDUNG> 
	{ 
		public HT_UNGDUNG_Configuration() 
		{ 
			this.HasKey(t => t.UNGDUNGID); 
			
			this.Property(t => t.UNGDUNGID)
				.HasColumnName("UNGDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENUNGDUNG)
				.HasColumnName("TENUNGDUNG")
				.IsUnicode(false)
				.HasMaxLength(80);
			this.Property(t => t.MOTA)
				.HasColumnName("MOTA")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.ICON)
				.HasColumnName("ICON");
			this.Property(t => t.CHOPHEPSUDUNG)
				.HasColumnName("CHOPHEPSUDUNG")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.THUTUSAPXEP)
				.HasColumnName("THUTUSAPXEP")
				.IsUnicode(false)
				.HasMaxLength(10);
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
			this.Property(t => t.URL)
				.HasColumnName("URL")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.MAUNGDUNG)
				.HasColumnName("MAUNGDUNG")
				.IsUnicode(false)
				.HasMaxLength(3);

			this.ToTable("HT_UNGDUNG"); 
		} 
	} 
}