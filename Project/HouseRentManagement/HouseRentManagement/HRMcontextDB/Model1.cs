using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HouseRentManagement.HRMcontextDB
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ADMINS> ADMINS { get; set; }
        public virtual DbSet<BANGGIA> BANGGIA { get; set; }
        public virtual DbSet<BANQUANLY> BANQUANLY { get; set; }
        public virtual DbSet<BIENLAI> BIENLAI { get; set; }
        public virtual DbSet<CANHO> CANHO { get; set; }
        public virtual DbSet<CHUCVU> CHUCVU { get; set; }
        public virtual DbSet<CHUSOHUU> CHUSOHUU { get; set; }
        public virtual DbSet<CTHDTT> CTHDTT { get; set; }
        public virtual DbSet<CTNTCB> CTNTCB { get; set; }
        public virtual DbSet<DANHSACHNHANKHAU> DANHSACHNHANKHAU { get; set; }
        public virtual DbSet<HOADONTHANHTOAN> HOADONTHANHTOAN { get; set; }
        public virtual DbSet<HOPDONGTHUE> HOPDONGTHUE { get; set; }
        public virtual DbSet<LOAICANHO> LOAICANHO { get; set; }
        public virtual DbSet<NGUOITHUE> NGUOITHUE { get; set; }
        public virtual DbSet<NOITHATCOBAN> NOITHATCOBAN { get; set; }
        public virtual DbSet<PHIEUCHUYENDO> PHIEUCHUYENDO { get; set; }
        public virtual DbSet<PHIEUPHANHOI> PHIEUPHANHOI { get; set; }
        public virtual DbSet<PHIEUPHAT> PHIEUPHAT { get; set; }
        public virtual DbSet<PHIEUSUACHUA> PHIEUSUACHUA { get; set; }
        public virtual DbSet<PHIEUTHICONG> PHIEUTHICONG { get; set; }
        public virtual DbSet<TANG> TANG { get; set; }
        public virtual DbSet<THECUDAN> THECUDAN { get; set; }
        public virtual DbSet<THEXE> THEXE { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
        public virtual DbSet<XE> XE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADMINS>()
                .Property(e => e.MaQL)
                .IsUnicode(false);

            modelBuilder.Entity<ADMINS>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<BANGGIA>()
                .Property(e => e.MaBangGia)
                .IsUnicode(false);

            modelBuilder.Entity<BANGGIA>()
                .Property(e => e.GiaTien)
                .HasPrecision(20, 3);

            modelBuilder.Entity<BANGGIA>()
                .HasMany(e => e.CTHDTT)
                .WithRequired(e => e.BANGGIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BANQUANLY>()
                .Property(e => e.MaQL)
                .IsUnicode(false);

            modelBuilder.Entity<BANQUANLY>()
                .Property(e => e.MaCV)
                .IsUnicode(false);

            modelBuilder.Entity<BANQUANLY>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<BANQUANLY>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<BANQUANLY>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<BANQUANLY>()
                .HasOptional(e => e.ADMINS)
                .WithRequired(e => e.BANQUANLY);

            modelBuilder.Entity<BANQUANLY>()
                .HasMany(e => e.PHIEUCHUYENDO)
                .WithRequired(e => e.BANQUANLY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BANQUANLY>()
                .HasMany(e => e.PHIEUPHANHOI)
                .WithRequired(e => e.BANQUANLY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BANQUANLY>()
                .HasMany(e => e.PHIEUPHAT)
                .WithRequired(e => e.BANQUANLY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BANQUANLY>()
                .HasMany(e => e.PHIEUSUACHUA)
                .WithRequired(e => e.BANQUANLY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BANQUANLY>()
                .HasMany(e => e.PHIEUTHICONG)
                .WithRequired(e => e.BANQUANLY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.SoBienLai)
                .IsUnicode(false);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.TongTienThanhToan)
                .HasPrecision(20, 3);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.SoHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .Property(e => e.MaTang)
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .Property(e => e.MaChuSoHuu)
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.CTNTCB)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.DANHSACHNHANKHAU)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.HOPDONGTHUE)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.HOADONTHANHTOAN)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.PHIEUCHUYENDO)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.PHIEUPHANHOI)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.PHIEUPHAT)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.PHIEUSUACHUA)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.PHIEUTHICONG)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MaCV)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.LuongCoBan)
                .HasPrecision(20, 3);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.BANQUANLY)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUSOHUU>()
                .Property(e => e.MaChuSoHuu)
                .IsUnicode(false);

            modelBuilder.Entity<CHUSOHUU>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<CHUSOHUU>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<CHUSOHUU>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CHUSOHUU>()
                .HasMany(e => e.CANHO)
                .WithRequired(e => e.CHUSOHUU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUSOHUU>()
                .HasMany(e => e.HOPDONGTHUE)
                .WithRequired(e => e.CHUSOHUU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTHDTT>()
                .Property(e => e.SoHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<CTHDTT>()
                .Property(e => e.MaBangGia)
                .IsUnicode(false);

            modelBuilder.Entity<CTHDTT>()
                .Property(e => e.ThanhTien)
                .HasPrecision(20, 3);

            modelBuilder.Entity<CTNTCB>()
                .Property(e => e.MaNTCB)
                .IsUnicode(false);

            modelBuilder.Entity<CTNTCB>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<DANHSACHNHANKHAU>()
                .Property(e => e.MaNguoiThue)
                .IsUnicode(false);

            modelBuilder.Entity<DANHSACHNHANKHAU>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONTHANHTOAN>()
                .Property(e => e.SoHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONTHANHTOAN>()
                .Property(e => e.TongTien)
                .HasPrecision(20, 3);

            modelBuilder.Entity<HOADONTHANHTOAN>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONTHANHTOAN>()
                .HasMany(e => e.BIENLAI)
                .WithRequired(e => e.HOADONTHANHTOAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADONTHANHTOAN>()
                .HasMany(e => e.CTHDTT)
                .WithRequired(e => e.HOADONTHANHTOAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOPDONGTHUE>()
                .Property(e => e.SoHopDong)
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONGTHUE>()
                .Property(e => e.TienCoc)
                .HasPrecision(20, 3);

            modelBuilder.Entity<HOPDONGTHUE>()
                .Property(e => e.TienThue)
                .HasPrecision(20, 3);

            modelBuilder.Entity<HOPDONGTHUE>()
                .Property(e => e.MaChuSoHuu)
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONGTHUE>()
                .Property(e => e.MaNguoiThue)
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONGTHUE>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<LOAICANHO>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<LOAICANHO>()
                .Property(e => e.GiaThueMacDinh)
                .HasPrecision(20, 3);

            modelBuilder.Entity<LOAICANHO>()
                .HasMany(e => e.CANHO)
                .WithRequired(e => e.LOAICANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUOITHUE>()
                .Property(e => e.MaNguoiThue)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHUE>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHUE>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHUE>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHUE>()
                .HasMany(e => e.DANHSACHNHANKHAU)
                .WithRequired(e => e.NGUOITHUE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUOITHUE>()
                .HasMany(e => e.HOPDONGTHUE)
                .WithRequired(e => e.NGUOITHUE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUOITHUE>()
                .HasMany(e => e.THECUDAN)
                .WithRequired(e => e.NGUOITHUE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOITHATCOBAN>()
                .Property(e => e.MaNTCB)
                .IsUnicode(false);

            modelBuilder.Entity<NOITHATCOBAN>()
                .HasMany(e => e.CTNTCB)
                .WithRequired(e => e.NOITHATCOBAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUCHUYENDO>()
                .Property(e => e.SoPhieuChuyenDo)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUCHUYENDO>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUCHUYENDO>()
                .Property(e => e.MaQL)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHANHOI>()
                .Property(e => e.SoPhieuPhanHoi)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHANHOI>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHANHOI>()
                .Property(e => e.MaQL)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHAT>()
                .Property(e => e.SoPhieuPhat)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHAT>()
                .Property(e => e.ThanhTien)
                .HasPrecision(20, 3);

            modelBuilder.Entity<PHIEUPHAT>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHAT>()
                .Property(e => e.MaQL)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUSUACHUA>()
                .Property(e => e.SoPhieuSuaChua)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUSUACHUA>()
                .Property(e => e.TongTien)
                .HasPrecision(20, 3);

            modelBuilder.Entity<PHIEUSUACHUA>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUSUACHUA>()
                .Property(e => e.MaQL)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHICONG>()
                .Property(e => e.SoPhieuThiCong)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHICONG>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHICONG>()
                .Property(e => e.MaQL)
                .IsUnicode(false);

            modelBuilder.Entity<TANG>()
                .Property(e => e.MaTang)
                .IsUnicode(false);

            modelBuilder.Entity<TANG>()
                .HasMany(e => e.CANHO)
                .WithRequired(e => e.TANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THECUDAN>()
                .Property(e => e.MaTheCuDan)
                .IsUnicode(false);

            modelBuilder.Entity<THECUDAN>()
                .Property(e => e.MaNguoiThue)
                .IsUnicode(false);

            modelBuilder.Entity<THECUDAN>()
                .HasMany(e => e.THEXE)
                .WithRequired(e => e.THECUDAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THECUDAN>()
                .HasOptional(e => e.USERS)
                .WithRequired(e => e.THECUDAN);

            modelBuilder.Entity<THEXE>()
                .Property(e => e.MaTheXe)
                .IsUnicode(false);

            modelBuilder.Entity<THEXE>()
                .Property(e => e.MaTheCuDan)
                .IsUnicode(false);

            modelBuilder.Entity<THEXE>()
                .HasMany(e => e.XE)
                .WithRequired(e => e.THEXE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.MaTheCuDan)
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<XE>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<XE>()
                .Property(e => e.MaTheXe)
                .IsUnicode(false);
        }
    }
}
