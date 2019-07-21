namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAITOCHUC_Configuration : EntityTypeConfiguration<DM_LOAITOCHUC> 
	{ 
		public DM_LOAITOCHUC_Configuration() 
		{ 
			this.HasKey(t => t.LOAITOCHUCID); 
			
			this.Property(t => t.LOAITOCHUCID)
				.HasColumnName("LOAITOCHUCID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAITOCHUC)
				.HasColumnName("MALOAITOCHUC")
				.IsUnicode(false)
				.HasMaxLength(3);
			this.Property(t => t.TENLOAITOCHUC)
				.HasColumnName("TENLOAITOCHUC")
				.IsUnicode(false)
				.HasMaxLength(60);
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

			this.ToTable("DM_LOAITOCHUC"); 
		} 
	} 
}