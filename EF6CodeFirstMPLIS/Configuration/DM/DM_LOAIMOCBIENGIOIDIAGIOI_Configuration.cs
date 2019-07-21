namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DM_LOAIMOCBIENGIOIDIAGIOI_Configuration : EntityTypeConfiguration<DM_LOAIMOCBIENGIOIDIAGIOI> 
	{ 
		public DM_LOAIMOCBIENGIOIDIAGIOI_Configuration() 
		{ 
			this.HasKey(t => t.LOAIMOCBIENGIOIDIAGIOIID); 
			
			this.Property(t => t.LOAIMOCBIENGIOIDIAGIOIID)
				.HasColumnName("LOAIMOCBIENGIOIDIAGIOIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MALOAIMOCBIENGIOIDIAGIOI)
				.HasColumnName("MALOAIMOCBIENGIOIDIAGIOI")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENLOAIMOCBIENGIOIDIAGIOI)
				.HasColumnName("TENLOAIMOCBIENGIOIDIAGIOI")
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

			this.ToTable("DM_LOAIMOCBIENGIOIDIAGIOI"); 
		} 
	} 
}