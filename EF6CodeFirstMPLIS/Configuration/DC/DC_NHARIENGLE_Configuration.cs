namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_NHARIENGLE_Configuration : EntityTypeConfiguration<DC_NHARIENGLE> 
	{ 
		public DC_NHARIENGLE_Configuration() 
		{ 
			this.HasKey(t => t.NHARIENGLEID); 
			
			this.Property(t => t.NHARIENGLEID)
				.HasColumnName("NHARIENGLEID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.DIENTICHXAYDUNG)
                .HasColumnName("DIENTICHXAYDUNG");
            this.Property(t => t.DIENTICHSAN)
                .HasColumnName("DIENTICHSAN");
			this.Property(t => t.SOTANG)
				.HasColumnName("SOTANG")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.SOTANGHAM)
				.HasColumnName("SOTANGHAM");
			this.Property(t => t.KETCAU)
				.HasColumnName("KETCAU")
				.IsUnicode(false)
				.HasMaxLength(150);
			this.Property(t => t.CAPHANG)
				.HasColumnName("CAPHANG")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(255);
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
			this.Property(t => t.LOAICAPHANGID)
				.HasColumnName("LOAICAPHANGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAINHAID)
				.HasColumnName("LOAINHAID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.DTSH_RIENG)
                .HasColumnName("DTSH_RIENG");
            this.Property(t => t.DT_SH_CHUNG)
                .HasColumnName("DT_SH_CHUNG");
			this.Property(t => t.NAMHOANCONG)
				.HasColumnName("NAMHOANCONG");
            this.Property(t => t.TLCL_CONLAI)
                .HasColumnName("TLCL_CONLAI");
			this.Property(t => t.CO_HSXN_NHADUYNHAT)
				.HasColumnName("CO_HSXN_NHADUYNHAT")
				.IsUnicode(false)
				.HasMaxLength(1);
            this.Property(t => t.DT_HT_NVTC)
                .HasColumnName("DT_HT_NVTC");
			
			this.HasRequired<DM_LOAICAPHANG>(t => t.DM_LOAICAPHANG)
				.WithMany(m => m.DC_NHARIENGLE)
				.HasForeignKey(m => m.LOAICAPHANGID);
            this.HasRequired<DM_LOAINHA>(t => t.DM_LOAINHA)
                .WithMany(m => m.DC_NHARIENGLE)
                .HasForeignKey(m => m.LOAINHAID);

            this.ToTable("DC_NHARIENGLE"); 
		} 
	} 
}