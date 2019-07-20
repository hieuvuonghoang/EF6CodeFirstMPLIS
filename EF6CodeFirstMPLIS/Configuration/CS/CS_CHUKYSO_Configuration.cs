namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class CS_CHUKYSO_Configuration : EntityTypeConfiguration<CS_CHUKYSO>
    {
        public CS_CHUKYSO_Configuration()
        {
            this.HasKey(t => t.CHUKYSOID);

            this.Property(t => t.CHUKYSOID)
                .HasColumnName("CHUKYSOID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NHACUNGCAPID)
                .HasColumnName("NHACUNGCAPID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.TOCHUCID)
                .HasColumnName("TOCHUCID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOIDUNGID)
                .HasColumnName("NGUOIDUNGID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.LOAICHUKYSO)
                .HasColumnName("LOAICHUKYSO");
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
            this.Property(t => t.NGAYCOHIEULUC)
                .HasColumnName("NGAYCOHIEULUC");
            this.Property(t => t.NGAYHETHIEULUC)
                .HasColumnName("NGAYHETHIEULUC");
            this.Property(t => t.TRANGTHAIXACTHUC)
                .HasColumnName("TRANGTHAIXACTHUC");
            this.Property(t => t.uId)
                .HasColumnName("uId")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.NGUOICAPNHATID)
                .HasColumnName("NGUOICAPNHATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.CA)
                .HasColumnName("CA");

            this.HasRequired<CS_NHACUNGCAP>(t => t.CS_NHACUNGCAP)
                .WithMany(m => m.CS_CHUKYSO)
                .HasForeignKey(t => t.NHACUNGCAPID);
            this.HasRequired<HT_NGUOIDUNG>(t => t.HT_NGUOIDUNG)
                .WithMany(m => m.CS_CHUKYSO)
                .HasForeignKey(t => t.NGUOIDUNGID);
            this.HasRequired<HT_TOCHUC>(t => t.HT_TOCHUC)
                .WithMany(m => m.CS_CHUKYSO)
                .HasForeignKey(t => t.TOCHUCID);

            this.ToTable("CS_CHUKYSO");
        }
    }
}
