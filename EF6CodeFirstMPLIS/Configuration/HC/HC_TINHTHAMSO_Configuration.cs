namespace EF6CodeFirstMPLIS.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class HC_TINHTHAMSO_Configuration : EntityTypeConfiguration<HC_TINHTHAMSO>
    {
        public HC_TINHTHAMSO_Configuration()
        {
            this.HasKey(t => t.TINHTHAMSOID);

            this.Property(t => t.TINHTHAMSOID)
                .HasColumnName("TINHTHAMSOID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THUADATSERVICELINK)
                .HasColumnName("THUADATSERVICELINK")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.THUADATLAYERINDEX)
                .HasColumnName("THUADATLAYERINDEX");
            this.Property(t => t.BASEMAPSERVICELINK)
                .HasColumnName("BASEMAPSERVICELINK")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.QUYHOACHCAPTINHMAPSERVICELINK)
                .HasColumnName("QUYHOACHCAPTINHMAPSERVICELINK")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.KHOANHDATSERVICELINK)
                .HasColumnName("KHOANHDATSERVICELINK")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.HIENTRANGSERVICELINK)
                .HasColumnName("HIENTRANGSERVICELINK")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.GIADATSERVICELINK)
                .HasColumnName("GIADATSERVICELINK")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.VETINHSERVICELINK)
                .HasColumnName("VETINHSERVICELINK")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.GIADATGRSERVICELINK)
                .HasColumnName("GIADATGRSERVICELINK")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.MDSDSERVICELINK)
                .HasColumnName("MDSDSERVICELINK")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.CAPGCNSERVICELINK)
                .HasColumnName("CAPGCNSERVICELINK")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.TINHID)
                .HasColumnName("TINHID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.KINHTUYENTRUC)
                .HasColumnName("KINHTUYENTRUC");
            this.Property(t => t.NGUOICAPNHATID)
                .HasColumnName("NGUOICAPNHATID")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.THOIDIEMCAPNHAT)
                .HasColumnName("THOIDIEMCAPNHAT");
            this.Property(t => t.THOIDIEMKHOITAO)
                .HasColumnName("THOIDIEMKHOITAO");
            this.Property(t => t.uId)
                .HasColumnName("uId")
                .IsUnicode(false)
                .HasMaxLength(36);
            this.Property(t => t.QUYHOACHCAPTINHLAYERINDEX)
                .HasColumnName("QUYHOACHCAPTINHLAYERINDEX");
            this.Property(t => t.KHOANHDATLAYERINDEX)
                .HasColumnName("KHOANHDATLAYERINDEX");
            this.Property(t => t.HIENTRANGLAYERINDEX)
                .HasColumnName("HIENTRANGLAYERINDEX");
            this.Property(t => t.GIADATLAYERINDEX)
                .HasColumnName("GIADATLAYERINDEX");
            this.Property(t => t.MDSDLAYERINDEX)
                .HasColumnName("MDSDLAYERINDEX");
            this.Property(t => t.CAPGCNLAYERINDEX)
                .HasColumnName("CAPGCNLAYERINDEX");
            this.Property(t => t.GIADATGRLAYERINDEX)
                .HasColumnName("GIADATGRLAYERINDEX");
            this.Property(t => t.KVHCSERVICELINK)
                .HasColumnName("KVHCSERVICELINK")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.KVHCLAYERTINHINDEX)
                .HasColumnName("KVHCLAYERTINHINDEX");
            this.Property(t => t.LOADEXPORTDGN)
                .HasColumnName("LOADEXPORTDGN")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.LOADEXPORTGML)
                .HasColumnName("LOADEXPORTGML")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.GETDATAEDITDESKTOP)
                .HasColumnName("GETDATAEDITDESKTOP")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.THUADATMAPSERVERLINK)
                .HasColumnName("THUADATMAPSERVERLINK")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.THUADATMAPSERVERINDEX)
                .HasColumnName("THUADATMAPSERVERINDEX");
            this.Property(t => t.KVHCLAYERHUYENINDEX)
                .HasColumnName("KVHCLAYERHUYENINDEX");
            this.Property(t => t.KVHCLAYERXAINDEX)
                .HasColumnName("KVHCLAYERXAINDEX");
            this.Property(t => t.LOADEXPORTSHAPEFILE)
                .HasColumnName("LOADEXPORTSHAPEFILE")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.GEOMETRYSERVER)
                .HasColumnName("GEOMETRYSERVER")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.QUYHOACHCAPHUYENLAYERINDEX)
                .HasColumnName("QUYHOACHCAPHUYENLAYERINDEX");
            this.Property(t => t.QUYHOACHCAPHUYENMAPSERVICELINK)
                .HasColumnName("QUYHOACHCAPHUYENMAPSERVICELINK")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.QUYHOACHCAPHUYENFEATURESERVER)
                .HasColumnName("QUYHOACHCAPHUYENFEATURESERVER")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.QUYHOACHCAPTINHFEATURESERVER)
                .HasColumnName("QUYHOACHCAPTINHFEATURESERVER")
                .IsUnicode(false)
                .HasMaxLength(250);
            this.Property(t => t.THUADATSERVICELINKLOCAL)
                .HasColumnName("THUADATSERVICELINKLOCAL")
                .IsUnicode(false)
                .HasMaxLength(250);

            this.HasRequired<HC_TINH>(t => t.HC_TINH)
                .WithMany(m => m.HC_TINHTHAMSO)
                .HasForeignKey(m => m.TINHID);

            this.ToTable("HC_TINHTHAMSO");
        }
    }
}
