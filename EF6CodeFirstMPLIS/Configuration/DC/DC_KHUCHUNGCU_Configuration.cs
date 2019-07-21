namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_KHUCHUNGCU_Configuration : EntityTypeConfiguration<DC_KHUCHUNGCU> 
	{ 
		public DC_KHUCHUNGCU_Configuration() 
		{ 
			this.HasKey(t => t.KHUCHUNGCUID); 
			
			this.Property(t => t.KHUCHUNGCUID)
				.HasColumnName("KHUCHUNGCUID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MAXA)
				.HasColumnName("MAXA")
				.IsUnicode(false)
				.HasMaxLength(5);
			this.Property(t => t.TENKHU)
				.HasColumnName("TENKHU")
				.IsUnicode(false)
				.HasMaxLength(100);
            this.Property(t => t.DIENTICHKHU)
                .HasColumnName("DIENTICHKHU");
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
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(200); 

			this.ToTable("DC_KHUCHUNGCU"); 
		} 
	} 
}