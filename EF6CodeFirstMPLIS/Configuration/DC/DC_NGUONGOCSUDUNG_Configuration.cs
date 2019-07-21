namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_NGUONGOCSUDUNG_Configuration : EntityTypeConfiguration<DC_NGUONGOCSUDUNG> 
	{ 
		public DC_NGUONGOCSUDUNG_Configuration() 
		{ 
			this.HasKey(t => t.NGUONGOCSUDUNGID);

            this.Property(t => t.NGUONGOCSUDUNGID)
                .HasColumnName("NGUONGOCSUDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MUCDICHSUDUNGDATID)
                .HasColumnName("MUCDICHSUDUNGDATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.CHITIET)
                .HasColumnName("CHITIET")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.LOAINGUONGOCSUDUNGID)
                .HasColumnName("LOAINGUONGOCSUDUNGID")
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
                .HasColumnName("THOIDIEMCAPNHAT")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<DC_MUCDICHSUDUNGDAT>(t => t.DC_MUCDICHSUDUNGDAT)
                .WithMany(m => m.DC_NGUONGOCSUDUNG)
                .HasForeignKey(m => m.MUCDICHSUDUNGDATID);
            this.HasRequired<DM_LOAINGUONGOCSUDUNG>(t => t.DM_LOAINGUONGOCSUDUNG)
                .WithMany(m => m.DC_NGUONGOCSUDUNG)
                .HasForeignKey(m => m.LOAINGUONGOCSUDUNGID);

            this.ToTable("DC_NGUONGOCSUDUNG"); 
		} 
	} 
}