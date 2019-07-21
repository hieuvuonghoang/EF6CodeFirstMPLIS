namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QH_MDSD_CT_Configuration : EntityTypeConfiguration<QH_MDSD_CT> 
	{ 
		public QH_MDSD_CT_Configuration() 
		{ 
			this.HasKey(t => t.MDSDCTID);

            this.Property(t => t.MDSDCTID)
                .HasColumnName("MDSDCTID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MDSDID)
				.HasColumnName("MDSDID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MAMDSD)
				.HasColumnName("MAMDSD")
				.IsUnicode(false)
				.HasMaxLength(3);
			this.Property(t => t.DIENTICH)
				.HasColumnName("DIENTICH");
			this.Property(t => t.BIEUBANGCAPTINHID)
				.HasColumnName("BIEUBANGCAPTINHID")
				.IsUnicode(false)
				.HasMaxLength(36);

			this.ToTable("QH_MDSD_CT"); 
		} 
	} 
}