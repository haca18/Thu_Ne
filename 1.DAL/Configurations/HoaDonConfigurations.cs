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
    internal interface HoaDonConfigurations: IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.HasKey(x => x.IdhoaDon); // Set khóa chính
            // Cấu hình dữ liệu           
            builder.Property(p => p.MaHoaDon).HasColumnName("Ma").
                HasColumnType("varchar(30)").IsRequired(); // varchar(30) not null
            builder.Property(p => p.TrangThai).HasColumnName("TrangThai").
                HasColumnType("int"); // varchar(100) not null
            builder.Property(p => p.NgayLap).HasColumnName("NgayLap").
                HasColumnType("dateTime"); // varchar(100) not null
            builder.Property(p => p.NgayThanhToan).HasColumnName("NgayThanhToan").
                HasColumnType("dateTime"); // varchar(100) not null
            builder.Property(p => p.NgayShipHang).HasColumnName("NgayShip").
                HasColumnType("dateTime"); // varchar(100) not null
            builder.Property(p => p.NgayNhanHang).HasColumnName("NgayNhan").
                HasColumnType("dateTime"); // varchar(100) not null
            builder.Property(p => p.NguoiBan).HasColumnName("NguoiBan").
                HasColumnType("dateTime"); // varchar(100) not null
            builder.Property(p => p.Sdt).HasColumnName("SdtKhach").
                HasColumnType("dateTime"); // varchar(100) not null
            builder.Property(k => k.IdNhanVien).IsRequired();
            //khoa phu
            builder.HasOne(x => x.KhachHang)
            .WithMany().HasForeignKey(p => p.Sdt);
            builder.HasOne(x => x.NhanVien)
            .WithMany().HasForeignKey(p => p.IdNhanVien);

        }
    }
}
