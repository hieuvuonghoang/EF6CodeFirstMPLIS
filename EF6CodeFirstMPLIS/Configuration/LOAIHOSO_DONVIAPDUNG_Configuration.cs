namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class LOAIHOSO_DONVIAPDUNG_Configuration : EntityTypeConfiguration<LOAIHOSO_DONVIAPDUNG> 
	{ 
		public LOAIHOSO_DONVIAPDUNG_Configuration() 
		{ 
			this.HasKey(t => t.LOAIHOSODONVIAPDUNGID); 
			
			this.Property(t => t.LOAIHOSODONVIAPDUNGID)
				.HasColumnName("LOAIHOSODONVIAPDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NHOMNGUOIDUNGID)
				.HasColumnName("NHOMNGUOIDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAIHOSOID)
				.HasColumnName("LOAIHOSOID")
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

			this.ToTable("LOAIHOSO_DONVIAPDUNG"); 
		} 
	} 
}