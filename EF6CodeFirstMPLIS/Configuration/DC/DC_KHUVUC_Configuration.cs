namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_KHUVUC_Configuration : EntityTypeConfiguration<DC_KHUVUC> 
	{ 
		public DC_KHUVUC_Configuration() 
		{ 
			this.HasKey(t => t.KHUVUCID); 
			
			this.Property(t => t.KHUVUCID)
				.HasColumnName("KHUVUCID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.KVHCID)
                .HasColumnName("KVHCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENKHUVUC)
				.HasColumnName("TENKHUVUC")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.KVHCID)
                .HasColumnName("KVHCID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<HC_DMKVHC>(t => t.HC_DMKVHC)
                .WithMany(m => m.DC_KHUVUC)
                .HasForeignKey(m => m.KVHCID)
                .WillCascadeOnDelete(false);

            this.ToTable("DC_KHUVUC"); 
		} 
	} 
}