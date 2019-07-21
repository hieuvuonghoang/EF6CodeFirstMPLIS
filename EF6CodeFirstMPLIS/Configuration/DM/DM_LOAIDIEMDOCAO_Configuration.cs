namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIDIEMDOCAO_Configuration : EntityTypeConfiguration<DM_LOAIDIEMDOCAO> 
	{ 
		public DM_LOAIDIEMDOCAO_Configuration() 
		{ 
			this.HasKey(t => t.LOAIDIEMDOCAOID); 
			
			this.Property(t => t.LOAIDIEMDOCAOID)
				.HasColumnName("LOAIDIEMDOCAOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIDIEMDOCAO)
				.HasColumnName("MALOAIDIEMDOCAO")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIDIEMDOCAO)
				.HasColumnName("TENLOAIDIEMDOCAO")
				.IsUnicode(false)
				.HasMaxLength(60);
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);

			this.ToTable("DM_LOAIDIEMDOCAO"); 
		} 
	} 
}