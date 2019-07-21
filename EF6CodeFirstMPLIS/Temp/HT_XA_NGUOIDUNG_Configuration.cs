namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HT_XA_NGUOIDUNG_Configuration : EntityTypeConfiguration<HT_XA_NGUOIDUNG> 
	{ 
		public HT_XA_NGUOIDUNG_Configuration() 
		{ 
			this.HasKey(t => t.); 
			
			this.Property(t => t.NGUOIDUNGID)
				.HasColumnName("NGUOIDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT"); 
			
			this.HasRequired<>(t => t.)
				.WithMany(m => m.HT_XA_NGUOIDUNG)
				.HasForeignKey(m => m.);  

			this.ToTable("HT_XA_NGUOIDUNG"); 
		} 
	} 
}