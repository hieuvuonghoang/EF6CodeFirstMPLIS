namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HS_HOSO_Configuration : EntityTypeConfiguration<HS_HOSO> 
	{ 
		public HS_HOSO_Configuration() 
		{ 
			this.HasKey(t => t.HOSOID); 
			
			this.Property(t => t.HOSOID)
				.HasColumnName("HOSOID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.KVHCID)
                .HasColumnName("KVHCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MAHOSO)
				.HasColumnName("MAHOSO")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.MAHOSO_ST)
				.HasColumnName("MAHOSO_ST")
				.IsUnicode(false)
				.HasMaxLength(6);
			this.Property(t => t.MAHOSO_MB)
				.HasColumnName("MAHOSO_MB")
				.IsUnicode(false)
				.HasMaxLength(2);
			this.Property(t => t.MAHOSO_TB)
				.HasColumnName("MAHOSO_TB")
				.IsUnicode(false)
				.HasMaxLength(3);
			this.Property(t => t.MAHOSO_TAM)
				.HasColumnName("MAHOSO_TAM")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.TENHOSO)
				.HasColumnName("TENHOSO")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.SOTODAIDIEN)
				.HasColumnName("SOTODAIDIEN")
				.IsUnicode(false)
				.HasMaxLength(15);
			this.Property(t => t.SOTHUADAIDIEN)
				.HasColumnName("SOTHUADAIDIEN")
				.IsUnicode(false)
				.HasMaxLength(15);
			this.Property(t => t.NGAYHOSO)
				.HasColumnName("NGAYHOSO");
			this.Property(t => t.PHONG)
				.HasColumnName("PHONG")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.KE)
				.HasColumnName("KE")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGAN)
				.HasColumnName("NGAN")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HOP)
				.HasColumnName("HOP")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENHOP)
				.HasColumnName("TENHOP")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(255);
            this.Property(t => t.DALIENKETCSDL_KG)
                .HasColumnName("DALIENKETCSDL_KG");
            this.Property(t => t.DALIENKETCSDL_TT)
                .HasColumnName("DALIENKETCSDL_TT");
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.OID)
				.HasColumnName("OID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HOSOTIEPNHANID)
				.HasColumnName("HOSOTIEPNHANID")
				.IsUnicode(false)
				.HasMaxLength(36);

            this.HasRequired<HC_DMKVHC>(t => t.HC_DMKVHC)
                .WithMany(m => m.HS_HOSO)
                .HasForeignKey(m => m.KVHCID);
            this.HasRequired<QT_HOSOTIEPNHAN>(t => t.QT_HOSOTIEPNHAN)
                .WithMany(m => m.HS_HOSO)
                .HasForeignKey(m => m.HOSOTIEPNHANID);

            this.ToTable("HS_HOSO"); 
		} 
	} 
}