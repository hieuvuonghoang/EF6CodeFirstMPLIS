namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HT_MENU_Configuration : EntityTypeConfiguration<HT_MENU>
    {
        public HT_MENU_Configuration()
        {
            this.HasKey(t => t.MENUID);

            this.Property(t => t.MENUID)
                .HasColumnName("MENUID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.KHOACHAID)
                .HasColumnName("KHOACHAID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.UNGDUNGID)
                .HasColumnName("UNGDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.URL)
                .HasColumnName("URL")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.TENMENU)
                .HasColumnName("TENMENU")
                .IsUnicode(false)
                .HasMaxLength(80);
            this.Property(t => t.MOTA)
                .HasColumnName("MOTA")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.ICON)
                .HasColumnName("ICON");
            this.Property(t => t.CHOPHEPSUDUNG)
                .HasColumnName("CHOPHEPSUDUNG")
                .IsUnicode(false)
                .HasMaxLength(1);
            this.Property(t => t.THUTUSAPXEP)
                .HasColumnName("THUTUSAPXEP")
                .IsUnicode(false)
                .HasMaxLength(50);
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
            this.Property(t => t.ACTION)
                .HasColumnName("ACTION")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.CONTROLLER)
                .HasColumnName("CONTROLLER")
                .IsUnicode(false)
                .HasMaxLength(255);
            this.Property(t => t.MAMENU)
                .HasColumnName("MAMENU")
                .IsUnicode(false)
                .HasMaxLength(30);

            this.HasRequired<HT_MENU>(t => t.HT_MENU2)
                .WithMany(m => m.HT_MENU1)
                .HasForeignKey(m => m.KHOACHAID);

            this.ToTable("HT_MENU");

        }
    }
}
