namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class GD_GIATHUADAT_Configuration : EntityTypeConfiguration<GD_GIATHUADAT> 
	{ 
		public GD_GIATHUADAT_Configuration() 
		{ 
			this.HasKey(t => t.GIATHUADATID);

            this.Property(t => t.GIATHUADATID)
                .HasColumnName("GIATHUADATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LOAIGIADATID)
				.HasColumnName("LOAIGIADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUADATID)
				.HasColumnName("THUADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.GIADAT)
                .HasColumnName("GIADAT");
			this.Property(t => t.THOIDIEMXACDINH)
				.HasColumnName("THOIDIEMXACDINH");
			this.Property(t => t.CANCUPHAPLY)
				.HasColumnName("CANCUPHAPLY")
				.IsUnicode(false)
				.HasMaxLength(2000);
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENFILE)
				.HasColumnName("TENFILE")
				.IsUnicode(false)
				.HasMaxLength(100);
            this.Property(t => t.GIADATTHEOHSDC)
                .HasColumnName("GIADATTHEOHSDC");
			
			this.HasRequired<DC_THUADAT>(t => t.DC_THUADAT)
				.WithMany(m => m.GD_GIATHUADAT)
				.HasForeignKey(m => m.THUADATID);
            this.HasRequired<GD_DMLOAIGIADAT>(t => t.GD_DMLOAIGIADAT)
                .WithMany(m => m.GD_GIATHUADAT)
                .HasForeignKey(m => m.LOAIGIADATID);

            this.ToTable("GD_GIATHUADAT"); 
		} 
	} 
}