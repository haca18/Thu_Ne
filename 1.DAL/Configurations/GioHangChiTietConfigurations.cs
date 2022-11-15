using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    internal class GioHangChiTietConfigurations :IEntityTypeConfiguration<GioHangChiTiet>
    {
        public void Configure(EntityTypeBuilder<GioHangChiTiet> builder)
        {
            builder.ToTable("GioHangChiTiet"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.HasKey(x => x.IdChiTietSp); // Set khóa chính
            builder.HasKey(x => x.IdGioHang); // Set khóa chính
            builder.Property(p => p.DonGia).HasColumnName("DonGia").
              HasColumnType("float").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.SoLuong).HasColumnName("SoLuong").
               HasColumnType("int").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.DonGiaKhiGiam).HasColumnName("GiamGia").
               HasColumnType("float").IsRequired(); // nvarchar(100) not null
             // Set khóa ngoại
            builder.HasOne(x => x.ChiTietSp)
           .WithMany().HasForeignKey(p => p.IdChiTietSp);
            builder.HasOne(x => x.GioHang)
            .WithMany().HasForeignKey(p => p.IdGioHang);

        }
    }
}
