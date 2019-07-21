namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_NHOMNGUOI_THANHVIEN_Configuration : EntityTypeConfiguration<DC_NHOMNGUOI_THANHVIEN> 
	{ 
		public DC_NHOMNGUOI_THANHVIEN_Configuration() 
		{ 
			this.HasKey(t => t.NHOMNGUOITHANHVIENID);

            this.Property(t => t.NHOMNGUOITHANHVIENID)
                .HasColumnName("NHOMNGUOITHANHVIENID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NHOMNGUOIID)
				.HasColumnName("NHOMNGUOIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAIDOITUONG)
				.HasColumnName("LOAIDOITUONG")
				.IsUnicode(false)
				.HasMaxLength(1);
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
			this.Property(t => t.THANHPHANID)
				.HasColumnName("THANHPHANID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<DC_NHOMNGUOI>(t => t.DC_NHOMNGUOI)
				.WithMany(m => m.DC_NHOMNGUOI_THANHVIEN)
				.HasForeignKey(m => m.NHOMNGUOIID);  

			this.ToTable("DC_NHOMNGUOI_THANHVIEN"); 
		} 
	} 
}