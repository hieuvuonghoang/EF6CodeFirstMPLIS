namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HT_MAUGIAYTOKEMTHEOHS_Configuration : EntityTypeConfiguration<HT_MAUGIAYTOKEMTHEOHS> 
	{ 
		public HT_MAUGIAYTOKEMTHEOHS_Configuration() 
		{ 
			this.HasKey(t => t.MAUGIAYTOKEMTHEOHSID); 
			
			this.Property(t => t.MAUGIAYTOKEMTHEOHSID)
				.HasColumnName("MAUGIAYTOKEMTHEOHSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.GIAYTOKEMTHEOHSID)
				.HasColumnName("GIAYTOKEMTHEOHSID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.CAP)
                .HasColumnName("CAP");
			this.Property(t => t.MADONVIHANHCHINHID)
				.HasColumnName("MADONVIHANHCHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TEMPLATE)
				.HasColumnName("TEMPLATE");
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

			this.ToTable("HT_MAUGIAYTOKEMTHEOHS"); 
		} 
	} 
}