namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_MUCDICHSUDUNGDAT_Configuration : EntityTypeConfiguration<DC_MUCDICHSUDUNGDAT> 
	{ 
		public DC_MUCDICHSUDUNGDAT_Configuration() 
		{ 
			this.HasKey(t => t.MUCDICHSUDUNGDATID);

            this.Property(t => t.MUCDICHSUDUNGDATID)
                .HasColumnName("MUCDICHSUDUNGDATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THUADATID)
                .HasColumnName("THUADATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.SOTHUTUMDSD)
                .HasColumnName("SOTHUTUMDSD");
            this.Property(t => t.MUCDICHSUDUNGID)
                .HasColumnName("MUCDICHSUDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.MUCDICHSUDUNGQHID)
                .HasColumnName("MUCDICHSUDUNGQHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.DIENTICH)
                .HasColumnName("DIENTICH");
            this.Property(t => t.SUDUNGCHUNG)
                .HasColumnName("SUDUNGCHUNG");
            this.Property(t => t.THOIHANSUDUNG)
                .HasColumnName("THOIHANSUDUNG")
                .IsUnicode(false)
                .HasMaxLength(250);
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
            this.Property(t => t.LAMUCDICHCHINH)
                .HasColumnName("LAMUCDICHCHINH");
            this.Property(t => t.MDSDGOCID)
                .HasColumnName("MDSDGOCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.DACAPQUYEN)
                .HasColumnName("DACAPQUYEN")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.LOAITHOIHANSUDUNG)
                .HasColumnName("LOAITHOIHANSUDUNG")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.TUNGAY)
                .HasColumnName("TUNGAY");
            this.Property(t => t.DENNGAY)
                .HasColumnName("DENNGAY");
            this.Property(t => t.DIENTICHPHAINOPTIEN)
                .HasColumnName("DIENTICHPHAINOPTIEN");
            this.Property(t => t.DIENTICHKHONGPHAINOPTIEN)
                .HasColumnName("DIENTICHKHONGPHAINOPTIEN");
            this.Property(t => t.SOLANCAPQUYEN)
                .HasColumnName("SOLANCAPQUYEN");
            this.Property(t => t.NGUONGOCSDTH)
                .HasColumnName("NGUONGOCSDTH")
                .IsUnicode(false)
                .HasMaxLength(4000);
            this.Property(t => t.HINHTHUCSUDUNGID)
                .HasColumnName("HINHTHUCSUDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<DM_MUCDICHSUDUNGQH>(t => t.DM_MUCDICHSUDUNGQH)
				.WithMany(m => m.DC_MUCDICHSUDUNGDAT)
				.HasForeignKey(m => m.MUCDICHSUDUNGQHID);
            this.HasRequired<DM_MUCDICHSUDUNG>(t => t.DM_MUCDICHSUDUNG)
                .WithMany(m => m.DC_MUCDICHSUDUNGDAT)
                .HasForeignKey(m => m.MUCDICHSUDUNGID);
            this.HasRequired<DM_HINHTHUCSUDUNGDAT>(t => t.DM_HINHTHUCSUDUNGDAT)
                .WithMany(m => m.DC_MUCDICHSUDUNGDAT)
                .HasForeignKey(m => m.HINHTHUCSUDUNGID);

            this.ToTable("DC_MUCDICHSUDUNGDAT"); 
		} 
	} 
}