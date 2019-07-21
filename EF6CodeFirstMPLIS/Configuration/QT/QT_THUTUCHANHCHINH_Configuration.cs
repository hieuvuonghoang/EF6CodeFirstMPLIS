namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class QT_THUTUCHANHCHINH_Configuration : EntityTypeConfiguration<QT_THUTUCHANHCHINH> 
	{ 
		public QT_THUTUCHANHCHINH_Configuration() 
		{ 
			this.HasKey(t => t.THUTUCHANHCHINHID); 
			
			this.Property(t => t.THUTUCHANHCHINHID)
				.HasColumnName("THUTUCHANHCHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.TOCHUCID)
                .HasColumnName("TOCHUCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.BOTHUTUCHANHCHINHID)
				.HasColumnName("BOTHUTUCHANHCHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENTHUTUCHANHCHINH)
				.HasColumnName("TENTHUTUCHANHCHINH")
				.IsUnicode(false)
				.HasMaxLength(1000);
			this.Property(t => t.MOTA)
				.HasColumnName("MOTA")
				.IsUnicode(false)
				.HasMaxLength(2000);
            this.Property(t => t.CAP)
                .HasColumnName("CAP");
			this.Property(t => t.DONVIHANHCHINHID)
				.HasColumnName("DONVIHANHCHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIHANGIAIQUYETTOIDA)
				.HasColumnName("THOIHANGIAIQUYETTOIDA");
            this.Property(t => t.LEPHI)
                .HasColumnName("LEPHI");
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
			this.Property(t => t.KYHIEU)
				.HasColumnName("KYHIEU")
				.IsUnicode(false)
				.HasMaxLength(15);
			this.Property(t => t.DONVIID)
				.HasColumnName("DONVIID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<DM_BOTHUTUCHANHCHINH>(t => t.DM_BOTHUTUCHANHCHINH)
				.WithMany(m => m.QT_THUTUCHANHCHINH)
				.HasForeignKey(m => m.BOTHUTUCHANHCHINHID);
            this.HasRequired<HT_TOCHUC>(t => t.HT_TOCHUC)
                .WithMany(m => m.QT_THUTUCHANHCHINH)
                .HasForeignKey(m => m.TOCHUCID);

            this.ToTable("QT_THUTUCHANHCHINH"); 
		} 
	} 
}