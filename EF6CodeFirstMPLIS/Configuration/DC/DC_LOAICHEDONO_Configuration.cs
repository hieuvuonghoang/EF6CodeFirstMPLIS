namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_LOAICHEDONO_Configuration : EntityTypeConfiguration<DC_LOAICHEDONO> 
	{ 
		public DC_LOAICHEDONO_Configuration() 
		{ 
			this.HasKey(t => t.LOAICHEDONOID); 
			
			this.Property(t => t.LOAICHEDONOID)
				.HasColumnName("LOAICHEDONOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENLOAICHEDONO)
				.HasColumnName("TENLOAICHEDONO")
				.IsUnicode(false)
				.HasMaxLength(200);
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

			this.ToTable("DC_LOAICHEDONO"); 
		} 
	} 
}