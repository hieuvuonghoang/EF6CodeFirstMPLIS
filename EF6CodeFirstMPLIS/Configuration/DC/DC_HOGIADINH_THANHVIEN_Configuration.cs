namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_HOGIADINH_THANHVIEN_Configuration : EntityTypeConfiguration<DC_HOGIADINH_THANHVIEN> 
	{ 
		public DC_HOGIADINH_THANHVIEN_Configuration() 
		{ 
			this.HasKey(t => t.HOGIADINHTVID);

            this.Property(t => t.HOGIADINHTVID)
                .HasColumnName("HOGIADINHTVID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.HOGIADINHID)
				.HasColumnName("HOGIADINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.CANHANID)
				.HasColumnName("CANHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.uId)
				.HasColumnName("uId")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THOIDIEMKHOITAO)
				.HasColumnName("THOIDIEMKHOITAO");
			this.Property(t => t.THOIDIEMCAPNHAT)
				.HasColumnName("THOIDIEMCAPNHAT");
			this.Property(t => t.NGUOICAPNHATID)
				.HasColumnName("NGUOICAPNHATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.QHVOICHUHOID)
				.HasColumnName("QHVOICHUHOID")
				.IsUnicode(false)
				.HasMaxLength(36); 
			
			this.HasRequired<DM_QHVOICHUHO>(t => t.DM_QHVOICHUHO)
				.WithMany(m => m.DC_HOGIADINH_THANHVIEN)
				.HasForeignKey(m => m.QHVOICHUHOID);  

			this.ToTable("DC_HOGIADINH_THANHVIEN"); 
		} 
	} 
}