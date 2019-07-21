namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIDIEMTOADO_Configuration : EntityTypeConfiguration<DM_LOAIDIEMTOADO> 
	{ 
		public DM_LOAIDIEMTOADO_Configuration() 
		{ 
			this.HasKey(t => t.LOAIDIEMTOADOID); 
			
			this.Property(t => t.LOAIDIEMTOADOID)
				.HasColumnName("LOAIDIEMTOADOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIDIEMTOADO)
				.HasColumnName("MALOAIDIEMTOADO")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIDIEMTOADO)
				.HasColumnName("TENLOAIDIEMTOADO")
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

			this.ToTable("DM_LOAIDIEMTOADO"); 
		} 
	} 
}