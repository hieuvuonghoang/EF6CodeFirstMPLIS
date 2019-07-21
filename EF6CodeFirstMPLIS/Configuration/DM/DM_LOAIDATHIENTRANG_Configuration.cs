namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIDATHIENTRANG_Configuration : EntityTypeConfiguration<DM_LOAIDATHIENTRANG> 
	{ 
		public DM_LOAIDATHIENTRANG_Configuration() 
		{ 
			this.HasKey(t => t.LOAIDATHIENTRANGID); 
			
			this.Property(t => t.LOAIDATHIENTRANGID)
				.HasColumnName("LOAIDATHIENTRANGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.KHOACHAID)
				.HasColumnName("KHOACHAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIDATHIENTRANG)
				.HasColumnName("MALOAIDATHIENTRANG")
				.IsUnicode(false)
				.HasMaxLength(4);
            this.Property(t => t.TENLOAIDATHIENTRANG)
                .HasColumnName("TENLOAIDATHIENTRANG")
                .IsUnicode(false)
                .HasMaxLength(120);
            this.Property(t => t.THUTUSAPXEP)
                .HasColumnName("THUTUSAPXEP")
                .IsUnicode(false)
                .HasMaxLength(10);
            this.Property(t => t.CANCUPHAPLY)
                .HasColumnName("CANCUPHAPLY")
                .IsUnicode(false)
                .HasMaxLength(100);
            this.Property(t => t.PHIENBAN)
                .HasColumnName("PHIENBAN")
                .IsUnicode(false)
                .HasMaxLength(20);
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
            this.Property(t => t.CHITIET)
                .HasColumnName("CHITIET");

			this.ToTable("DM_LOAIDATHIENTRANG"); 
		} 
	} 
}