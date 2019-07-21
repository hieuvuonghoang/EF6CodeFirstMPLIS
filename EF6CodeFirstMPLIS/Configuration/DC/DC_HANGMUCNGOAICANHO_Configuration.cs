namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_HANGMUCNGOAICANHO_Configuration : EntityTypeConfiguration<DC_HANGMUCNGOAICANHO> 
	{ 
		public DC_HANGMUCNGOAICANHO_Configuration() 
		{ 
			this.HasKey(t => t.HANGMUCSOHUUCHUNGID); 
			
			this.Property(t => t.HANGMUCSOHUUCHUNGID)
				.HasColumnName("HANGMUCSOHUUCHUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NHACHUNGCUID)
				.HasColumnName("NHACHUNGCUID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENHANGMUC)
				.HasColumnName("TENHANGMUC")
				.IsUnicode(false)
				.HasMaxLength(50);
            this.Property(t => t.DIENTICH)
                .HasColumnName("DIENTICH");
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
			
			this.HasRequired<DC_NHACHUNGCU>(t => t.DC_NHACHUNGCU)
				.WithMany(m => m.DC_HANGMUCNGOAICANHO)
				.HasForeignKey(m => m.NHACHUNGCUID);  

			this.ToTable("DC_HANGMUCNGOAICANHO"); 
		} 
	} 
}