namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIVUNGTHUYHE_Configuration : EntityTypeConfiguration<DM_LOAIVUNGTHUYHE> 
	{ 
		public DM_LOAIVUNGTHUYHE_Configuration() 
		{ 
			this.HasKey(t => t.LOAIVUNGTHUYHEID); 
			
			this.Property(t => t.LOAIVUNGTHUYHEID)
				.HasColumnName("LOAIVUNGTHUYHEID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIVUNGTHUYHE)
				.HasColumnName("MALOAIVUNGTHUYHE")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIVUNGTHUYHE)
				.HasColumnName("TENLOAIVUNGTHUYHE")
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

			this.ToTable("DM_LOAIVUNGTHUYHE"); 
		} 
	} 
}