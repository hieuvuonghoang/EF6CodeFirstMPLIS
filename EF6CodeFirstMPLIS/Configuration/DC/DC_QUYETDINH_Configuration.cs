namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_QUYETDINH_Configuration : EntityTypeConfiguration<DC_QUYETDINH> 
	{ 
		public DC_QUYETDINH_Configuration() 
		{ 
			this.HasKey(t => t.QUYETDINHID); 
			
			this.Property(t => t.QUYETDINHID)
				.HasColumnName("QUYETDINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOQUYETDINH)
				.HasColumnName("SOQUYETDINH")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.NGAYQUYETDINH)
				.HasColumnName("NGAYQUYETDINH");
			this.Property(t => t.NOIDUNGQUYETDINH)
				.HasColumnName("NOIDUNGQUYETDINH")
				.IsUnicode(false)
				.HasMaxLength(1000);
			this.Property(t => t.SOHOPDONG)
				.HasColumnName("SOHOPDONG")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.NGAYHOPDONG)
				.HasColumnName("NGAYHOPDONG");
			this.Property(t => t.GIATRIHOPDONG)
				.HasColumnName("GIATRIHOPDONG");
			this.Property(t => t.SOCONGCHUNG)
				.HasColumnName("SOCONGCHUNG")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.QUYENCONGCHUNG)
				.HasColumnName("QUYENCONGCHUNG")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.NOICONGCHUNG)
				.HasColumnName("NOICONGCHUNG")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.NGAYCONGCHUNG)
				.HasColumnName("NGAYCONGCHUNG");
			this.Property(t => t.NOIDUNGHOPDONG)
				.HasColumnName("NOIDUNGHOPDONG")
				.IsUnicode(false)
				.HasMaxLength(1000);
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

			this.ToTable("DC_QUYETDINH"); 
		} 
	} 
}