namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAITRANGTHAIDANGKYCAPGCN_Configuration : EntityTypeConfiguration<DM_LOAITRANGTHAIDANGKYCAPGCN> 
	{ 
		public DM_LOAITRANGTHAIDANGKYCAPGCN_Configuration() 
		{ 
			this.HasKey(t => t.LOAITRANGTHAIDANGKYCAPGCNID); 
			
			this.Property(t => t.LOAITRANGTHAIDANGKYCAPGCNID)
				.HasColumnName("LOAITRANGTHAIDANGKYCAPGCNID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAITRANGTHAIDANGKYCAPGCN)
				.HasColumnName("MALOAITRANGTHAIDANGKYCAPGCN")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAITRANGTHAIDANGKYCAPGCN)
				.HasColumnName("TENLOAITRANGTHAIDANGKYCAPGCN")
				.IsUnicode(false)
				.HasMaxLength(100);
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

			this.ToTable("DM_LOAITRANGTHAIDANGKYCAPGCN"); 
		} 
	} 
}