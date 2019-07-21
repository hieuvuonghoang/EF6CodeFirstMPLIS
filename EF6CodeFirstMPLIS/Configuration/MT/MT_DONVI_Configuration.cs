namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class MT_DONVI_Configuration : EntityTypeConfiguration<MT_DONVI> 
	{ 
		public MT_DONVI_Configuration() 
		{ 
			this.HasKey(t => t.DONVIID); 
			
			this.Property(t => t.DONVIID)
				.HasColumnName("DONVIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENLOAIDONVI)
				.HasColumnName("TENLOAIDONVI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.TENDONVI)
				.HasColumnName("TENDONVI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.NGUOIDAIDIEN)
				.HasColumnName("NGUOIDAIDIEN")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.CHUCVU)
				.HasColumnName("CHUCVU")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.VAITRO)
				.HasColumnName("VAITRO")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.EMAIL)
				.HasColumnName("EMAIL")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.DIENTHOAI)
				.HasColumnName("DIENTHOAI")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.MLANDDATAID)
				.HasColumnName("MLANDDATAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.UID)
				.HasColumnName("UID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");

			this.ToTable("MT_DONVI"); 
		} 
	} 
}