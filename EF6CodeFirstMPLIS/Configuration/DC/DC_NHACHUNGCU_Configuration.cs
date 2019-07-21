namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_NHACHUNGCU_Configuration : EntityTypeConfiguration<DC_NHACHUNGCU> 
	{ 
		public DC_NHACHUNGCU_Configuration() 
		{ 
			this.HasKey(t => t.NHACHUNGCUID); 
			
			this.Property(t => t.NHACHUNGCUID)
				.HasColumnName("NHACHUNGCUID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.KHUCHUNGCUID)
				.HasColumnName("KHUCHUNGCUID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENCHUNGCU)
				.HasColumnName("TENCHUNGCU")
				.IsUnicode(false)
				.HasMaxLength(100);
            this.Property(t => t.DIENTICHXAYDUNG)
                .HasColumnName("DIENTICHXAYDUNG");
            this.Property(t => t.DIENTICHSAN)
                .HasColumnName("DIENTICHSAN");
			this.Property(t => t.TONGSOCAN)
				.HasColumnName("TONGSOCAN");
			this.Property(t => t.SOTANG)
				.HasColumnName("SOTANG");
			this.Property(t => t.SOTANGHAM)
				.HasColumnName("SOTANGHAM");
			this.Property(t => t.NAMXAYDUNG)
				.HasColumnName("NAMXAYDUNG");
			this.Property(t => t.NAMHOANTHANH)
				.HasColumnName("NAMHOANTHANH");
			this.Property(t => t.THOIHANSOHUU)
				.HasColumnName("THOIHANSOHUU")
				.IsUnicode(false)
				.HasMaxLength(30);
			this.Property(t => t.CAPHANG)
				.HasColumnName("CAPHANG")
				.IsUnicode(false)
				.HasMaxLength(50);
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
			this.Property(t => t.MAXA)
				.HasColumnName("MAXA")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(200); 
			
			this.HasRequired<DC_KHUCHUNGCU>(t => t.DC_KHUCHUNGCU)
				.WithMany(m => m.DC_NHACHUNGCU)
				.HasForeignKey(m => m.KHUCHUNGCUID);  

			this.ToTable("DC_NHACHUNGCU"); 
		} 
	} 
}