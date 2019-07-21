namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_NGANCHANTAISAN_Configuration : EntityTypeConfiguration<DC_NGANCHANTAISAN> 
	{ 
		public DC_NGANCHANTAISAN_Configuration() 
		{ 
			this.HasKey(t => t.NGANCHANTAISANID); 
			
			this.Property(t => t.NGANCHANTAISANID)
				.HasColumnName("NGANCHANTAISANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THONGTINNGANCHANID)
				.HasColumnName("THONGTINNGANCHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TAISANGANLIENVOIDATID)
				.HasColumnName("TAISANGANLIENVOIDATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAITAISAN)
				.HasColumnName("LOAITAISAN")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.TENTAISAN)
				.HasColumnName("TENTAISAN")
				.IsUnicode(false)
				.HasMaxLength(256);
			this.Property(t => t.DIACHICHITIET)
				.HasColumnName("DIACHICHITIET")
				.IsUnicode(false)
				.HasMaxLength(256);
			this.Property(t => t.SONHA)
				.HasColumnName("SONHA")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.PHO)
				.HasColumnName("PHO")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.KHUPHOXOM)
				.HasColumnName("KHUPHOXOM")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.DVHCID)
				.HasColumnName("DVHCID")
				.IsUnicode(false)
				.HasMaxLength(3610);
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(256);
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");

			this.ToTable("DC_NGANCHANTAISAN"); 
		} 
	} 
}