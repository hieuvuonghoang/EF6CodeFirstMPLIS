namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_CAPTINH_Configuration : EntityTypeConfiguration<QH_CAPTINH> 
	{ 
		public QH_CAPTINH_Configuration() 
		{ 
			this.HasKey(t => t.CAPTINHID);

            this.Property(t => t.CAPTINHID)
                .HasColumnName("CAPTINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.VUNGQUYHOACHCAPTINHID)
				.HasColumnName("VUNGQUYHOACHCAPTINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MATINH)
				.HasColumnName("MATINH")
				.IsUnicode(false)
				.HasMaxLength(2);
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
			this.Property(t => t.QUYHOACHCAPTINHID)
				.HasColumnName("QUYHOACHCAPTINHID")
				.IsUnicode(false)
				.HasMaxLength(36);

			this.ToTable("QH_CAPTINH"); 
		} 
	} 
}