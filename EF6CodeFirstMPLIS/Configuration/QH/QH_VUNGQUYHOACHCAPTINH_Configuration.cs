namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_VUNGQUYHOACHCAPTINH_Configuration : EntityTypeConfiguration<QH_VUNGQUYHOACHCAPTINH> 
	{ 
		public QH_VUNGQUYHOACHCAPTINH_Configuration() 
		{ 
			this.HasKey(t => t.VUNGQUYHOACHCAPTINHID); 
			
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
				.HasMaxLength(50);
			this.Property(t => t.MUCDICHSUDUNGQH)
				.HasColumnName("MUCDICHSUDUNGQH")
				.IsUnicode(false)
				.HasMaxLength(3);
			this.Property(t => t.NAMQUYHOACH)
				.HasColumnName("NAMQUYHOACH");

			this.ToTable("QH_VUNGQUYHOACHCAPTINH"); 
		} 
	} 
}