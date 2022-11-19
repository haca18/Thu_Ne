using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PL.ViewModel
{
    public class ChiTIetSpView
    {
        public Guid? Id { get; set; }
        
        public int? SoLuong { get; set; }
        public string? Mavach { get; set; }
        public double? DonGiaNhap { get; set; }
        public double? DonGiaBan { get; set; }
        public int? TrangThai { get; set; }
        public string? MoTa { get; set; }

        public Guid? IdchatLieu { get; set; }

        public Guid? IdNsx { get; set; }

        public Guid? IdDongSP { get; set; }

        public Guid? IdMauSac { get; set; }

        public Guid? IdSp { get; set; }
        public Guid? IdSize { get; set; }
    }
}
