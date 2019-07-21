namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_CHITIETCONGKHAI_Configuration : EntityTypeConfiguration<DC_CHITIETCONGKHAI> 
	{ 
		public DC_CHITIETCONGKHAI_Configuration() 
		{ 
			this.HasKey(t => t.CHITIETCONGKHAIID); 
			
			this.Property(t => t.CHITIETCONGKHAIID)
				.HasColumnName("CHITIETCONGKHAIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DANHSACHCONGKHAIID)
				.HasColumnName("DANHSACHCONGKHAIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUTUSAPXEP)
				.HasColumnName("THUTUSAPXEP");
			this.Property(t => t.NGUOIID)
				.HasColumnName("NGUOIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENCHUSUDUNG)
				.HasColumnName("TENCHUSUDUNG")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.THUADATID)
				.HasColumnName("THUADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOHIEUTOBANDO)
				.HasColumnName("SOHIEUTOBANDO");
			this.Property(t => t.SOTHUTUTHUA)
				.HasColumnName("SOTHUTUTHUA");
			this.Property(t => t.MUCDICHSUDUNGDATID)
				.HasColumnName("MUCDICHSUDUNGDATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MAMUCDICHSUDUNG)
				.HasColumnName("MAMUCDICHSUDUNG")
				.IsUnicode(false)
				.HasMaxLength(3);
            this.Property(t => t.DIENTICHMDSD)
                .HasColumnName("DIENTICHMDSD");
			this.Property(t => t.THOIDIEMSUDUNGDAT)
				.HasColumnName("THOIDIEMSUDUNGDAT")
				.IsUnicode(false)
				.HasMaxLength(150);
			this.Property(t => t.NGUONGOCSUDUNG)
				.HasColumnName("NGUONGOCSUDUNG")
				.IsUnicode(false)
				.HasMaxLength(500);
			this.Property(t => t.TAISANID)
				.HasColumnName("TAISANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TAISANGANLIENVOIDAT)
				.HasColumnName("TAISANGANLIENVOIDAT")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.TINHTRANGTRANHCHAP)
				.HasColumnName("TINHTRANGTRANHCHAP")
				.IsUnicode(false)
				.HasMaxLength(255);
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
			this.Property(t => t.DONDANGKYID)
				.HasColumnName("DONDANGKYID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<DC_DANHSACHCONGKHAI>(t => t.DC_DANHSACHCONGKHAI)
				.WithMany(m => m.DC_CHITIETCONGKHAI)
				.HasForeignKey(m => m.DANHSACHCONGKHAIID);  

			this.ToTable("DC_CHITIETCONGKHAI"); 
		} 
	} 
}