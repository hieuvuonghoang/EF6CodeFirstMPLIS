namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_KHUCHUCNANGCAPTINHGEO_Configuration : EntityTypeConfiguration<QH_KHUCHUCNANGCAPTINHGEO> 
	{ 
		public QH_KHUCHUCNANGCAPTINHGEO_Configuration() 
		{ 
			this.HasKey(t => t.KHUCHUNANGCAPTINHID); 
			
			this.Property(t => t.KHUCHUNANGCAPTINHID)
				.HasColumnName("KHUCHUNANGCAPTINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MATINH)
				.HasColumnName("MATINH")
				.IsUnicode(false)
				.HasMaxLength(2);
			this.Property(t => t.TENKHUCHUCNANG)
				.HasColumnName("TENKHUCHUCNANG")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.LOAIKHUCHUCNANGCAPTINH)
				.HasColumnName("LOAIKHUCHUCNANGCAPTINH")
				.IsUnicode(false)
				.HasMaxLength(3);
			this.Property(t => t.NAMQUYHOACH)
				.HasColumnName("NAMQUYHOACH");
			this.Property(t => t.QHKHUCHUNANGCAPTINHID)
				.HasColumnName("QHKHUCHUNANGCAPTINHID")
				.IsUnicode(false)
				.HasMaxLength(36);

			this.ToTable("QH_KHUCHUCNANGCAPTINHGEO"); 
		} 
	} 
}