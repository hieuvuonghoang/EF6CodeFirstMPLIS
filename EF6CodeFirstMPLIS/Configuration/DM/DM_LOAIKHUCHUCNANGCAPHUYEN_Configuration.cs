namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIKHUCHUCNANGCAPHUYEN_Configuration : EntityTypeConfiguration<DM_LOAIKHUCHUCNANGCAPHUYEN> 
	{ 
		public DM_LOAIKHUCHUCNANGCAPHUYEN_Configuration() 
		{ 
			this.HasKey(t => t.LOAIKHUCHUCNANGCAPHUYENID); 
			
			this.Property(t => t.LOAIKHUCHUCNANGCAPHUYENID)
				.HasColumnName("LOAIKHUCHUCNANGCAPHUYENID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIKHUCHUCNANGCAPHUYEN)
				.HasColumnName("MALOAIKHUCHUCNANGCAPHUYEN")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIKHUCHUCNANGCAPHUYEN)
				.HasColumnName("TENLOAIKHUCHUCNANGCAPHUYEN")
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

			this.ToTable("DM_LOAIKHUCHUCNANGCAPHUYEN"); 
		} 
	} 
}