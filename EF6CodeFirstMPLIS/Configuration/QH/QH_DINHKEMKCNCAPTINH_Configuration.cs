namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_DINHKEMKCNCAPTINH_Configuration : EntityTypeConfiguration<QH_DINHKEMKCNCAPTINH> 
	{ 
		public QH_DINHKEMKCNCAPTINH_Configuration() 
		{ 
			this.HasKey(t => t.DINHKEMKCNCAPTINHID); 
			
			this.Property(t => t.DINHKEMKCNCAPTINHID)
				.HasColumnName("DINHKEMKCNCAPTINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.KHUCHUCNANGCAPTINHID)
				.HasColumnName("KHUCHUCNANGCAPTINHID")
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
			
			this.HasRequired<QH_KHUCHUCNANGCAPTINH>(t => t.QH_KHUCHUCNANGCAPTINH)
				.WithMany(m => m.QH_DINHKEMKCNCAPTINH)
				.HasForeignKey(m => m.KHUCHUCNANGCAPTINHID);  

			this.ToTable("QH_DINHKEMKCNCAPTINH"); 
		} 
	} 
}