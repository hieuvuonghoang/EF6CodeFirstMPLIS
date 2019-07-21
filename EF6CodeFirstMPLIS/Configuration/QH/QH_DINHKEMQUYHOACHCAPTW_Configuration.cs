namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_DINHKEMQUYHOACHCAPTW_Configuration : EntityTypeConfiguration<QH_DINHKEMQUYHOACHCAPTW> 
	{ 
		public QH_DINHKEMQUYHOACHCAPTW_Configuration() 
		{ 
			this.HasKey(t => t.DINHKEMQUYHOACHCAPTWID); 
			
			this.Property(t => t.DINHKEMQUYHOACHCAPTWID)
				.HasColumnName("DINHKEMQUYHOACHCAPTWID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.QUYHOACHCAPTWID)
				.HasColumnName("QUYHOACHCAPTWID")
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
			
			this.HasRequired<QH_QUYHOACHCAPTW>(t => t.QH_QUYHOACHCAPTW)
				.WithMany(m => m.QH_DINHKEMQUYHOACHCAPTW)
				.HasForeignKey(m => m.QUYHOACHCAPTWID);  

			this.ToTable("QH_DINHKEMQUYHOACHCAPTW"); 
		} 
	} 
}