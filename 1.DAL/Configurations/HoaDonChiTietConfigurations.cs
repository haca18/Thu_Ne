﻿using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    internal interface HoaDonChiTietConfigurations : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.HasKey(x => x.IdhoaDonChiTiet); // Set khóa chính
            builder.HasKey(x => x.IdChiTIetSp); // Set khóa chính
            // Cấu hình dữ liệu
            builder.Property(k => k.IdhoaDon).IsRequired();
            builder.Property(k => k.IdChiTIetSp).IsRequired();
            builder.Property(p => p.TrangThai).HasColumnName("TrangThai").
                HasColumnType("int").IsRequired(); // varchar(100) not null
            builder.Property(p => p.MaHoaDonChiTiet).HasColumnName("MaHoaDon").
               HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.DonGia).HasColumnName("DonGia").
               HasColumnType("double").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.SoLuong).HasColumnName("SoLuong").
               HasColumnType("int").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.GiamGia).HasColumnName("GiamGia").
               HasColumnType("double").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.ThanhTien).HasColumnName("ThanhTien").
               HasColumnType("double").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.GhiChu).HasColumnName("ChiChu").
               HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
            // Set khóa ngoại
            builder.HasOne(x => x.HoaDon)
           .WithMany().HasForeignKey(p => p.IdhoaDon);
            builder.HasOne(x => x.ChiTietSp)
            .WithMany().HasForeignKey(p => p.IdChiTIetSp);





        }
    }
}