namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_TOCHUC_Configuration : EntityTypeConfiguration<DC_TOCHUC> 
	{ 
		public DC_TOCHUC_Configuration() 
		{ 
			this.HasKey(t => t.TOCHUCID); 
			
			this.Property(t => t.TOCHUCID)
				.HasColumnName("TOCHUCID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENTOCHUC)
				.HasColumnName("TENTOCHUC")
				.IsUnicode(false)
				.HasMaxLength(500);
			this.Property(t => t.TENVIETTAT)
				.HasColumnName("TENVIETTAT")
				.IsUnicode(false)
				.HasMaxLength(30);
			this.Property(t => t.TENTOCHUCTA)
				.HasColumnName("TENTOCHUCTA")
				.IsUnicode(false)
				.HasMaxLength(120);
			this.Property(t => t.NGUOIDAIDIENID)
				.HasColumnName("NGUOIDAIDIENID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOQUYETDINH)
				.HasColumnName("SOQUYETDINH")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.NGAYQUYETDINH)
				.HasColumnName("NGAYQUYETDINH");
			this.Property(t => t.LOAIQUYETDINHTHANHLAP)
				.HasColumnName("LOAIQUYETDINHTHANHLAP")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.MADOANHNGHIEP)
				.HasColumnName("MADOANHNGHIEP")
				.IsUnicode(false)
				.HasMaxLength(30);
			this.Property(t => t.MASOTHUE)
				.HasColumnName("MASOTHUE")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.LOAITOCHUC)
				.HasColumnName("LOAITOCHUC")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
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
			this.Property(t => t.CMTNGUOIDAIDIEN)
				.HasColumnName("CMTNGUOIDAIDIEN")
				.IsUnicode(false)
				.HasMaxLength(30);

			this.ToTable("DC_TOCHUC"); 
		} 
	} 
}