using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChiTietSpServices
    {
        string ADD(ChiTIetSpView obj);
        string UPDATE(ChiTIetSpView obj);
        string DELETE(ChiTIetSpView obj);
        List<ChiTIetSpView> GetAll();
    }
}
