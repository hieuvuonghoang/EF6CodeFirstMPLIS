namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_CAPHUYEN_Configuration : EntityTypeConfiguration<QH_CAPHUYEN> 
	{ 
		public QH_CAPHUYEN_Configuration() 
		{ 
			this.HasKey(t => t.CAPHUYENID);

            this.Property(t => t.CAPHUYENID)
                .HasColumnName("CAPHUYENID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.VUNGQUYHOACHCAPHUYENID)
				.HasColumnName("VUNGQUYHOACHCAPHUYENID")
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
			this.Property(t => t.TENVUNGQUYHOACH)
				.HasColumnName("TENVUNGQUYHOACH")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.MUCDICHSUDUNGQH)
				.HasColumnName("MUCDICHSUDUNGQH")
				.IsUnicode(false)
				.HasMaxLength(3);
			this.Property(t => t.NAMQUYHOACH)
				.HasColumnName("NAMQUYHOACH");
			this.Property(t => t.QUYHOACHCAPHUYENID)
				.HasColumnName("QUYHOACHCAPHUYENID")
				.IsUnicode(false)
				.HasMaxLength(36);

			this.ToTable("QH_CAPHUYEN"); 
		} 
	} 
}