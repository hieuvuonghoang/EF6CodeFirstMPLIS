namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_XA_TENDUONG_Configuration : EntityTypeConfiguration<DC_XA_TENDUONG> 
	{ 
		public DC_XA_TENDUONG_Configuration() 
		{ 
			this.HasKey(t => t.XATENDUONGID);

            this.Property(t => t.XATENDUONGID)
                .HasColumnName("XATENDUONGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TENDUONGID)
				.HasColumnName("TENDUONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
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

			this.ToTable("DC_XA_TENDUONG"); 
		} 
	} 
}