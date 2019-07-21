namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QT_HOSOTIEPNHAN_Configuration : EntityTypeConfiguration<QT_HOSOTIEPNHAN> 
	{ 
		public QT_HOSOTIEPNHAN_Configuration() 
		{ 
			this.HasKey(t => t.HOSOTIEPNHANID); 
			
			this.Property(t => t.HOSOTIEPNHANID)
				.HasColumnName("HOSOTIEPNHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.TOCHUCID)
                .HasColumnName("TOCHUCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THUTUCHANHCHINHID)
				.HasColumnName("THUTUCHANHCHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.CAP)
                .HasColumnName("CAP");
			this.Property(t => t.DONVIHANHCHINHID)
				.HasColumnName("DONVIHANHCHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.SOBIENNHAN)
				.HasColumnName("SOBIENNHAN")
				.IsUnicode(false)
				.HasMaxLength(30);
			this.Property(t => t.QUYENTIEPNHAN)
				.HasColumnName("QUYENTIEPNHAN")
				.IsUnicode(false)
				.HasMaxLength(150);
			this.Property(t => t.CANBOTIEPNHANID)
				.HasColumnName("CANBOTIEPNHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGAYTIEPNHANHOSO)
				.HasColumnName("NGAYTIEPNHANHOSO");
			this.Property(t => t.NGAYHENTRAHOSO)
				.HasColumnName("NGAYHENTRAHOSO");
			this.Property(t => t.NGUOINOPHOSO)
				.HasColumnName("NGUOINOPHOSO")
				.IsUnicode(false)
				.HasMaxLength(150);
            this.Property(t => t.VAITRONGUOINOPHOSO)
                .HasColumnName("VAITRONGUOINOPHOSO");
			this.Property(t => t.MOTATOMTAT)
				.HasColumnName("MOTATOMTAT")
				.IsUnicode(false)
				.HasMaxLength(150);
			this.Property(t => t.SODIENTHOAI)
				.HasColumnName("SODIENTHOAI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.EMAIL)
				.HasColumnName("EMAIL")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.SOGIAYTO)
				.HasColumnName("SOGIAYTO")
				.IsUnicode(false)
				.HasMaxLength(30);
            this.Property(t => t.PHUONGPHAPNHANTHONGBAO)
                .HasColumnName("PHUONGPHAPNHANTHONGBAO");
			this.Property(t => t.DIACHINGUOINOPHS)
				.HasColumnName("DIACHINGUOINOPHS")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.TENNGUOINHANKETQUA)
				.HasColumnName("TENNGUOINHANKETQUA")
				.IsUnicode(false)
				.HasMaxLength(150);
            this.Property(t => t.VAITRONGUOINHANKETQUA)
                .HasColumnName("VAITRONGUOINHANKETQUA");
			this.Property(t => t.DIACHINGUOINHANKETQUA)
				.HasColumnName("DIACHINGUOINHANKETQUA")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.NGAYTRAKETQUA)
				.HasColumnName("NGAYTRAKETQUA");
			this.Property(t => t.GHICHUTRAKETQUA)
				.HasColumnName("GHICHUTRAKETQUA")
				.IsUnicode(false)
				.HasMaxLength(255);
            this.Property(t => t.TINHTRANGHOSO)
                .HasColumnName("TINHTRANGHOSO");
			this.Property(t => t.XULYTHEOQUYTRINH)
				.HasColumnName("XULYTHEOQUYTRINH")
				.IsUnicode(false)
				.HasMaxLength(1);
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
			this.Property(t => t.NGAYHENLAYPHIEUCHUYENTHUE)
				.HasColumnName("NGAYHENLAYPHIEUCHUYENTHUE");
			this.Property(t => t.TENHOSO)
				.HasColumnName("TENHOSO")
				.IsUnicode(false)
				.HasMaxLength(255);
            this.Property(t => t.LOAIHOSO)
                .HasColumnName("LOAIHOSO");
			this.Property(t => t.TRANGTHAI)
				.HasColumnName("TRANGTHAI")
				.IsUnicode(false)
				.HasMaxLength(1);
			this.Property(t => t.DONVITHULYID)
				.HasColumnName("DONVITHULYID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.HOSOXULYID)
				.HasColumnName("HOSOXULYID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<HT_TOCHUC>(t => t.HT_TOCHUC)
				.WithMany(m => m.QT_HOSOTIEPNHAN)
				.HasForeignKey(m => m.TOCHUCID);
            this.HasRequired<QT_THUTUCHANHCHINH>(t => t.QT_THUTUCHANHCHINH)
                .WithMany(m => m.QT_HOSOTIEPNHAN)
                .HasForeignKey(m => m.THUTUCHANHCHINHID);

            this.ToTable("QT_HOSOTIEPNHAN"); 
		} 
	} 
}