namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class MT_HEQUYCHIEU_Configuration : EntityTypeConfiguration<MT_HEQUYCHIEU> 
	{ 
		public MT_HEQUYCHIEU_Configuration() 
		{ 
			this.HasKey(t => t.HEQUYCHIEUID); 
			
			this.Property(t => t.HEQUYCHIEUID)
				.HasColumnName("HEQUYCHIEUID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENHEQUYCHIEU)
				.HasColumnName("TENHEQUYCHIEU")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.MAHEQUYCHIEU)
				.HasColumnName("MAHEQUYCHIEU")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.NGAYBANHANH)
				.HasColumnName("NGAYBANHANH");
			this.Property(t => t.MUICHIEU)
				.HasColumnName("MUICHIEU")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.KINHTUYENTRUC)
				.HasColumnName("KINHTUYENTRUC")
				.IsUnicode(false)
				.HasMaxLength(100);
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

			this.ToTable("MT_HEQUYCHIEU"); 
		} 
	} 
}