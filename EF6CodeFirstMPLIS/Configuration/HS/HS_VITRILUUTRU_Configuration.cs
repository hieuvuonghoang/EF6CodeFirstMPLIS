namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HS_VITRILUUTRU_Configuration : EntityTypeConfiguration<HS_VITRILUUTRU> 
	{ 
		public HS_VITRILUUTRU_Configuration() 
		{ 
			this.HasKey(t => t.VITRILUUTRUID); 
			
			this.Property(t => t.VITRILUUTRUID)
				.HasColumnName("VITRILUUTRUID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.KHOACHAID)
				.HasColumnName("KHOACHAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MAVITRILUUTRU)
				.HasColumnName("MAVITRILUUTRU")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENVITRILUUTRU)
				.HasColumnName("TENVITRILUUTRU")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.MOTA)
				.HasColumnName("MOTA")
				.IsUnicode(false)
				.HasMaxLength(250);
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SODOVITRI)
				.HasColumnName("SODOVITRI");
            this.Property(t => t.TRANGTHAI)
                .HasColumnName("TRANGTHAI");
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);

			this.ToTable("HS_VITRILUUTRU"); 
		} 
	} 
}