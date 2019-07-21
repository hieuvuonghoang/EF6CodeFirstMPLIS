namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HT_CAUHINH_Configuration : EntityTypeConfiguration<HT_CAUHINH> 
	{ 
		public HT_CAUHINH_Configuration() 
		{ 
			this.HasKey(t => t.CAUHINHID); 
			
			this.Property(t => t.CAUHINHID)
				.HasColumnName("CAUHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENCAUHINH)
				.HasColumnName("TENCAUHINH")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.GIATRI)
				.HasColumnName("GIATRI")
				.IsUnicode(false)
				.HasMaxLength(255);
            this.Property(t => t.CAP)
                .HasColumnName("CAP");
			this.Property(t => t.MADONVIHANHCHINHID)
				.HasColumnName("MADONVIHANHCHINHID")
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

			this.ToTable("HT_CAUHINH"); 
		} 
	} 
}