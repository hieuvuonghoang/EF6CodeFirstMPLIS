namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_QUYENSUDUNGDATSAUBD_Configuration : EntityTypeConfiguration<DC_QUYENSUDUNGDATSAUBD> 
	{ 
		public DC_QUYENSUDUNGDATSAUBD_Configuration() 
		{ 
			this.HasKey(t => t.QUYENSUDUNGDATSAUBDID); 
			
			this.Property(t => t.QUYENSUDUNGDATSAUBDID)
				.HasColumnName("QUYENSUDUNGDATSAUBDID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGUOIID)
				.HasColumnName("NGUOIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUADATID)
				.HasColumnName("THUADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DAMUCDICHSUDUNGID)
				.HasColumnName("DAMUCDICHSUDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGHIAVUTAICHINHID)
				.HasColumnName("NGHIAVUTAICHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HANCHEQUYENID)
				.HasColumnName("HANCHEQUYENID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.GIAYCHUNGNHANID)
				.HasColumnName("GIAYCHUNGNHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DONDANGKYID)
				.HasColumnName("DONDANGKYID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LAQUYENQUANLY)
				.HasColumnName("LAQUYENQUANLY")
				.IsUnicode(false)
				.HasMaxLength(1);

			this.ToTable("DC_QUYENSUDUNGDATSAUBD"); 
		} 
	} 
}