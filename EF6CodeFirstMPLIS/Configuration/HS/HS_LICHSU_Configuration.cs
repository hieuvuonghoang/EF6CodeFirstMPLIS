namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HS_LICHSU_Configuration : EntityTypeConfiguration<HS_LICHSU> 
	{ 
		public HS_LICHSU_Configuration() 
		{ 
			this.HasKey(t => t.LICHSUHOSOID);

            this.Property(t => t.LICHSUHOSOID)
                .HasColumnName("LICHSUHOSOID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.KVHCID)
				.HasColumnName("KVHCID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HOSOID)
				.HasColumnName("HOSOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HOSOTRUOCID)
				.HasColumnName("HOSOTRUOCID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HOSOSAUID)
				.HasColumnName("HOSOSAUID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.UID)
				.HasColumnName("UID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.OID)
				.HasColumnName("OID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<HC_DMKVHC>(t => t.HC_DMKVHC)
				.WithMany(m => m.HS_LICHSU)
				.HasForeignKey(m => m.KVHCID);
            this.HasRequired<HS_HOSO>(t => t.HS_HOSO)
                .WithMany(m => m.HS_LICHSU)
                .HasForeignKey(m => m.HOSOID)
                .WillCascadeOnDelete(false);

            this.ToTable("HS_LICHSU"); 
		} 
	} 
}