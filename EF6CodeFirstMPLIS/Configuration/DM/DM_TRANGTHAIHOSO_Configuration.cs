namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_TRANGTHAIHOSO_Configuration : EntityTypeConfiguration<DM_TRANGTHAIHOSO> 
	{ 
		public DM_TRANGTHAIHOSO_Configuration() 
		{ 
			this.HasKey(t => t.TRANGTHAIHOSOID); 
			
			this.Property(t => t.TRANGTHAIHOSOID)
				.HasColumnName("TRANGTHAIHOSOID")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.TENTRANGTHAI)
				.HasColumnName("TENTRANGTHAI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.UID)
				.HasColumnName("UID")
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

			this.ToTable("DM_TRANGTHAIHOSO"); 
		} 
	} 
}