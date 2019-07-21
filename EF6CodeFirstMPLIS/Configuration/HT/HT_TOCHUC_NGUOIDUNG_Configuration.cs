namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HT_TOCHUC_NGUOIDUNG_Configuration : EntityTypeConfiguration<HT_TOCHUC_NGUOIDUNG> 
	{ 
		public HT_TOCHUC_NGUOIDUNG_Configuration() 
		{ 
			this.HasKey(t => t.TOCHUCNGUOIDUNGID);

            this.Property(t => t.TOCHUCNGUOIDUNGID)
                .HasColumnName("TOCHUCNGUOIDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TOCHUCID)
				.HasColumnName("TOCHUCID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.NGUOIDUNGID)
				.HasColumnName("NGUOIDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.CHUCVU)
				.HasColumnName("CHUCVU")
				.IsUnicode(false)
				.HasMaxLength(50);
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
			
			this.HasRequired<HT_NGUOIDUNG>(t => t.HT_NGUOIDUNG)
				.WithMany(m => m.HT_TOCHUC_NGUOIDUNG)
				.HasForeignKey(m => m.NGUOIDUNGID);
            this.HasRequired<HT_TOCHUC>(t => t.HT_TOCHUC)
                .WithMany(m => m.HT_TOCHUC_NGUOIDUNG)
                .HasForeignKey(m => m.TOCHUCID);

            this.ToTable("HT_TOCHUC_NGUOIDUNG"); 
		} 
	} 
}