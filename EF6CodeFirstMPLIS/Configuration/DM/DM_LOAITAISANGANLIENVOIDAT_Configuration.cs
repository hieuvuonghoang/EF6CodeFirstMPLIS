namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAITAISANGANLIENVOIDAT_Configuration : EntityTypeConfiguration<DM_LOAITAISANGANLIENVOIDAT> 
	{ 
		public DM_LOAITAISANGANLIENVOIDAT_Configuration() 
		{ 
			this.HasKey(t => t.LOAITAISANGANLIENVOIDATID); 
			
			this.Property(t => t.LOAITAISANGANLIENVOIDATID)
				.HasColumnName("LOAITAISANGANLIENVOIDATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAITAISANGANLIENVOIDAT)
				.HasColumnName("MALOAITAISANGANLIENVOIDAT")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAITAISANGANLIENVOIDAT)
				.HasColumnName("TENLOAITAISANGANLIENVOIDAT")
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

			this.ToTable("DM_LOAITAISANGANLIENVOIDAT"); 
		} 
	} 
}