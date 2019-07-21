namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIDIADANH_Configuration : EntityTypeConfiguration<DM_LOAIDIADANH> 
	{ 
		public DM_LOAIDIADANH_Configuration() 
		{ 
			this.HasKey(t => t.LOAIDIADANHID); 
			
			this.Property(t => t.LOAIDIADANHID)
				.HasColumnName("LOAIDIADANHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIDIADANH)
				.HasColumnName("MALOAIDIADANH")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIDIADANH)
				.HasColumnName("TENLOAIDIADANH")
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

			this.ToTable("DM_LOAIDIADANH"); 
		} 
	} 
}