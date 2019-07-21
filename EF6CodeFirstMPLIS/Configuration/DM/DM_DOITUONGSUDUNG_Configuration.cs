namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_DOITUONGSUDUNG_Configuration : EntityTypeConfiguration<DM_DOITUONGSUDUNG> 
	{ 
		public DM_DOITUONGSUDUNG_Configuration() 
		{ 
			this.HasKey(t => t.DOITUONGSUDUNGID); 
			
			this.Property(t => t.DOITUONGSUDUNGID)
				.HasColumnName("DOITUONGSUDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MADOITUONGSUDUNG)
				.HasColumnName("MADOITUONGSUDUNG")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENDOITUONGSUDUNG)
				.HasColumnName("TENDOITUONGSUDUNG")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAICHU)
				.HasColumnName("LOAICHU");

			this.ToTable("DM_DOITUONGSUDUNG"); 
		} 
	} 
}