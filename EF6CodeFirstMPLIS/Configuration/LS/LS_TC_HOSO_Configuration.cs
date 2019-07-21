namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class LS_TC_HOSO_Configuration : EntityTypeConfiguration<LS_TC_HOSO> 
	{ 
		public LS_TC_HOSO_Configuration() 
		{ 
			this.HasKey(t => t.TCHOSOID);

            this.Property(t => t.TCHOSOID)
                .HasColumnName("TCHOSOID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.SOBIENNHAN)
				.HasColumnName("SOBIENNHAN")
				.IsUnicode(false)
				.HasMaxLength(30);
			this.Property(t => t.NGUOINOPHOSO)
				.HasColumnName("NGUOINOPHOSO")
				.IsUnicode(false)
				.HasMaxLength(150);
			this.Property(t => t.DIACHI)
				.HasColumnName("DIACHI")
				.IsUnicode(false)
				.HasMaxLength(255);
			this.Property(t => t.HOSOID)
				.HasColumnName("HOSOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.BOHOSOID)
				.HasColumnName("BOHOSOID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MAKVHC)
				.HasColumnName("MAKVHC")
				.IsUnicode(false)
				.HasMaxLength(10);
			this.Property(t => t.NGAYNHANHOSO)
				.HasColumnName("NGAYNHANHOSO");
			this.Property(t => t.NGAYTRAKETQUA)
				.HasColumnName("NGAYTRAKETQUA");
			
			this.HasRequired<LS_BOHOSO>(t => t.LS_BOHOSO)
				.WithMany(m => m.LS_TC_HOSO)
				.HasForeignKey(m => m.BOHOSOID);  

			this.ToTable("LS_TC_HOSO"); 
		} 
	} 
}