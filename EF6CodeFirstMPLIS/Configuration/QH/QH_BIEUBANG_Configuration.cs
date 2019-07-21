namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_BIEUBANG_Configuration : EntityTypeConfiguration<QH_BIEUBANG> 
	{ 
		public QH_BIEUBANG_Configuration() 
		{ 
			this.HasKey(t => t.BIEUBANGID); 
			
			this.Property(t => t.BIEUBANGID)
				.HasColumnName("BIEUBANGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENBIEU)
				.HasColumnName("TENBIEU")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.TENCHITIET)
				.HasColumnName("TENCHITIET")
				.IsUnicode(false)
				.HasMaxLength(1000);
			this.Property(t => t.NAM)
				.HasColumnName("NAM");
			this.Property(t => t.QUYHOACHID)
				.HasColumnName("QUYHOACHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.CAPQUYHOACH)
				.HasColumnName("CAPQUYHOACH");

			this.ToTable("QH_BIEUBANG"); 
		} 
	} 
}