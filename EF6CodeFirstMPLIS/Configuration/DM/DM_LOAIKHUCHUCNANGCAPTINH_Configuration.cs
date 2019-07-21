namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIKHUCHUCNANGCAPTINH_Configuration : EntityTypeConfiguration<DM_LOAIKHUCHUCNANGCAPTINH> 
	{ 
		public DM_LOAIKHUCHUCNANGCAPTINH_Configuration() 
		{ 
			this.HasKey(t => t.LOAIKHUCHUCNANGCAPTINHID); 
			
			this.Property(t => t.LOAIKHUCHUCNANGCAPTINHID)
				.HasColumnName("LOAIKHUCHUCNANGCAPTINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIKHUCHUCNANGCAPTINH)
				.HasColumnName("MALOAIKHUCHUCNANGCAPTINH")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIKHUCHUCNANGCAPTINH)
				.HasColumnName("TENLOAIKHUCHUCNANGCAPTINH")
				.IsUnicode(false)
				.HasMaxLength(100);
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

			this.ToTable("DM_LOAIKHUCHUCNANGCAPTINH"); 
		} 
	} 
}