namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_GIAYTOTUYTHAN_Configuration : EntityTypeConfiguration<DC_GIAYTOTUYTHAN> 
	{ 
		public DC_GIAYTOTUYTHAN_Configuration() 
		{ 
			this.HasKey(t => t.GIAYTOTUYTHANID); 
			
			this.Property(t => t.GIAYTOTUYTHANID)
				.HasColumnName("GIAYTOTUYTHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAIGIAYTOTUYTHANID)
				.HasColumnName("LOAIGIAYTOTUYTHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.CANHANID)
				.HasColumnName("CANHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOGIAYTO)
				.HasColumnName("SOGIAYTO")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.NGAYCAP)
				.HasColumnName("NGAYCAP");
			this.Property(t => t.NOICAP)
				.HasColumnName("NOICAP")
				.IsUnicode(false)
				.HasMaxLength(200);
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
            this.Property(t => t.LAGIAYTOINGCN)
                .HasColumnName("LAGIAYTOINGCN");

			this.ToTable("DC_GIAYTOTUYTHAN"); 
		} 
	} 
}