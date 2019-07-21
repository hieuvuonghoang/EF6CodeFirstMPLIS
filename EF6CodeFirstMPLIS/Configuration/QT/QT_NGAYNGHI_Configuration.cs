namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QT_NGAYNGHI_Configuration : EntityTypeConfiguration<QT_NGAYNGHI> 
	{ 
		public QT_NGAYNGHI_Configuration() 
		{ 
			this.HasKey(t => t.NGAYNGHIID); 
			
			this.Property(t => t.NGAYNGHIID)
				.HasColumnName("NGAYNGHIID")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.TENNGAYNGHI)
				.HasColumnName("TENNGAYNGHI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.NGAYBATDAU)
				.HasColumnName("NGAYBATDAU");
			this.Property(t => t.NGAYKETTHUC)
				.HasColumnName("NGAYKETTHUC");
			this.Property(t => t.LOAINGAY)
				.HasColumnName("LOAINGAY")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");

			this.ToTable("QT_NGAYNGHI"); 
		} 
	} 
}