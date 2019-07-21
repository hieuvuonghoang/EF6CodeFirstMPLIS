namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIBIENDONG_Configuration : EntityTypeConfiguration<DM_LOAIBIENDONG> 
	{ 
		public DM_LOAIBIENDONG_Configuration() 
		{ 
			this.HasKey(t => t.LOAIBIENDONGID); 
			
			this.Property(t => t.LOAIBIENDONGID)
				.HasColumnName("LOAIBIENDONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MABIENDONG)
				.HasColumnName("MABIENDONG")
				.IsUnicode(false)
				.HasMaxLength(3);
			this.Property(t => t.TENLOAIBIENDONG)
				.HasColumnName("TENLOAIBIENDONG")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.NGUOISUDUNG)
				.HasColumnName("NGUOISUDUNG")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.TRANGTHAI)
				.HasColumnName("TRANGTHAI")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.uid)
				.HasColumnName("uid")
				.IsUnicode(false)
				.HasMaxLength(250);
			this.Property(t => t.VAITROCHUVAO)
				.HasColumnName("VAITROCHUVAO")
				.IsUnicode(false)
				.HasMaxLength(250);
			this.Property(t => t.VAITROCHURA)
				.HasColumnName("VAITROCHURA")
				.IsUnicode(false)
				.HasMaxLength(250);
			this.Property(t => t.TENBANGDULIEU)
				.HasColumnName("TENBANGDULIEU")
				.IsUnicode(false)
				.HasMaxLength(40);

			this.ToTable("DM_LOAIBIENDONG"); 
		} 
	} 
}