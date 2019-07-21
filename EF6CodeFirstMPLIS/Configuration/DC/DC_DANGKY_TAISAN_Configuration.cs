namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_DANGKY_TAISAN_Configuration : EntityTypeConfiguration<DC_DANGKY_TAISAN> 
	{ 
		public DC_DANGKY_TAISAN_Configuration() 
		{ 
			this.HasKey(t => t.DANGKYTAISANID);

            this.Property(t => t.DANGKYTAISANID)
                .HasColumnName("DANGKYTAISANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.DONDANGKYID)
				.HasColumnName("DONDANGKYID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TAISANID)
				.HasColumnName("TAISANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MOTATOMTAT)
				.HasColumnName("MOTATOMTAT")
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

			this.ToTable("DC_DANGKY_TAISAN"); 
		} 
	} 
}