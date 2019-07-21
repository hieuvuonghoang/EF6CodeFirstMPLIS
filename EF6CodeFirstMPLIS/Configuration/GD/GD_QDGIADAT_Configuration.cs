namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class GD_QDGIADAT_Configuration : EntityTypeConfiguration<GD_QDGIADAT> 
	{ 
		public GD_QDGIADAT_Configuration() 
		{ 
			this.HasKey(t => t.QDGIADATID); 
			
			this.Property(t => t.QDGIADATID)
				.HasColumnName("QDGIADATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOQUYETDINH)
				.HasColumnName("SOQUYETDINH")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.FILEQUYETDINH)
				.HasColumnName("FILEQUYETDINH")
				.IsUnicode(false)
				.HasMaxLength(200);
			this.Property(t => t.NGAYBANHANH)
				.HasColumnName("NGAYBANHANH");
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

			this.ToTable("GD_QDGIADAT"); 
		} 
	} 
}