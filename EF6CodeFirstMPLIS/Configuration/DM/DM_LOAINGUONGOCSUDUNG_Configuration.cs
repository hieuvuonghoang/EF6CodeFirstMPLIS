namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAINGUONGOCSUDUNG_Configuration : EntityTypeConfiguration<DM_LOAINGUONGOCSUDUNG> 
	{ 
		public DM_LOAINGUONGOCSUDUNG_Configuration() 
		{ 
			this.HasKey(t => t.LOAINGUONGOCSUDUNGID); 
			
			this.Property(t => t.LOAINGUONGOCSUDUNGID)
				.HasColumnName("LOAINGUONGOCSUDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MANGUONGOCSUDUNG)
				.HasColumnName("MANGUONGOCSUDUNG")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.TENNGUONGOCSUDUNG)
				.HasColumnName("TENNGUONGOCSUDUNG")
				.IsUnicode(false)
				.HasMaxLength(400);
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

			this.ToTable("DM_LOAINGUONGOCSUDUNG"); 
		} 
	} 
}