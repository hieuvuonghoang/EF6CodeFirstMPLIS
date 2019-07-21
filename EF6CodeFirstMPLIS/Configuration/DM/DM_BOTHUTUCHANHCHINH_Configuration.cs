namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_BOTHUTUCHANHCHINH_Configuration : EntityTypeConfiguration<DM_BOTHUTUCHANHCHINH> 
	{ 
		public DM_BOTHUTUCHANHCHINH_Configuration() 
		{ 
			this.HasKey(t => t.BOTHUTUCHANHCHINHID); 
			
			this.Property(t => t.BOTHUTUCHANHCHINHID)
				.HasColumnName("BOTHUTUCHANHCHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENBOTHUTUCHANHCHINH)
				.HasColumnName("TENBOTHUTUCHANHCHINH")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.CANCUPHAPLY)
				.HasColumnName("CANCUPHAPLY")
				.IsUnicode(false)
				.HasMaxLength(255);
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

			this.ToTable("DM_BOTHUTUCHANHCHINH"); 
		} 
	} 
}