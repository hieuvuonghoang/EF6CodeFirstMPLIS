namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class HT_XA_NGUOIDUNG_Configuration : EntityTypeConfiguration<HT_XA_NGUOIDUNG> 
	{ 
		public HT_XA_NGUOIDUNG_Configuration() 
		{ 
			this.HasKey(t => t.XANGUOIDUNGID);

            this.Property(t => t.XANGUOIDUNGID)
                .HasColumnName("XANGUOIDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.KVHCID)
                .HasColumnName("KVHCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOIDUNGID)
				.HasColumnName("NGUOIDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
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
			
			this.HasRequired<HC_DMKVHC>(t => t.HC_DMKVHC)
				.WithMany(m => m.HT_XA_NGUOIDUNG)
				.HasForeignKey(m => m.KVHCID);
            this.HasRequired<HT_NGUOIDUNG>(t => t.HT_NGUOIDUNG)
                .WithMany(m => m.HT_XA_NGUOIDUNG)
                .HasForeignKey(m => m.NGUOIDUNGID);

            this.ToTable("HT_XA_NGUOIDUNG"); 
		} 
	} 
}