namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_LOAIBIENDONG_Configuration : EntityTypeConfiguration<DC_LOAIBIENDONG> 
	{ 
		public DC_LOAIBIENDONG_Configuration() 
		{ 
			this.HasKey(t => t.LOAIBIENDONGID); 
			
			this.Property(t => t.LOAIBIENDONGID)
				.HasColumnName("LOAIBIENDONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIBIENDONG)
				.HasColumnName("MALOAIBIENDONG")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.TENLOAIBIENDONG)
				.HasColumnName("TENLOAIBIENDONG")
				.IsUnicode(false)
				.HasMaxLength(500);
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

			this.ToTable("DC_LOAIBIENDONG"); 
		} 
	} 
}