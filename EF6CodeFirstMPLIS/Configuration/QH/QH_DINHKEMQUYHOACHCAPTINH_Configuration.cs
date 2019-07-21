namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_DINHKEMQUYHOACHCAPTINH_Configuration : EntityTypeConfiguration<QH_DINHKEMQUYHOACHCAPTINH> 
	{ 
		public QH_DINHKEMQUYHOACHCAPTINH_Configuration() 
		{ 
			this.HasKey(t => t.DINHKEMQUYHOACHCAPTINHID); 
			
			this.Property(t => t.DINHKEMQUYHOACHCAPTINHID)
				.HasColumnName("DINHKEMQUYHOACHCAPTINHID")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.QUYHOACHCAPTINHID)
				.HasColumnName("QUYHOACHCAPTINHID")
				.IsUnicode(false)
				.HasMaxLength(100);
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
			
			this.HasRequired<QH_QUYHOACHCAPTINH>(t => t.QH_QUYHOACHCAPTINH)
				.WithMany(m => m.QH_DINHKEMQUYHOACHCAPTINH)
				.HasForeignKey(m => m.QUYHOACHCAPTINHID);  

			this.ToTable("QH_DINHKEMQUYHOACHCAPTINH"); 
		} 
	} 
}