namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_DONKIENNGHI_Configuration : EntityTypeConfiguration<DC_DONKIENNGHI> 
	{ 
		public DC_DONKIENNGHI_Configuration() 
		{ 
			this.HasKey(t => t.DONKIENNGHIID); 
			
			this.Property(t => t.DONKIENNGHIID)
				.HasColumnName("DONKIENNGHIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DANHSACHCONGKHAIID)
				.HasColumnName("DANHSACHCONGKHAIID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.TENFILE)
				.HasColumnName("TENFILE")
				.IsUnicode(false)
				.HasMaxLength(150);
			this.Property(t => t.DUONGDANFILE)
				.HasColumnName("DUONGDANFILE")
				.IsUnicode(false)
				.HasMaxLength(2000);
			this.Property(t => t.UID)
				.HasColumnName("UID")
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
			
			this.HasRequired<DC_DANHSACHCONGKHAI>(t => t.DC_DANHSACHCONGKHAI)
				.WithMany(m => m.DC_DONKIENNGHI)
				.HasForeignKey(m => m.DANHSACHCONGKHAIID);  

			this.ToTable("DC_DONKIENNGHI"); 
		} 
	} 
}