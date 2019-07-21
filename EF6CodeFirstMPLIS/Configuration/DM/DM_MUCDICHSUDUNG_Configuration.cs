namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_MUCDICHSUDUNG_Configuration : EntityTypeConfiguration<DM_MUCDICHSUDUNG> 
	{ 
		public DM_MUCDICHSUDUNG_Configuration() 
		{ 
			this.HasKey(t => t.MUCDICHSUDUNGID); 
			
			this.Property(t => t.MUCDICHSUDUNGID)
				.HasColumnName("MUCDICHSUDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.KHOACHAID)
				.HasColumnName("KHOACHAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MAMUCDICHSUDUNG)
				.HasColumnName("MAMUCDICHSUDUNG")
				.IsUnicode(false)
				.HasMaxLength(4);
			this.Property(t => t.TENMUCDICHSUDUNG)
				.HasColumnName("TENMUCDICHSUDUNG")
				.IsUnicode(false)
				.HasMaxLength(120);
			this.Property(t => t.THUTUSAPXEP)
				.HasColumnName("THUTUSAPXEP")
				.IsUnicode(false)
				.HasMaxLength(10);
            this.Property(t => t.THOIHANMACDINH)
                .HasColumnName("THOIHANMACDINH");
			this.Property(t => t.CANCUPHAPLY)
				.HasColumnName("CANCUPHAPLY")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.PHIENBAN)
				.HasColumnName("PHIENBAN")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.CHITIET)
                .HasColumnName("CHITIET");

			this.ToTable("DM_MUCDICHSUDUNG"); 
		} 
	} 
}