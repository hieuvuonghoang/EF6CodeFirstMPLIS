namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_CANHO_HANGMUCNCH_Configuration : EntityTypeConfiguration<DC_CANHO_HANGMUCNCH> 
	{ 
		public DC_CANHO_HANGMUCNCH_Configuration() 
		{ 
			this.HasKey(t => t.CANHOHANGMUCNCHID);

            this.Property(t => t.CANHOHANGMUCNCHID)
                .HasColumnName("CANHOHANGMUCNCHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.HANGMUCSOHUUCHUNGID)
				.HasColumnName("HANGMUCSOHUUCHUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.CANHOID)
				.HasColumnName("CANHOID")
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
			
			this.HasRequired<DC_CANHO>(t => t.DC_CANHO)
				.WithMany(m => m.DC_CANHO_HANGMUCNCH)
				.HasForeignKey(m => m.CANHOID);
            this.HasRequired<DC_HANGMUCNGOAICANHO>(t => t.DC_HANGMUCNGOAICANHO)
                .WithMany(m => m.DC_CANHO_HANGMUCNCH)
                .HasForeignKey(m => m.HANGMUCSOHUUCHUNGID);

            this.ToTable("DC_CANHO_HANGMUCNCH"); 
		} 
	} 
}