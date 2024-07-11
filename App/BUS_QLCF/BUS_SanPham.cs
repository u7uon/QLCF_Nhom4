using DAL_QLCF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLCF
{
    public class BUS_SanPham
    {
        private DAL_SanPham dal_sp = new DAL_SanPham();
        public DataTable Load_Menu()
        {
            return dal_sp.Load_Menu();
        }
    }
}
