namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIBANDODIACHINH_Configuration : EntityTypeConfiguration<DM_LOAIBANDODIACHINH> 
	{ 
		public DM_LOAIBANDODIACHINH_Configuration() 
		{ 
			this.HasKey(t => t.LOAIBANDODIACHINHID); 
			
			this.Property(t => t.LOAIBANDODIACHINHID)
				.HasColumnName("LOAIBANDODIACHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIBANDODIACHINH)
				.HasColumnName("MALOAIBANDODIACHINH")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIBANDODIACHINH)
				.HasColumnName("TENLOAIBANDODIACHINH")
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

			this.ToTable("DM_LOAIBANDODIACHINH"); 
		} 
	} 
}