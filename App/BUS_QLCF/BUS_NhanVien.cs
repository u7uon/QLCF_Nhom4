using DAL_QLCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLCF
{
    public class BUS_NhanVien
    {
        private DAL_NhanVien dal_nv = new DAL_NhanVien();
        public bool Login(string username, string password)
        {
            return dal_nv.Login(username, password);
        }
        public bool GetVaiTro(string email)
        {
            return dal_nv.getVaiTro(email);
        }
        public bool DoiMatKhau(string email, string oldPass, string newPass)
        {
            return dal_nv.DoiMatKhau(email, oldPass, newPass);
        }
    }
}
