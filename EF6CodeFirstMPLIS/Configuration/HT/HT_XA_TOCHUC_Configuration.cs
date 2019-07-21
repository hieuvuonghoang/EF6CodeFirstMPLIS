namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HT_XA_TOCHUC_Configuration : EntityTypeConfiguration<HT_XA_TOCHUC> 
	{ 
		public HT_XA_TOCHUC_Configuration() 
		{ 
			this.HasKey(t => t.XATOCHUCID);

            this.Property(t => t.XATOCHUCID)
                .HasColumnName("XATOCHUCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.KVHCID)
                .HasColumnName("KVHCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TOCHUCID)
				.HasColumnName("TOCHUCID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.uId)
				.HasColumnName("uId")
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
			
			this.HasRequired<HC_DMKVHC>(t => t.HC_DMKVHC)
				.WithMany(m => m.HT_XA_TOCHUC)
				.HasForeignKey(m => m.KVHCID);
            this.HasRequired<HT_TOCHUC>(t => t.HT_TOCHUC)
                .WithMany(m => m.HT_XA_TOCHUC)
                .HasForeignKey(m => m.TOCHUCID);

            this.ToTable("HT_XA_TOCHUC"); 
		} 
	} 
}