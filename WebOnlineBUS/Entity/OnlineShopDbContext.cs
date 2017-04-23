namespace WebOnlineBUS.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext()
            : base("name=OnlineShopDbContext")
        {
        }

        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<DanhMucCon> DanhMucCons { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<HoTroTrucTuyen> HoTroTrucTuyens { get; set; }
        public virtual DbSet<LoaiNguoiDung> LoaiNguoiDungs { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<PhanAnh> PhanAnhs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhMuc>()
                .HasMany(e => e.DanhMucCons)
                .WithRequired(e => e.DanhMuc)
                .HasForeignKey(e => e.DanhMucChaID);

            modelBuilder.Entity<DanhMucCon>()
                .Property(e => e.ThuTuHienThi)
                .IsFixedLength();

            modelBuilder.Entity<LoaiNguoiDung>()
                .HasMany(e => e.NguoiDungs)
                .WithRequired(e => e.LoaiNguoiDung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.DonHangs)
                .WithRequired(e => e.NguoiDung)
                .HasForeignKey(e => e.KhachHangID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.LoaiSanPhams)
                .WithOptional(e => e.NguoiDung)
                .HasForeignKey(e => e.NguoiCapNhat);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.LoaiSanPhams1)
                .WithOptional(e => e.NguoiDung1)
                .HasForeignKey(e => e.NguoiTao);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.SanPhams)
                .WithOptional(e => e.NguoiDung)
                .HasForeignKey(e => e.NguoiTao);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.SanPhams1)
                .WithOptional(e => e.NguoiDung1)
                .HasForeignKey(e => e.NguoiCapNhat);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.KhuyenMai)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.SanPhams)
                .Map(m => m.ToTable("TagSanPham").MapLeftKey("SanPhamID").MapRightKey("TagID"));
        }
    }
}
