using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PL.ViewModel
{
    public class AnhView
    {
        public Guid? Id { get; set; }
       
        public string? Ma { get; set; }
        
        public string? Ten { get; set; }
       
        public string? DuongDan { get; set; }
        public int? TrangThai { get; set; }
    }
}
