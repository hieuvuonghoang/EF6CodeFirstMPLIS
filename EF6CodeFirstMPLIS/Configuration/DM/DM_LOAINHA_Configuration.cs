namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAINHA_Configuration : EntityTypeConfiguration<DM_LOAINHA> 
	{ 
		public DM_LOAINHA_Configuration() 
		{ 
			this.HasKey(t => t.LOAINHAID); 
			
			this.Property(t => t.LOAINHAID)
				.HasColumnName("LOAINHAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAINHA)
				.HasColumnName("MALOAINHA")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.TENLOAINHA)
				.HasColumnName("TENLOAINHA")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(200);

			this.ToTable("DM_LOAINHA"); 
		} 
	} 
}