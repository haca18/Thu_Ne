using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class up : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_ChatLieu_IdchatLieu",
                table: "ChiTietSP");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_DongSP_IdDongSP",
                table: "ChiTietSP");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_Nsx_IdNsx",
                table: "ChiTietSP");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_SanPham_IdSp",
                table: "ChiTietSP");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_Sizes_IdSize",
                table: "ChiTietSP");

            migrationBuilder.RenameColumn(
                name: "Ma",
                table: "ChiTietSP",
                newName: "Anh");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "ChiTietSP",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SoLuong",
                table: "ChiTietSP",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdchatLieu",
                table: "ChiTietSP",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdSp",
                table: "ChiTietSP",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdSize",
                table: "ChiTietSP",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdNsx",
                table: "ChiTietSP",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdDongSP",
                table: "ChiTietSP",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "GiaNhap",
                table: "ChiTietSP",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "GiaBan",
                table: "ChiTietSP",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Anh",
                table: "ChiTietSP",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Anh1",
                table: "ChiTietSP",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_ChatLieu_IdchatLieu",
                table: "ChiTietSP",
                column: "IdchatLieu",
                principalTable: "ChatLieu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_DongSP_IdDongSP",
                table: "ChiTietSP",
                column: "IdDongSP",
                principalTable: "DongSP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_Nsx_IdNsx",
                table: "ChiTietSP",
                column: "IdNsx",
                principalTable: "Nsx",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_SanPham_IdSp",
                table: "ChiTietSP",
                column: "IdSp",
                principalTable: "SanPham",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_Sizes_IdSize",
                table: "ChiTietSP",
                column: "IdSize",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_ChatLieu_IdchatLieu",
                table: "ChiTietSP");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_DongSP_IdDongSP",
                table: "ChiTietSP");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_Nsx_IdNsx",
                table: "ChiTietSP");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_SanPham_IdSp",
                table: "ChiTietSP");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietSP_Sizes_IdSize",
                table: "ChiTietSP");

            migrationBuilder.DropColumn(
                name: "Anh1",
                table: "ChiTietSP");

            migrationBuilder.RenameColumn(
                name: "Anh",
                table: "ChiTietSP",
                newName: "Ma");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "ChiTietSP",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SoLuong",
                table: "ChiTietSP",
                type: "int",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdchatLieu",
                table: "ChiTietSP",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdSp",
                table: "ChiTietSP",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdSize",
                table: "ChiTietSP",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdNsx",
                table: "ChiTietSP",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdDongSP",
                table: "ChiTietSP",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<double>(
                name: "GiaNhap",
                table: "ChiTietSP",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "GiaBan",
                table: "ChiTietSP",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "ChiTietSP",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_ChatLieu_IdchatLieu",
                table: "ChiTietSP",
                column: "IdchatLieu",
                principalTable: "ChatLieu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_DongSP_IdDongSP",
                table: "ChiTietSP",
                column: "IdDongSP",
                principalTable: "DongSP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_Nsx_IdNsx",
                table: "ChiTietSP",
                column: "IdNsx",
                principalTable: "Nsx",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_SanPham_IdSp",
                table: "ChiTietSP",
                column: "IdSp",
                principalTable: "SanPham",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietSP_Sizes_IdSize",
                table: "ChiTietSP",
                column: "IdSize",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
