namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIKHUVUCTONGHOP_Configuration : EntityTypeConfiguration<DM_LOAIKHUVUCTONGHOP> 
	{ 
		public DM_LOAIKHUVUCTONGHOP_Configuration() 
		{ 
			this.HasKey(t => t.LOAIKHUVUCTONGHOPID); 
			
			this.Property(t => t.LOAIKHUVUCTONGHOPID)
				.HasColumnName("LOAIKHUVUCTONGHOPID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIKHUVUCTONGHOP)
				.HasColumnName("MALOAIKHUVUCTONGHOP")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIKHUVUCTONGHOP)
				.HasColumnName("TENLOAIKHUVUCTONGHOP")
				.IsUnicode(false)
				.HasMaxLength(80);
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

			this.ToTable("DM_LOAIKHUVUCTONGHOP"); 
		} 
	} 
}