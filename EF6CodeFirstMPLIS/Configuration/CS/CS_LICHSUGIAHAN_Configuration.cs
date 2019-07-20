namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class CS_LICHSUGIAHAN_Configuration : EntityTypeConfiguration<CS_LICHSUGIAHAN>
    {
        public CS_LICHSUGIAHAN_Configuration()
        {
            this.HasKey(t => t.LICHSUGIAHANID);

            this.Property(t => t.LICHSUGIAHANID)
                .HasColumnName("LICHSUGIAHANID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.CHUKYSOID)
                .HasColumnName("CHUKYSOID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THOIDIEMGIAHAN)
                .HasColumnName("THOIDIEMGIAHAN");
            this.Property(t => t.NGUOIDUNGTEN)
                .HasColumnName("NGUOIDUNGTEN")
                .IsUnicode(false)
                .HasMaxLength(100);
            this.Property(t => t.TENTOCHUC)
                .HasColumnName("TENTOCHUC")
                .IsUnicode(false)
                .HasMaxLength(150);
            this.Property(t => t.CHUCVU)
                .HasColumnName("CHUCVU")
                .IsUnicode(false)
                .HasMaxLength(50);
            this.Property(t => t.NOICONGTAC)
                .HasColumnName("NOICONGTAC")
                .IsUnicode(false)
                .HasMaxLength(100);
            this.Property(t => t.NGAYHETHIEULUCTRUOCGIAHAN)
                .HasColumnName("NGAYHETHIEULUCTRUOCGIAHAN");
            this.Property(t => t.NGAYHETHIEULUCSAUGIAHAN)
                .HasColumnName("NGAYHETHIEULUCSAUGIAHAN");
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
            this.Property(t => t.NGUOIDUNGID)
                .HasColumnName("NGUOIDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TOCHUCID)
                .HasColumnName("TOCHUCID")
                .IsUnicode(false)
                .HasMaxLength(36);

            this.HasRequired<CS_CHUKYSO>(t => t.CS_CHUKYSO)
                .WithMany(m => m.CS_LICHSUGIAHAN)
                .HasForeignKey(m => m.CHUKYSOID);

            this.ToTable("CS_LICHSUGIAHAN");
        }
    }
}
