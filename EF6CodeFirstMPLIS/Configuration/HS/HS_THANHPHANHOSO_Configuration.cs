namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HS_THANHPHANHOSO_Configuration : EntityTypeConfiguration<HS_THANHPHANHOSO> 
	{ 
		public HS_THANHPHANHOSO_Configuration() 
		{ 
			this.HasKey(t => t.THANHPHANHOSOID); 
			
			this.Property(t => t.THANHPHANHOSOID)
				.HasColumnName("THANHPHANHOSOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HOSOID)
				.HasColumnName("HOSOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.GIAYTOKEMTHEOHSID)
				.HasColumnName("GIAYTOKEMTHEOHSID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENTEPDULIEU)
				.HasColumnName("TENTEPDULIEU")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.KICHTHUOC)
				.HasColumnName("KICHTHUOC");
			this.Property(t => t.DUONGDAN)
				.HasColumnName("DUONGDAN")
				.IsUnicode(false)
				.HasMaxLength(2000);
			this.Property(t => t.UID)
				.HasColumnName("UID")
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
			this.Property(t => t.OID)
				.HasColumnName("OID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOBIENNHAN)
				.HasColumnName("SOBIENNHAN")
				.IsUnicode(false)
				.HasMaxLength(30); 
			
			this.HasRequired<HS_HOSO>(t => t.HS_HOSO)
				.WithMany(m => m.HS_THANHPHANHOSO)
				.HasForeignKey(m => m.HOSOID);  

			this.ToTable("HS_THANHPHANHOSO"); 
		} 
	} 
}