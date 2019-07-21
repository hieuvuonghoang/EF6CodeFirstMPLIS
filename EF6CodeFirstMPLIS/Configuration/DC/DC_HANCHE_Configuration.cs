namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_HANCHE_Configuration : EntityTypeConfiguration<DC_HANCHE> 
	{ 
		public DC_HANCHE_Configuration() 
		{ 
			this.HasKey(t => t.HANCHEID); 
			
			this.Property(t => t.HANCHEID)
				.HasColumnName("HANCHEID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAIHANCHEID)
				.HasColumnName("LOAIHANCHEID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.DIENTICH)
                .HasColumnName("DIENTICH");
			this.Property(t => t.NOIDUNGHANCHE)
				.HasColumnName("NOIDUNGHANCHE")
				.IsUnicode(false)
				.HasMaxLength(150);
			this.Property(t => t.HANCHEMOTPHAN)
				.HasColumnName("HANCHEMOTPHAN")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.SOVANBAN)
				.HasColumnName("SOVANBAN")
				.IsUnicode(false)
				.HasMaxLength(15);
			this.Property(t => t.NGAYBANHANH)
				.HasColumnName("NGAYBANHANH");
			this.Property(t => t.COQUANBANHANH)
				.HasColumnName("COQUANBANHANH")
				.IsUnicode(false)
				.HasMaxLength(150);
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
			this.Property(t => t.DUONGDANFILEVANBAN)
				.HasColumnName("DUONGDANFILEVANBAN")
				.IsUnicode(false)
				.HasMaxLength(500);
			this.Property(t => t.GIAYCHUNGNHANID)
				.HasColumnName("GIAYCHUNGNHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUADATID)
				.HasColumnName("THUADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAIHANCHE)
				.HasColumnName("LOAIHANCHE");
			this.Property(t => t.SODORANHGIOIHANCHE)
				.HasColumnName("SODORANHGIOIHANCHE")
				.IsUnicode(false)
				.HasMaxLength(500);
			this.Property(t => t.CONHIEULUC)
				.HasColumnName("CONHIEULUC")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.NGAYHETHIEULUC)
				.HasColumnName("NGAYHETHIEULUC"); 
			
			this.HasRequired<DC_LOAIHANCHE>(t => t.DC_LOAIHANCHE)
				.WithMany(m => m.DC_HANCHE)
				.HasForeignKey(m => m.LOAIHANCHEID);  

			this.ToTable("DC_HANCHE"); 
		} 
	} 
}