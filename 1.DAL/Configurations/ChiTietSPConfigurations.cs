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
    internal interface ChiTietSPConfigurations : IEntityTypeConfiguration<ChiTietSp>
    {
        public void Configure(EntityTypeBuilder<ChiTietSp> builder)
        {
            builder.ToTable("ChiTietSP"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.HasKey(x => x.Id); // Set khóa chính
            // Cấu hình dữ liệu
            builder.Property(p => p.SoLuong).HasColumnName("SoLuong").
                HasColumnType("int").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.DonGiaNhap).HasColumnName("GiaNhap").
                HasColumnType("double").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.DonGiaBan).HasColumnName("GiaBan").
                HasColumnType("double").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.TrangThai).HasColumnName("TrangThai").
               HasColumnType("int").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.MoTa).HasColumnName("Mota").
               HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.Mavach).HasColumnName("Mota").
              HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
            builder.Property(k => k.IdDongSP).IsRequired();
            builder.Property(k => k.IdSp).IsRequired();
            builder.Property(k => k.IdNsx).IsRequired();
            builder.Property(k => k.IdchatLieu).IsRequired();
            builder.Property(k => k.IdSize).IsRequired();
            builder.Property(k => k.IdMauSac).IsRequired();
            //set khoa phu
            builder.HasOne(x => x.NSX)
            .WithMany().HasForeignKey(p => p.IdNsx);
            builder.HasOne(x => x.SanPham)
            .WithMany().HasForeignKey(p => p.IdSp);
            builder.HasOne(x => x.DongSp)
            .WithMany().HasForeignKey(p => p.IdDongSP);
            builder.HasOne(x => x.ChatLieu)
            .WithMany().HasForeignKey(p => p.IdchatLieu);
            builder.HasOne(x => x.MauSac)
            .WithMany().HasForeignKey(p => p.IdMauSac);
            builder.HasOne(x => x.Size)
           .WithMany().HasForeignKey(p => p.IdSize);
        }
    }
}
