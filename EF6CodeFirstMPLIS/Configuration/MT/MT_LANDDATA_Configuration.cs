namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class MT_LANDDATA_Configuration : EntityTypeConfiguration<MT_LANDDATA> 
	{ 
		public MT_LANDDATA_Configuration() 
		{ 
			this.HasKey(t => t.LANDDATAID); 
			
			this.Property(t => t.LANDDATAID)
				.HasColumnName("LANDDATAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TRICHYEU)
				.HasColumnName("TRICHYEU")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.NGAYNGHIEMTHU)
				.HasColumnName("NGAYNGHIEMTHU");
			this.Property(t => t.TOMTAT)
				.HasColumnName("TOMTAT")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.MUCDICH)
				.HasColumnName("MUCDICH")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.KIEUDULIEUKHONGGIAN)
				.HasColumnName("KIEUDULIEUKHONGGIAN")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.HIENTRANG)
				.HasColumnName("HIENTRANG")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.NGONNGU)
				.HasColumnName("NGONNGU")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.BANGMA)
				.HasColumnName("BANGMA")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.CHUDE)
				.HasColumnName("CHUDE")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.TENTUKHOA)
				.HasColumnName("TENTUKHOA")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.LOAITUKHOA)
				.HasColumnName("LOAITUKHOA")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.TENTEPANH)
				.HasColumnName("TENTEPANH")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.MOTATEPANH)
				.HasColumnName("MOTATEPANH")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.DINHDANGANH)
				.HasColumnName("DINHDANGANH")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.TYLEANH)
				.HasColumnName("TYLEANH")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.MOTA)
				.HasColumnName("MOTA")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.FILEIDENTIFIER)
				.HasColumnName("FILEIDENTIFIER")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.UID)
				.HasColumnName("UID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT"); 

			this.ToTable("MT_LANDDATA"); 
		} 
	} 
}