namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_DANTOC_Configuration : EntityTypeConfiguration<DM_DANTOC> 
	{ 
		public DM_DANTOC_Configuration() 
		{ 
			this.HasKey(t => t.DANTOCID); 
			
			this.Property(t => t.DANTOCID)
				.HasColumnName("DANTOCID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENDANTOC)
				.HasColumnName("TENDANTOC")
				.IsUnicode(false)
				.HasMaxLength(50);
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
			this.Property(t => t.TENGOIKHAC)
				.HasColumnName("TENGOIKHAC")
				.IsUnicode(false)
				.HasMaxLength(255);

			this.ToTable("DM_DANTOC"); 
		} 
	} 
}