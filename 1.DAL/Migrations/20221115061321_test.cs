﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatLieu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLieu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DongSP",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongSP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhacHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ThanhPho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    QuocGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SDT = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    DiemTieuDung = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhacHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LoaiGiamGia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MucGiamGia = table.Column<decimal>(type: "decimal", maxLength: 100, nullable: false),
                    Start = table.Column<DateTime>(type: "datetime", nullable: false),
                    End = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nsx",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nsx", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SizeGiay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: true),
                    NamSinh = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Pass = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    QueQuan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SoCmnd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DienThoai = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    Anh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdBc = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdChucVu",
                        column: x => x.IdChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVien_NhanVien_IdBc",
                        column: x => x.IdBc,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamKhuyenMai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    IdKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamKhuyenMai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPhamKhuyenMai_KhuyenMai_IdKhuyenMai",
                        column: x => x.IdKhuyenMai,
                        principalTable: "KhuyenMai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamKhuyenMai_SanPham_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSP",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Mavach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GiaNhap = table.Column<double>(type: "float", nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    IdchatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNsx = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDongSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_ChatLieu_IdchatLieu",
                        column: x => x.IdchatLieu,
                        principalTable: "ChatLieu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_DongSP_IdDongSP",
                        column: x => x.IdDongSP,
                        principalTable: "DongSP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_MauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_Nsx_IdNsx",
                        column: x => x.IdNsx,
                        principalTable: "Nsx",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_SanPham_IdSp",
                        column: x => x.IdSp,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_Size_IdSize",
                        column: x => x.IdSize,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NgayTao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NgayThanhToan = table.Column<string>(type: "varchar(30)", nullable: false),
                    TenNguoiNhan = table.Column<string>(type: "varchar(30)", nullable: false),
                    SdtKhanh = table.Column<string>(type: "varchar(30)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHang_KhacHang_Id",
                        column: x => x.Id,
                        principalTable: "KhacHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHang_NhanVien_IdNV",
                        column: x => x.IdNV,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    IdhoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NgayLap = table.Column<DateTime>(type: "dateTime", nullable: true),
                    NgayNhan = table.Column<DateTime>(type: "dateTime", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "dateTime", nullable: true),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    NgayShip = table.Column<DateTime>(type: "dateTime", nullable: true),
                    NguoiBan = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    SdtKhach = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.IdhoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhacHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhacHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangChiTiet",
                columns: table => new
                {
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietSp = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    GiamGia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangChiTiet", x => x.IdGioHang);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_ChiTietSP_IdChiTietSp",
                        column: x => x.IdChiTietSp,
                        principalTable: "ChiTietSP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_GioHang_IdGioHang",
                        column: x => x.IdGioHang,
                        principalTable: "GioHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    IdChiTIetSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdhoaDonChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHoaDon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiamGia = table.Column<double>(type: "float", nullable: false),
                    ThanhTien = table.Column<double>(type: "float", nullable: false),
                    IdhoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    ChiChu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.IdChiTIetSp);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ChiTietSP_IdChiTIetSp",
                        column: x => x.IdChiTIetSp,
                        principalTable: "ChiTietSP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdhoaDon",
                        column: x => x.IdhoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "IdhoaDon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdchatLieu",
                table: "ChiTietSP",
                column: "IdchatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdDongSP",
                table: "ChiTietSP",
                column: "IdDongSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdMauSac",
                table: "ChiTietSP",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdNsx",
                table: "ChiTietSP",
                column: "IdNsx");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdSize",
                table: "ChiTietSP",
                column: "IdSize");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdSp",
                table: "ChiTietSP",
                column: "IdSp");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_IdNV",
                table: "GioHang",
                column: "IdNV");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_IdChiTietSp",
                table: "GioHangChiTiet",
                column: "IdChiTietSp");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdhoaDon",
                table: "HoaDonChiTiet",
                column: "IdhoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdBc",
                table: "NhanVien",
                column: "IdBc");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdChucVu",
                table: "NhanVien",
                column: "IdChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamKhuyenMai_IdKhuyenMai",
                table: "SanPhamKhuyenMai",
                column: "IdKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamKhuyenMai_IdSanPham",
                table: "SanPhamKhuyenMai",
                column: "IdSanPham");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHangChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "SanPhamKhuyenMai");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "ChiTietSP");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "ChatLieu");

            migrationBuilder.DropTable(
                name: "DongSP");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "Nsx");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "KhacHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
