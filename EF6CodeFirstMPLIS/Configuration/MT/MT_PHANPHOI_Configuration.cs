namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class MT_PHANPHOI_Configuration : EntityTypeConfiguration<MT_PHANPHOI> 
	{ 
		public MT_PHANPHOI_Configuration() 
		{ 
			this.HasKey(t => t.PHANPHOIID); 
			
			this.Property(t => t.PHANPHOIID)
				.HasColumnName("PHANPHOIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENTEP)
				.HasColumnName("TENTEP")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.PHIENBAN)
				.HasColumnName("PHIENBAN")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MOTA)
				.HasColumnName("MOTA")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.DUONGDANPHANPHOI)
				.HasColumnName("DUONGDANPHANPHOI")
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

			this.ToTable("MT_PHANPHOI"); 
		} 
	} 
}