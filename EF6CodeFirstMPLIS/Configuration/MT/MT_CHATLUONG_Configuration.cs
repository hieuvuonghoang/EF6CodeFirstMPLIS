namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class MT_CHATLUONG_Configuration : EntityTypeConfiguration<MT_CHATLUONG> 
	{ 
		public MT_CHATLUONG_Configuration() 
		{ 
			this.HasKey(t => t.MCHATLUONGID); 
			
			this.Property(t => t.MCHATLUONGID)
				.HasColumnName("MCHATLUONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MUCCHATLUONG)
				.HasColumnName("MUCCHATLUONG")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.MOTA)
				.HasColumnName("MOTA")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.NGUONGOCDULIEU)
				.HasColumnName("NGUONGOCDULIEU")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.LOAIPHUONGPHAPDANHGIA)
				.HasColumnName("LOAIPHUONGPHAPDANHGIA")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.PHUONGPHAPKIEMTRA)
				.HasColumnName("PHUONGPHAPKIEMTRA")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.KETLUANKIEMTRA)
				.HasColumnName("KETLUANKIEMTRA")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.MOTAKIEMTRA)
				.HasColumnName("MOTAKIEMTRA")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.GIAITHICHKIEMTRA)
				.HasColumnName("GIAITHICHKIEMTRA")
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

			this.ToTable("MT_CHATLUONG"); 
		} 
	} 
}