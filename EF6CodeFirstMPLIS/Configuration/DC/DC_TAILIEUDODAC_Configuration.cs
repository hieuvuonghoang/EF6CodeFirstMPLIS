namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_TAILIEUDODAC_Configuration : EntityTypeConfiguration<DC_TAILIEUDODAC> 
	{ 
		public DC_TAILIEUDODAC_Configuration() 
		{ 
			this.HasKey(t => t.TAILIEUDODACID); 
			
			this.Property(t => t.TAILIEUDODACID)
				.HasColumnName("TAILIEUDODACID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.KVHCID)
                .HasColumnName("KVHCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.XAID)
				.HasColumnName("XAID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.LOAIBANDODIACHINHID)
				.HasColumnName("LOAIBANDODIACHINHID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.DONVIDODAC)
				.HasColumnName("DONVIDODAC")
				.IsUnicode(false)
				.HasMaxLength(150);
			this.Property(t => t.PHUONGPHAPDO)
				.HasColumnName("PHUONGPHAPDO")
				.IsUnicode(false)
				.HasMaxLength(150);
			this.Property(t => t.MUCDOCHINHXAC)
				.HasColumnName("MUCDOCHINHXAC")
				.IsUnicode(false)
				.HasMaxLength(50);
			this.Property(t => t.TYLEDODAC)
				.HasColumnName("TYLEDODAC")
				.IsUnicode(false)
				.HasMaxLength(20);
			this.Property(t => t.NGAYHOANTHANH)
				.HasColumnName("NGAYHOANTHANH");
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
			this.Property(t => t.TENTAILIEU)
				.HasColumnName("TENTAILIEU")
				.IsUnicode(false)
				.HasMaxLength(100);
			this.Property(t => t.GHICHU)
				.HasColumnName("GHICHU")
				.IsUnicode(false)
				.HasMaxLength(150); 
			
			this.HasRequired<DM_LOAIBANDODIACHINH>(t => t.DM_LOAIBANDODIACHINH)
				.WithMany(m => m.DC_TAILIEUDODAC)
				.HasForeignKey(m => m.LOAIBANDODIACHINHID);
            this.HasRequired<HC_DMKVHC>(t => t.HC_DMKVHC)
                .WithMany(m => m.DC_TAILIEUDODAC)
                .HasForeignKey(m => m.KVHCID)
                .WillCascadeOnDelete(false);

            this.ToTable("DC_TAILIEUDODAC"); 
		} 
	} 
}