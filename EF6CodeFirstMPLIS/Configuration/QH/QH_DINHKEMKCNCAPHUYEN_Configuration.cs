namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_DINHKEMKCNCAPHUYEN_Configuration : EntityTypeConfiguration<QH_DINHKEMKCNCAPHUYEN> 
	{ 
		public QH_DINHKEMKCNCAPHUYEN_Configuration() 
		{ 
			this.HasKey(t => t.DINHKEMKCNCAPHUYENID); 
			
			this.Property(t => t.DINHKEMKCNCAPHUYENID)
				.HasColumnName("DINHKEMKCNCAPHUYENID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.KHUCHUCNANGCAPHUYENID)
				.HasColumnName("KHUCHUCNANGCAPHUYENID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENFILE)
				.HasColumnName("TENFILE")
				.IsUnicode(false)
				.HasMaxLength(500);
			this.Property(t => t.NGAYTAOFILE)
				.HasColumnName("NGAYTAOFILE");
			this.Property(t => t.NGUOICAPHATID)
				.HasColumnName("NGUOICAPHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(255); 
			
			this.HasRequired<QH_KHUCHUCNANGCAPHUYEN>(t => t.QH_KHUCHUCNANGCAPHUYEN)
				.WithMany(m => m.QH_DINHKEMKCNCAPHUYEN)
				.HasForeignKey(m => m.KHUCHUCNANGCAPHUYENID);  

			this.ToTable("QH_DINHKEMKCNCAPHUYEN"); 
		} 
	} 
}