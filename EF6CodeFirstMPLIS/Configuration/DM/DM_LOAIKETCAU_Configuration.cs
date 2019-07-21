namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIKETCAU_Configuration : EntityTypeConfiguration<DM_LOAIKETCAU> 
	{ 
		public DM_LOAIKETCAU_Configuration() 
		{ 
			this.HasKey(t => t.LOAIKETCAUID); 
			
			this.Property(t => t.LOAIKETCAUID)
				.HasColumnName("LOAIKETCAUID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIKETCAU)
				.HasColumnName("MALOAIKETCAU")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIKETCAU)
				.HasColumnName("TENLOAIKETCAU")
				.IsUnicode(false)
				.HasMaxLength(20);
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

			this.ToTable("DM_LOAIKETCAU"); 
		} 
	} 
}