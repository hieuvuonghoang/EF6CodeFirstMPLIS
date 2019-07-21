namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_THUATAISAN_Configuration : EntityTypeConfiguration<DC_THUATAISAN> 
	{ 
		public DC_THUATAISAN_Configuration() 
		{ 
			this.HasKey(t => t.THUATAISANID);

            this.Property(t => t.THUATAISANID)
                .HasColumnName("THUATAISANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TAISANGANLIENVOIDATID)
				.HasColumnName("TAISANGANLIENVOIDATID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.THUADATID)
				.HasColumnName("THUADATID")
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
			
			this.HasRequired<DC_TAISANGANLIENVOIDAT>(t => t.DC_TAISANGANLIENVOIDAT)
				.WithMany(m => m.DC_THUATAISAN)
				.HasForeignKey(m => m.TAISANGANLIENVOIDATID);
            this.HasRequired<DC_THUADAT>(t => t.DC_THUADAT)
                .WithMany(m => m.DC_THUATAISAN)
                .HasForeignKey(m => m.THUADATID);

            this.ToTable("DC_THUATAISAN"); 
		} 
	} 
}