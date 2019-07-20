namespace EF6CodeFirstMPLIS.Models
{
    using Configuration;
    using System.Data.Entity;
    public class MplisDbContext : DbContext
    {
        public MplisDbContext() : base ("name=MplisDbContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here
            modelBuilder.HasDefaultSchema("MPLIS21");
            //CS_..._Configuration
            modelBuilder.Configurations.Add(new CS_CHUKYSO_Configuration());
            modelBuilder.Configurations.Add(new CS_GIAYTOXACMINH_Configuration());
            modelBuilder.Configurations.Add(new CS_LICHSUGIAHAN_Configuration());
            modelBuilder.Configurations.Add(new CS_NHACUNGCAP_Configuration());
            //HT_..._Configuration
            modelBuilder.Configurations.Add(new HT_NGUOIDUNG_Configuration());
            modelBuilder.Configurations.Add(new HT_TOCHUC_Configuration());
            modelBuilder.Configurations.Add(new HT_CAUHINHNGUOIDUNG_Configuration());
            modelBuilder.Configurations.Add(new HT_LICHSUTRUYCAP_Configuration());
            modelBuilder.Configurations.Add(new HT_NGUOIDUNG_QUYEN_Configuration());

        }
        //CS_Table
        public DbSet<CS_CHUKYSO> CS_CHUKYSO { get; set; }
        public DbSet<CS_GIAYTOXACMINH> CS_GIAYTOXACMINH { get; set; }
        public DbSet<CS_LICHSUGIAHAN> CS_LICHSUGIAHAN { get; set; }
        public DbSet<CS_NHACUNGCAP> CS_NHACUNGCAP { get; set; }
        //HT_Table
        public DbSet<HT_NGUOIDUNG> HT_NGUOIDUNG { get; set; }
        public DbSet<HT_TOCHUC> HT_TOCHUC { get; set; }
        public DbSet<HT_CAUHINHNGUOIDUNG> HT_CAUHINHNGUOIDUNG { get; set; }
        public DbSet<HT_LICHSUTRUYCAP> HT_LICHSUTRUYCAP { get; set; }
    }
}
