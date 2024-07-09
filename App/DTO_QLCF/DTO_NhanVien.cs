using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLCF
{
    public class DTO_NhanVien
    {
        private string Email;
        private string TenNV;
        private int VaiTro;
        private string GioiTinh;
        private string soDienThoai;
        private string DiaChi;
        private double Luong;
        private string Password;

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string tenNV
        {
            get { return TenNV; }
            set { TenNV = value; }
        }
        public int vaiTro
        {
            get { return VaiTro; }
            set { VaiTro = value; }
        }
        public string gioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        public string SoDT
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        public string diaChi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        public double luong
        {
            get { return Luong; }
            set { Luong = value; }
        }
        public string password {
            get { return Password; } 
            set { Password = value; }
        }

        public DTO_NhanVien(string email, string tenNV, int vaiTro, string gioiTinh, string soDienThoai, string diaChi, double luong, string password )
        {
           this.Email = email;
            this.TenNV = tenNV;
            this.VaiTro = vaiTro;
            this.GioiTinh=gioiTinh;
            this.soDienThoai= soDienThoai;
            this.DiaChi= diaChi;
            this.Luong= luong;
            this.Password= password;
        }
    }
}
