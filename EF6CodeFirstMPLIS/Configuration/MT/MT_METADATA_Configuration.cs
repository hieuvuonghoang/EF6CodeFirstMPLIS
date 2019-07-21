namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class MT_METADATA_Configuration : EntityTypeConfiguration<MT_METADATA> 
	{ 
		public MT_METADATA_Configuration() 
		{ 
			this.HasKey(t => t.METADATAID);

            this.Property(t => t.METADATAID)
                .HasColumnName("METADATAID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.FILEIDENTIFIER)
				.HasColumnName("FILEIDENTIFIER")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGONNGU)
				.HasColumnName("NGONNGU")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.BANGMAKYTU)
				.HasColumnName("BANGMAKYTU")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.PARENTIDENTIFIER)
				.HasColumnName("PARENTIDENTIFIER")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.PHAMVIMOTA)
				.HasColumnName("PHAMVIMOTA")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.NGAYLAP)
				.HasColumnName("NGAYLAP");
			this.Property(t => t.DONVILAP)
				.HasColumnName("DONVILAP")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENCHUAN)
				.HasColumnName("TENCHUAN")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.PHIENBAN)
				.HasColumnName("PHIENBAN")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");

			this.ToTable("MT_METADATA"); 
		} 
	} 
}