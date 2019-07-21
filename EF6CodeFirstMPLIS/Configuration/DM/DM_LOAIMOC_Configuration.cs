namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIMOC_Configuration : EntityTypeConfiguration<DM_LOAIMOC> 
	{ 
		public DM_LOAIMOC_Configuration() 
		{ 
			this.HasKey(t => t.LOAIMOCID); 
			
			this.Property(t => t.LOAIMOCID)
				.HasColumnName("LOAIMOCID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIMOC)
				.HasColumnName("MALOAIMOC")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIMOC)
				.HasColumnName("TENLOAIMOC")
				.IsUnicode(false)
				.HasMaxLength(60);
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

			this.ToTable("DM_LOAIMOC"); 
		} 
	} 
}