namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_LOAICHEDOMIENGIAM_Configuration : EntityTypeConfiguration<DC_LOAICHEDOMIENGIAM> 
	{ 
		public DC_LOAICHEDOMIENGIAM_Configuration() 
		{ 
			this.HasKey(t => t.LOAICHEDOMIENGIAMID); 
			
			this.Property(t => t.LOAICHEDOMIENGIAMID)
				.HasColumnName("LOAICHEDOMIENGIAMID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENLOAICHEDOMIENGIAM)
				.HasColumnName("TENLOAICHEDOMIENGIAM")
				.IsUnicode(false)
				.HasMaxLength(200);
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

			this.ToTable("DC_LOAICHEDOMIENGIAM"); 
		} 
	} 
}