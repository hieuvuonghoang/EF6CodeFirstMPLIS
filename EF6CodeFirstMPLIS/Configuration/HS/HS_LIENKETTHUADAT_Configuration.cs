namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HS_LIENKETTHUADAT_Configuration : EntityTypeConfiguration<HS_LIENKETTHUADAT> 
	{ 
		public HS_LIENKETTHUADAT_Configuration() 
		{ 
			this.HasKey(t => t.LIENKETTHUADATID);

            this.Property(t => t.LIENKETTHUADATID)
                .HasColumnName("LIENKETTHUADATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.KVHCID)
                .HasColumnName("KVHCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TOTHUAID)
				.HasColumnName("TOTHUAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HOSOID)
				.HasColumnName("HOSOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOTO)
				.HasColumnName("SOTO")
				.IsUnicode(false)
				.HasMaxLength(25);
			this.Property(t => t.SOTHUA)
				.HasColumnName("SOTHUA")
				.IsUnicode(false)
				.HasMaxLength(25);
			this.Property(t => t.MOTA)
				.HasColumnName("MOTA")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THUAID)
				.HasColumnName("THUAID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<HC_DMKVHC>(t => t.HC_DMKVHC)
				.WithMany(m => m.HS_LIENKETTHUADAT)
				.HasForeignKey(m => m.KVHCID);
            this.HasRequired<HS_HOSO>(t => t.HS_HOSO)
                .WithMany(m => m.HS_LIENKETTHUADAT)
                .HasForeignKey(m => m.HOSOID);

            this.ToTable("HS_LIENKETTHUADAT"); 
		} 
	} 
}