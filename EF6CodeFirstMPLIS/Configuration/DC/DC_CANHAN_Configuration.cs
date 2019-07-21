namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_CANHAN_Configuration : EntityTypeConfiguration<DC_CANHAN> 
	{ 
		public DC_CANHAN_Configuration() 
		{ 
			this.HasKey(t => t.CANHANID); 
			
			this.Property(t => t.CANHANID)
				.HasColumnName("CANHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HOTEN)
				.HasColumnName("HOTEN")
				.IsUnicode(false)
				.HasMaxLength(150);
			this.Property(t => t.HODEM)
				.HasColumnName("HODEM")
				.IsUnicode(false)
				.HasMaxLength(90);
			this.Property(t => t.TEN)
				.HasColumnName("TEN")
				.IsUnicode(false)
				.HasMaxLength(60);
			this.Property(t => t.NGAYSINH)
				.HasColumnName("NGAYSINH");
			this.Property(t => t.NAMSINH)
				.HasColumnName("NAMSINH");
			this.Property(t => t.GIOITINH)
				.HasColumnName("GIOITINH");
            this.Property(t => t.CONSONG)
                .HasColumnName("CONSONG");
			this.Property(t => t.SOGIAYTO)
				.HasColumnName("SOGIAYTO")
				.IsUnicode(false)
				.HasMaxLength(30);
			this.Property(t => t.NGAYCAP)
				.HasColumnName("NGAYCAP");
			this.Property(t => t.NOICAP)
				.HasColumnName("NOICAP")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.QUOCTICHID)
				.HasColumnName("QUOCTICHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.QUOCTICHKHACIDS)
				.HasColumnName("QUOCTICHKHACIDS")
				.IsUnicode(false)
				.HasMaxLength(1000);
			this.Property(t => t.DANTOCID)
				.HasColumnName("DANTOCID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.UID)
				.HasColumnName("UID")
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
			this.Property(t => t.GIAYTOTUYTHANID)
				.HasColumnName("GIAYTOTUYTHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SODIENTHOAI)
				.HasColumnName("SODIENTHOAI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.EMAIL)
				.HasColumnName("EMAIL")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.MASOTHUE)
				.HasColumnName("MASOTHUE")
				.IsUnicode(false)
				.HasMaxLength(50); 
			
			this.HasRequired<DM_DANTOC>(t => t.DM_DANTOC)
				.WithMany(m => m.DC_CANHAN)
				.HasForeignKey(m => m.DANTOCID);
            this.HasRequired<DM_QUOCTICH>(t => t.DM_QUOCTICH)
                .WithMany(m => m.DC_CANHAN)
                .HasForeignKey(m => m.QUOCTICHID);

            this.ToTable("DC_CANHAN"); 
		} 
	} 
}