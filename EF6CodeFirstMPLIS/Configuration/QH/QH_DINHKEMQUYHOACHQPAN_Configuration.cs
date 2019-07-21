namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_DINHKEMQUYHOACHQPAN_Configuration : EntityTypeConfiguration<QH_DINHKEMQUYHOACHQPAN> 
	{ 
		public QH_DINHKEMQUYHOACHQPAN_Configuration() 
		{ 
			this.HasKey(t => t.DINHKEMQUYHOACHQPANID); 
			
			this.Property(t => t.DINHKEMQUYHOACHQPANID)
				.HasColumnName("DINHKEMQUYHOACHQPANID")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.QUYHOACHQPANID)
				.HasColumnName("QUYHOACHQPANID")
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
			
			this.HasRequired<QH_QUYHOACHQPAN>(t => t.QH_QUYHOACHQPAN)
				.WithMany(m => m.QH_DINHKEMQUYHOACHQPAN)
				.HasForeignKey(m => m.QUYHOACHQPANID);  

			this.ToTable("QH_DINHKEMQUYHOACHQPAN"); 
		} 
	} 
}