namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class GD_HSDCGIADAT_Configuration : EntityTypeConfiguration<GD_HSDCGIADAT> 
	{ 
		public GD_HSDCGIADAT_Configuration() 
		{ 
			this.HasKey(t => t.HSDCGIADATID); 
			
			this.Property(t => t.HSDCGIADATID)
				.HasColumnName("HSDCGIADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOQUYETDINH)
				.HasColumnName("SOQUYETDINH")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.NGAYBANHANH)
				.HasColumnName("NGAYBANHANH");
            this.Property(t => t.HESODIEUCHINH)
                .HasColumnName("HESODIEUCHINH");
			this.Property(t => t.NGAYHIEULUC)
				.HasColumnName("NGAYHIEULUC");
			this.Property(t => t.FILEQUYETDINH)
				.HasColumnName("FILEQUYETDINH")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENFILE)
				.HasColumnName("TENFILE")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.NOIDUNGTOMTAT)
				.HasColumnName("NOIDUNGTOMTAT")
				.IsUnicode(false)
				.HasMaxLength(4000);

			this.ToTable("GD_HSDCGIADAT"); 
		} 
	} 
}