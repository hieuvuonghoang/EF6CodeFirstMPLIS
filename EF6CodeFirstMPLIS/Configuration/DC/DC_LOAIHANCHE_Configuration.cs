namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_LOAIHANCHE_Configuration : EntityTypeConfiguration<DC_LOAIHANCHE> 
	{ 
		public DC_LOAIHANCHE_Configuration() 
		{ 
			this.HasKey(t => t.LOAIHANCHEID); 
			
			this.Property(t => t.LOAIHANCHEID)
				.HasColumnName("LOAIHANCHEID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENLOAIHANCHE)
				.HasColumnName("TENLOAIHANCHE")
				.IsUnicode(false)
				.HasMaxLength(500);
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT"); 

			this.ToTable("DC_LOAIHANCHE"); 
		} 
	} 
}