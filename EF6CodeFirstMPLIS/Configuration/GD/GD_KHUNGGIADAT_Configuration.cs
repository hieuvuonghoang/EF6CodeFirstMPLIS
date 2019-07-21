namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class GD_KHUNGGIADAT_Configuration : EntityTypeConfiguration<GD_KHUNGGIADAT> 
	{ 
		public GD_KHUNGGIADAT_Configuration() 
		{ 
			this.HasKey(t => t.KHUNGGIADATID); 
			
			this.Property(t => t.KHUNGGIADATID)
				.HasColumnName("KHUNGGIADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOQUYETDINH)
				.HasColumnName("SOQUYETDINH")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.NGAYBANHANH)
				.HasColumnName("NGAYBANHANH");
			this.Property(t => t.FILEDINHKEM)
				.HasColumnName("FILEDINHKEM")
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
            this.Property(t => t.MUCGIATOITHIEU)
                .HasColumnName("MUCGIATOITHIEU");
            this.Property(t => t.MUCGIATOIDA)
                .HasColumnName("MUCGIATOIDA");

			this.ToTable("GD_KHUNGGIADAT"); 
		} 
	} 
}