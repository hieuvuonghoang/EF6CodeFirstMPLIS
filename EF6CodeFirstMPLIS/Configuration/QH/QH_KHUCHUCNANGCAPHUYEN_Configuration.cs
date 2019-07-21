namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_KHUCHUCNANGCAPHUYEN_Configuration : EntityTypeConfiguration<QH_KHUCHUCNANGCAPHUYEN> 
	{ 
		public QH_KHUCHUCNANGCAPHUYEN_Configuration() 
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
			this.Property(t => t.NAMTHANHLAP)
				.HasColumnName("NAMTHANHLAP");
			this.Property(t => t.TYLEBANDO)
				.HasColumnName("TYLEBANDO")
				.IsUnicode(false)
				.HasMaxLength(10);
			this.Property(t => t.NGUONTHANHLAP)
				.HasColumnName("NGUONTHANHLAP")
				.IsUnicode(false)
				.HasMaxLength(30);
			this.Property(t => t.COQUANDUYET)
				.HasColumnName("COQUANDUYET")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.COQUANTHAMDINH)
				.HasColumnName("COQUANTHAMDINH")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.COQUANLAP)
				.HasColumnName("COQUANLAP")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.DONVITUVAN)
				.HasColumnName("DONVITUVAN")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.SOPHEDUYET)
				.HasColumnName("SOPHEDUYET")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.NGAYPHEDUYET)
				.HasColumnName("NGAYPHEDUYET");
			this.Property(t => t.TENDUAN)
				.HasColumnName("TENDUAN")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.FILEBANDO)
				.HasColumnName("FILEBANDO")
				.IsUnicode(false)
				.HasMaxLength(2000);

			this.ToTable("QH_KHUCHUCNANGCAPHUYEN"); 
		} 
	} 
}