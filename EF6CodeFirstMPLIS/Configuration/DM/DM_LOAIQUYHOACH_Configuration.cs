namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIQUYHOACH_Configuration : EntityTypeConfiguration<DM_LOAIQUYHOACH> 
	{ 
		public DM_LOAIQUYHOACH_Configuration() 
		{ 
			this.HasKey(t => t.LOAIQUYHOACHID); 
			
			this.Property(t => t.LOAIQUYHOACHID)
				.HasColumnName("LOAIQUYHOACHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIQUYHOACH)
				.HasColumnName("MALOAIQUYHOACH")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIQUYHOACH)
				.HasColumnName("TENLOAIQUYHOACH")
				.IsUnicode(false)
				.HasMaxLength(60);
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

			this.ToTable("DM_LOAIQUYHOACH"); 
		} 
	} 
}