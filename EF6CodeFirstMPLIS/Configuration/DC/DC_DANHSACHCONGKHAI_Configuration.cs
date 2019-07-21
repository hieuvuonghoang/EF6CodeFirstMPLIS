namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_DANHSACHCONGKHAI_Configuration : EntityTypeConfiguration<DC_DANHSACHCONGKHAI> 
	{ 
		public DC_DANHSACHCONGKHAI_Configuration() 
		{ 
			this.HasKey(t => t.DANHSACHCONGKHAIID); 
			
			this.Property(t => t.DANHSACHCONGKHAIID)
				.HasColumnName("DANHSACHCONGKHAIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOVANBAN)
				.HasColumnName("SOVANBAN")
				.IsUnicode(false)
				.HasMaxLength(120);
			this.Property(t => t.NGAYBATDAU)
				.HasColumnName("NGAYBATDAU");
			this.Property(t => t.NGAYKETTHUC)
				.HasColumnName("NGAYKETTHUC");
			this.Property(t => t.DIADIEMCONGKHAI)
				.HasColumnName("DIADIEMCONGKHAI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.NGUOIDAIDIENXACNHAN)
				.HasColumnName("NGUOIDAIDIENXACNHAN")
				.IsUnicode(false)
				.HasMaxLength(255);
            this.Property(t => t.DAKETTHUC)
                .HasColumnName("DAKETTHUC");
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

			this.ToTable("DC_DANHSACHCONGKHAI"); 
		} 
	} 
}