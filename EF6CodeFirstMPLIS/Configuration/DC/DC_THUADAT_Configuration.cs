namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_THUADAT_Configuration : EntityTypeConfiguration<DC_THUADAT> 
	{ 
		public DC_THUADAT_Configuration() 
		{ 
			this.HasKey(t => t.THUADATID); 
			
			this.Property(t => t.THUADATID)
				.HasColumnName("THUADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.KVHCID)
                .HasColumnName("KVHCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.SOHIEUTOBANDO)
				.HasColumnName("SOHIEUTOBANDO");
			this.Property(t => t.SOTHUTUTHUA)
				.HasColumnName("SOTHUTUTHUA");
			this.Property(t => t.SOHIEUTOBANDOCU)
				.HasColumnName("SOHIEUTOBANDOCU")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.SOTHUTUTHUACU)
				.HasColumnName("SOTHUTUTHUACU")
				.IsUnicode(false)
				.HasMaxLength(100);
            this.Property(t => t.DIENTICH)
                .HasColumnName("DIENTICH");
            this.Property(t => t.DIENTICHPHAPLY)
                .HasColumnName("DIENTICHPHAPLY");
			this.Property(t => t.TAILIEUDODACID)
				.HasColumnName("TAILIEUDODACID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LADOITUONGCHIEMDAT)
				.HasColumnName("LADOITUONGCHIEMDAT");
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
			this.Property(t => t.DIACHITHUADAT)
				.HasColumnName("DIACHITHUADAT")
				.IsUnicode(false)
				.HasMaxLength(250);
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DANGTRANHCHAP)
				.HasColumnName("DANGTRANHCHAP")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.GEOMETRY)
				.HasColumnName("GEOMETRY");
			this.Property(t => t.TRANGTHAI)
				.HasColumnName("TRANGTHAI")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.THUAGOCID)
				.HasColumnName("THUAGOCID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAITHUADAT)
				.HasColumnName("LOAITHUADAT")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.HSKTFILEPATH)
				.HasColumnName("HSKTFILEPATH")
				.IsUnicode(false)
				.HasMaxLength(500);
			this.Property(t => t.GTQUYENSDD)
				.HasColumnName("GTQUYENSDD")
				.IsUnicode(false)
				.HasMaxLength(2000);
			this.Property(t => t.DOANDUONGID)
				.HasColumnName("DOANDUONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.KHUVUCID)
				.HasColumnName("KHUVUCID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<DC_DOANDUONG>(t => t.DC_DOANDUONG)
				.WithMany(m => m.DC_THUADAT)
				.HasForeignKey(m => m.DOANDUONGID);
            this.HasRequired<DC_KHUVUC>(t => t.DC_KHUVUC)
                .WithMany(m => m.DC_THUADAT)
                .HasForeignKey(m => m.KHUVUCID);
            this.HasRequired<DC_TAILIEUDODAC>(t => t.DC_TAILIEUDODAC)
				.WithMany(m => m.DC_THUADAT)
				.HasForeignKey(m => m.TAILIEUDODACID);
            this.HasRequired<HC_DMKVHC>(t => t.HC_DMKVHC)
                .WithMany(m => m.DC_THUADAT)
                .HasForeignKey(m => m.KVHCID);

            this.ToTable("DC_THUADAT"); 
		} 
	} 
}