namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_CANHO_Configuration : EntityTypeConfiguration<DC_CANHO> 
	{ 
		public DC_CANHO_Configuration() 
		{ 
			this.HasKey(t => t.CANHOID); 
			
			this.Property(t => t.CANHOID)
				.HasColumnName("CANHOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NHACHUNGCUID)
				.HasColumnName("NHACHUNGCUID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOHIEUCANHO)
				.HasColumnName("SOHIEUCANHO")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.TANGSO)
				.HasColumnName("TANGSO");
            this.Property(t => t.DIENTICHSAN)
                .HasColumnName("DIENTICHSAN");
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
			this.Property(t => t.HINHTHUCSOHUU)
				.HasColumnName("HINHTHUCSOHUU")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.THOIHANSOHUU)
				.HasColumnName("THOIHANSOHUU")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.TINHTRANGDANGKY)
				.HasColumnName("TINHTRANGDANGKY")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.DTSH_CHUNG_CDT)
                .HasColumnName("DTSH_CHUNG_CDT");
            this.Property(t => t.DTSH_CHUNG_NSDD)
                .HasColumnName("DTSH_CHUNG_NSDD");
            this.Property(t => t.DTSH_RIENG)
                .HasColumnName("DTSH_RIENG");
			this.Property(t => t.NGUONGOC)
				.HasColumnName("NGUONGOC")
				.IsUnicode(false)
				.HasMaxLength(10);
			this.Property(t => t.NAMHOANCONG)
				.HasColumnName("NAMHOANCONG");
			this.Property(t => t.CO_HSXN_NHADUYNHAT)
				.HasColumnName("CO_HSXN_NHADUYNHAT")
				.IsUnicode(false)
				.HasMaxLength(1);
            this.Property(t => t.DT_PT_RIENGLE)
                .HasColumnName("DT_PT_RIENGLE");
            this.Property(t => t.DT_PT_KHONGRIENGLE)
                .HasColumnName("DT_PT_KHONGRIENGLE");
            this.Property(t => t.DT_HT_NVTC)
                .HasColumnName("DT_HT_NVTC");
			
			this.HasRequired<DC_NHACHUNGCU>(t => t.DC_NHACHUNGCU)
				.WithMany(m => m.DC_CANHO)
				.HasForeignKey(m => m.NHACHUNGCUID);

			this.ToTable("DC_CANHO"); 
		} 
	} 
}