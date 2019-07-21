namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class MT_GIOIHAN_Configuration : EntityTypeConfiguration<MT_GIOIHAN> 
	{ 
		public MT_GIOIHAN_Configuration() 
		{ 
			this.HasKey(t => t.GIOIHANID); 
			
			this.Property(t => t.GIOIHANID)
				.HasColumnName("GIOIHANID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAIGIOIHAN)
				.HasColumnName("LOAIGIOIHAN")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.TENGIOIHAN)
				.HasColumnName("TENGIOIHAN")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.GIOIHANDONG)
				.HasColumnName("GIOIHANDONG")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.GIOIHANTAY)
				.HasColumnName("GIOIHANTAY")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.GIOIHANNAM)
				.HasColumnName("GIOIHANNAM")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.GIOIHANBAC)
				.HasColumnName("GIOIHANBAC")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.GIOIHANKHAC)
				.HasColumnName("GIOIHANKHAC")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.MLANDDATAID)
				.HasColumnName("MLANDDATAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MCHATLUONGID)
				.HasColumnName("MCHATLUONGID")
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

			this.ToTable("MT_GIOIHAN"); 
		} 
	} 
}