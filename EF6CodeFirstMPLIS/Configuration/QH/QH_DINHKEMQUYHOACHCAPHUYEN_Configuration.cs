namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_DINHKEMQUYHOACHCAPHUYEN_Configuration : EntityTypeConfiguration<QH_DINHKEMQUYHOACHCAPHUYEN> 
	{ 
		public QH_DINHKEMQUYHOACHCAPHUYEN_Configuration() 
		{ 
			this.HasKey(t => t.DINHKEMQUYHOACHCAPHUYENID); 
			
			this.Property(t => t.DINHKEMQUYHOACHCAPHUYENID)
				.HasColumnName("DINHKEMQUYHOACHCAPHUYENID")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.QUYHOACHCAPHUYENID)
				.HasColumnName("QUYHOACHCAPHUYENID")
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
			
			this.HasRequired<QH_QUYHOACHCAPHUYEN>(t => t.QH_QUYHOACHCAPHUYEN)
				.WithMany(m => m.QH_DINHKEMQUYHOACHCAPHUYEN)
				.HasForeignKey(m => m.QUYHOACHCAPHUYENID);  

			this.ToTable("QH_DINHKEMQUYHOACHCAPHUYEN"); 
		} 
	} 
}