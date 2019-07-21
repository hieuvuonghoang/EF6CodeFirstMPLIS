namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_KHUCHUCNANGCAPHUYENGEO_Configuration : EntityTypeConfiguration<QH_KHUCHUCNANGCAPHUYENGEO> 
	{ 
		public QH_KHUCHUCNANGCAPHUYENGEO_Configuration() 
		{ 
			this.HasKey(t => t.KHUCHUCNANGCAPHUYENID); 
			
			this.Property(t => t.KHUCHUCNANGCAPHUYENID)
				.HasColumnName("KHUCHUCNANGCAPHUYENID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MATINH)
				.HasColumnName("MATINH")
				.IsUnicode(false)
				.HasMaxLength(2);
			this.Property(t => t.MAHUYEN)
				.HasColumnName("MAHUYEN")
				.IsUnicode(false)
				.HasMaxLength(3);
			this.Property(t => t.TENKHUCHUCNANG)
				.HasColumnName("TENKHUCHUCNANG")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.LOAIKHUCHUCNANGCAPHUYEN)
				.HasColumnName("LOAIKHUCHUCNANGCAPHUYEN")
				.IsUnicode(false)
				.HasMaxLength(3);
			this.Property(t => t.NAMQUYHOACH)
				.HasColumnName("NAMQUYHOACH");
			this.Property(t => t.QHCHUCNANGCAPHUYENID)
				.HasColumnName("QHCHUCNANGCAPHUYENID")
				.IsUnicode(false)
				.HasMaxLength(36);

			this.ToTable("QH_KHUCHUCNANGCAPHUYENGEO"); 
		} 
	} 
}