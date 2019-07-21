namespace EF6CodeFirstMPLIS.Configuration 
{ 
	using Models;
	using System.Data.Entity.ModelConfiguration; 
	public class DC_THUEDAT_Configuration : EntityTypeConfiguration<DC_THUEDAT> 
	{ 
		public DC_THUEDAT_Configuration() 
		{ 
			this.HasKey(t => t.THUEDATID); 
			
			this.Property(t => t.THUEDATID)
				.HasColumnName("THUEDATID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.CTNDIENTICHXAYDUNG)
                .HasColumnName("CTNDIENTICHXAYDUNG");
            this.Property(t => t.CTNGIADATDIENTICHXD)
                .HasColumnName("CTNGIADATDIENTICHXD");
            this.Property(t => t.DATCOMNDIENTICHMATDAT)
                .HasColumnName("DATCOMNDIENTICHMATDAT");
            this.Property(t => t.DATCOMNDIENTICHMATNUOC)
                .HasColumnName("DATCOMNDIENTICHMATNUOC");
            this.Property(t => t.DATCOMNGIADAT)
                .HasColumnName("DATCOMNGIADAT");
			this.Property(t => t.MNVITRI)
				.HasColumnName("MNVITRI")
				.IsUnicode(false)
				.HasMaxLength(200);
            this.Property(t => t.MNDIENTICHTHUE)
                .HasColumnName("MNDIENTICHTHUE");
			this.Property(t => t.BIENDONGID)
				.HasColumnName("BIENDONGID")
				.IsUnicode(false)
				.HasMaxLength(36);
			this.Property(t => t.MUCDICHSUDUNGID)
				.HasColumnName("MUCDICHSUDUNGID")
				.IsUnicode(false)
				.HasMaxLength(36);
            this.Property(t => t.THOIHANTHUE)
                .HasColumnName("THOIHANTHUE");
			this.Property(t => t.TUNGAY)
				.HasColumnName("TUNGAY");
			this.Property(t => t.DENNGAY)
				.HasColumnName("DENNGAY");
			this.Property(t => t.HINHTHUCTHUEMN)
				.HasColumnName("HINHTHUCTHUEMN"); 
			
			this.HasRequired<DC_BIENDONG>(t => t.DC_BIENDONG)
				.WithMany(m => m.DC_THUEDAT)
				.HasForeignKey(m => m.BIENDONGID);
            this.HasRequired<DM_MUCDICHSUDUNG>(t => t.DM_MUCDICHSUDUNG)
                .WithMany(m => m.DC_THUEDAT)
                .HasForeignKey(m => m.MUCDICHSUDUNGID);

            this.ToTable("DC_THUEDAT"); 
		} 
	} 
}