namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_THONGTINNGANCHAN_Configuration : EntityTypeConfiguration<DC_THONGTINNGANCHAN> 
	{ 
		public DC_THONGTINNGANCHAN_Configuration() 
		{ 
			this.HasKey(t => t.THONGTINNGANCHANID); 
			
			this.Property(t => t.THONGTINNGANCHANID)
				.HasColumnName("THONGTINNGANCHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MUCDONGANCHAN)
				.HasColumnName("MUCDONGANCHAN");
			this.Property(t => t.SOHIEUCONGVAN)
				.HasColumnName("SOHIEUCONGVAN")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.THOIDIEMBATDAU)
				.HasColumnName("THOIDIEMBATDAU");
			this.Property(t => t.THOIDIEMKETTHUC)
				.HasColumnName("THOIDIEMKETTHUC");
			this.Property(t => t.NOIDUNGNGANCHAN)
				.HasColumnName("NOIDUNGNGANCHAN")
				.IsUnicode(false)
				.HasMaxLength(256);
			this.Property(t => t.LYDONGANCHAN)
				.HasColumnName("LYDONGANCHAN")
				.IsUnicode(false)
				.HasMaxLength(256);
			this.Property(t => t.FILENGANCHAN)
				.HasColumnName("FILENGANCHAN");
			this.Property(t => t.LOAIDOITUONGNGANCHAN)
				.HasColumnName("LOAIDOITUONGNGANCHAN")
				.IsUnicode(false)
				.HasMaxLength(60);
			this.Property(t => t.HIEULUC)
				.HasColumnName("HIEULUC")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.THONGTINFILENGANCHAN)
				.HasColumnName("THONGTINFILENGANCHAN")
				.IsUnicode(false)
				.HasMaxLength(256);
			this.Property(t => t.CHANCAPGIAY)
				.HasColumnName("CHANCAPGIAY")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.CHANGIAODICH)
				.HasColumnName("CHANGIAODICH")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.CHANBIENDONG)
				.HasColumnName("CHANBIENDONG")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.BIENDONGID)
				.HasColumnName("BIENDONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DVHCID)
				.HasColumnName("DVHCID")
				.IsUnicode(false)
				.HasMaxLength(10);
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");

			this.ToTable("DC_THONGTINNGANCHAN"); 
		} 
	} 
}