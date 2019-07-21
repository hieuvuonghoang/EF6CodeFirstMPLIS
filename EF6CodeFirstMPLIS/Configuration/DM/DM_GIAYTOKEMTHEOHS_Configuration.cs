namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_GIAYTOKEMTHEOHS_Configuration : EntityTypeConfiguration<DM_GIAYTOKEMTHEOHS> 
	{ 
		public DM_GIAYTOKEMTHEOHS_Configuration() 
		{ 
			this.HasKey(t => t.GIAYTOKEMTHEOHSID); 
			
			this.Property(t => t.GIAYTOKEMTHEOHSID)
				.HasColumnName("GIAYTOKEMTHEOHSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENGIAYTOKEMTHEOHS)
				.HasColumnName("TENGIAYTOKEMTHEOHS")
				.IsUnicode(false)
				.HasMaxLength(2000);
			this.Property(t => t.MAUGIAYTO)
				.HasColumnName("MAUGIAYTO");
			this.Property(t => t.THUTUSAPXEP)
				.HasColumnName("THUTUSAPXEP")
				.IsUnicode(false)
				.HasMaxLength(15);
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
			this.Property(t => t.KYHIEU)
				.HasColumnName("KYHIEU")
				.IsUnicode(false)
				.HasMaxLength(15);

			this.ToTable("DM_GIAYTOKEMTHEOHS"); 
		} 
	} 
}