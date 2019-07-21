namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_QUOCTICH_Configuration : EntityTypeConfiguration<DM_QUOCTICH> 
	{ 
		public DM_QUOCTICH_Configuration() 
		{ 
			this.HasKey(t => t.QUOCTICHID); 
			
			this.Property(t => t.QUOCTICHID)
				.HasColumnName("QUOCTICHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MAQUOCGIA)
				.HasColumnName("MAQUOCGIA")
				.IsUnicode(false)
				.HasMaxLength(3);
			this.Property(t => t.TENQUOCGIATV)
				.HasColumnName("TENQUOCGIATV")
				.IsUnicode(false)
				.HasMaxLength(150);
			this.Property(t => t.TENQUOCGIAQT)
				.HasColumnName("TENQUOCGIAQT")
				.IsUnicode(false)
				.HasMaxLength(150);
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
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);

			this.ToTable("DM_QUOCTICH"); 
		} 
	} 
}