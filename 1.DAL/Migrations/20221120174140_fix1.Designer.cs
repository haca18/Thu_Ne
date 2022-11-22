﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

namespace _1.DAL.Migrations
{
    [DbContext(typeof(BanGiayDBContext))]
    [Migration("20221120174140_fix1")]
    partial class fix1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1.DAL.Models.ChatLieu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Ma");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Ten");

                    b.Property<int>("TrangThai")
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.ToTable("ChatLieu");
                });

            modelBuilder.Entity("_1.DAL.Models.ChiTietSp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Anh")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Anh");

                    b.Property<double>("DonGiaBan")
                        .HasColumnType("float")
                        .HasColumnName("GiaBan");

                    b.Property<double>("DonGiaNhap")
                        .HasColumnType("float")
                        .HasColumnName("GiaNhap");

                    b.Property<Guid>("IdDongSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNsx")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSize")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdchatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Ma");

                    b.Property<string>("Mavach")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Mavach");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Mota");

                    b.Property<int>("SoLuong")
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasColumnName("SoLuong");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.HasIndex("IdDongSP");

                    b.HasIndex("IdMauSac");

                    b.HasIndex("IdNsx");

                    b.HasIndex("IdSize");

                    b.HasIndex("IdSp");

                    b.HasIndex("IdchatLieu");

                    b.ToTable("ChiTietSP");
                });

            modelBuilder.Entity("_1.DAL.Models.ChucVu", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Ma");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Ten");

                    b.Property<int?>("TrangThai")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("_1.DAL.Models.DongSP", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Ma");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Ten");

                    b.Property<int>("TrangThai")
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.ToTable("DongSP");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHang", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKH")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdNV")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Ma");

                    b.Property<string>("NgayTao")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("NgayTao");

                    b.Property<string>("NgayThanhToan")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("NgayThanhToan");

                    b.Property<string>("Sdt")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("SdtKhanh");

                    b.Property<string>("TenNguoiNhan")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("TenNguoiNhan");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.HasIndex("IdKH");

                    b.HasIndex("IdNV");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHangChiTiet", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("DonGia")
                        .HasColumnType("float")
                        .HasColumnName("DonGia");

                    b.Property<double?>("DonGiaKhiGiam")
                        .HasColumnType("float")
                        .HasColumnName("GiamGia");

                    b.Property<Guid?>("IdChiTietSp")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdGioHang")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("SoLuong");

                    b.HasKey("ID");

                    b.HasIndex("IdChiTietSp");

                    b.HasIndex("IdGioHang");

                    b.ToTable("GioHangChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaHoaDon")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Ma");

                    b.Property<DateTime?>("NgayLap")
                        .HasColumnType("dateTime")
                        .HasColumnName("NgayLap");

                    b.Property<DateTime?>("NgayNhanHang")
                        .HasColumnType("dateTime")
                        .HasColumnName("NgayNhan");

                    b.Property<DateTime?>("NgayShipHang")
                        .HasColumnType("dateTime")
                        .HasColumnName("NgayShip");

                    b.Property<DateTime?>("NgayThanhToan")
                        .HasColumnType("dateTime")
                        .HasColumnName("NgayThanhToan");

                    b.Property<string>("NguoiBan")
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("NguoiBan");

                    b.Property<string>("Sdt")
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SdtKhach");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("DonGia")
                        .HasColumnType("float")
                        .HasColumnName("DonGia");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ChiChu");

                    b.Property<double?>("GiamGia")
                        .HasColumnType("float")
                        .HasColumnName("GiamGia");

                    b.Property<Guid?>("IdChiTIetSp")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdhoaDon")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("SoLuong");

                    b.Property<double?>("ThanhTien")
                        .HasColumnType("float")
                        .HasColumnName("ThanhTien");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.HasIndex("IdChiTIetSp");

                    b.HasIndex("IdhoaDon");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Models.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("DiaChi");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Ma");

                    b.Property<string>("QuocGia")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("QuocGia");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("SDT");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Ten");

                    b.Property<string>("ThangPho")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ThanhPho");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.Property<double?>("diemTieuDung")
                        .HasColumnType("float")
                        .HasColumnName("DiemTieuDung");

                    b.HasKey("Id");

                    b.ToTable("KhacHang");
                });

            modelBuilder.Entity("_1.DAL.Models.KhuyenMai", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("End")
                        .HasColumnType("datetime")
                        .HasColumnName("End");

                    b.Property<string>("LoaiGiamGia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LoaiGiamGia");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Ma");

                    b.Property<decimal?>("MucGiamGia")
                        .HasMaxLength(100)
                        .HasColumnType("decimal")
                        .HasColumnName("MucGiamGia");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("datetime")
                        .HasColumnName("Start");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Ten");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.ToTable("KhuyenMai");
                });

            modelBuilder.Entity("_1.DAL.Models.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Ma");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Ten");

                    b.Property<int>("TrangThai")
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.ToTable("MauSac");
                });

            modelBuilder.Entity("_1.DAL.Models.NSX", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Ma");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Ten");

                    b.Property<int>("TrangThai")
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.ToTable("Nsx");
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Anh")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Anh");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DienThoai");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<int?>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<Guid?>("IdBc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdChucVu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaNhanVien")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Ma");

                    b.Property<int?>("NamSinh")
                        .HasColumnType("int");

                    b.Property<string>("PassWord")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Pass");

                    b.Property<string>("QueQuan")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("QueQuan");

                    b.Property<string>("SoCmnd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SoCmnd");

                    b.Property<string>("TenNhanVien")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenNhanVien");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.HasIndex("IdBc");

                    b.HasIndex("IdChucVu");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Models.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Ma");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Ten");

                    b.Property<int>("TrangThai")
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.SanPhamKhuyenMai", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKhuyenMai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.HasIndex("IdKhuyenMai");

                    b.HasIndex("IdSanPham");

                    b.ToTable("SanPhamKhuyenMai");
                });

            modelBuilder.Entity("_1.DAL.Models.Size", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SizeGiay")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrangThai")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("_1.DAL.Models.ChiTietSp", b =>
                {
                    b.HasOne("_1.DAL.Models.DongSP", "DongSp")
                        .WithMany()
                        .HasForeignKey("IdDongSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.MauSac", "MauSac")
                        .WithMany()
                        .HasForeignKey("IdMauSac");

                    b.HasOne("_1.DAL.Models.NSX", "NSX")
                        .WithMany()
                        .HasForeignKey("IdNsx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("IdSize")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("IdSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.ChatLieu", "ChatLieu")
                        .WithMany()
                        .HasForeignKey("IdchatLieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatLieu");

                    b.Navigation("DongSp");

                    b.Navigation("MauSac");

                    b.Navigation("NSX");

                    b.Navigation("SanPham");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHang", b =>
                {
                    b.HasOne("_1.DAL.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("IdKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IdNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHangChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.ChiTietSp", "ChiTietSp")
                        .WithMany()
                        .HasForeignKey("IdChiTietSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.GioHang", "GioHang")
                        .WithMany()
                        .HasForeignKey("IdGioHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietSp");

                    b.Navigation("GioHang");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("IdKhachHang");

                    b.HasOne("_1.DAL.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IdNhanVien");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.ChiTietSp", "ChiTietSp")
                        .WithMany()
                        .HasForeignKey("IdChiTIetSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("IdhoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietSp");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.HasOne("_1.DAL.Models.NhanVien", "NhanVien1")
                        .WithMany()
                        .HasForeignKey("IdBc");

                    b.HasOne("_1.DAL.Models.ChucVu", "ChucVu")
                        .WithMany()
                        .HasForeignKey("IdChucVu");

                    b.Navigation("ChucVu");

                    b.Navigation("NhanVien1");
                });

            modelBuilder.Entity("_1.DAL.Models.SanPhamKhuyenMai", b =>
                {
                    b.HasOne("_1.DAL.Models.KhuyenMai", "KhuyenMai")
                        .WithMany()
                        .HasForeignKey("IdKhuyenMai");

                    b.HasOne("_1.DAL.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("IdSanPham");

                    b.Navigation("KhuyenMai");

                    b.Navigation("SanPham");
                });
#pragma warning restore 612, 618
        }
    }
}
