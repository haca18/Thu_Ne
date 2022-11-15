using _1.DAL.Configurations;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Context
{
    public class BanGiayDBContext:DbContext
    {
        public BanGiayDBContext()
        {

        }
        public BanGiayDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Thực hiện các ràng buộc kết nối
            base.OnConfiguring(optionsBuilder.
                UseSqlServer("Data Source=DESKTOP-OJ4UDNH\\SQLEXPRESS;Initial Catalog=DuanMau_Giay;" +
                "Persist Security Info=True;User ID=Nbton03;Password=123"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SanPhamConfigurations());
            // Apply cac config cho cac model
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Phương thức này sẽ áp dụng tất cả các config hiện có
        }
    }
}
