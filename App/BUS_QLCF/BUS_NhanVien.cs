using DAL_QLCF;
using DTO_QLCF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLCF
{
    public class BUS_NhanVien
    {
        private DAL_NhanVien dal_nv = new DAL_NhanVien();


        //Tạo một chuỗi Salt ngẫu nhiên khi tạo mk hoặc thay đổi mật khẩu
        private static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16]; // Độ dài salt là 16 bytes
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        // Hàm băm mật khẩu với salt sử dụng SHA-256
        private static string HashPassword(string password, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);

            // Kết hợp mật khẩu với salt
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] combinedBytes = new byte[passwordBytes.Length + saltBytes.Length];
            Array.Copy(passwordBytes, 0, combinedBytes, 0, passwordBytes.Length);
            Array.Copy(saltBytes, 0, combinedBytes, passwordBytes.Length, saltBytes.Length);

            // Sử dụng SHA-256 để băm
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(combinedBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        public bool Login(string username, string password)
        {
            string salt = dal_nv.getSalt(username);
            return dal_nv.Login(username, HashPassword(password, salt));
        }
        public bool GetVaiTro(string email)
        {
            return dal_nv.getVaiTro(email);
        }
        public bool DoiMatKhau(string email, string oldPass, string newPass)
        {
            string Salt = dal_nv.getSalt(email);
            string newSalt = GenerateSalt();
            return dal_nv.DoiMatKhau(email, HashPassword(oldPass, Salt), HashPassword(newPass, newSalt), newSalt );
        }


        public bool SetNewPass(string email, string newPass)
        {
            string Salt = GenerateSalt();
            return dal_nv.setNewPass(email, HashPassword(newPass, Salt) , Salt);
        }
        public bool IsExistsEmail(string email)
        {
            return dal_nv.IsExistsEmail(email);
        }
        public bool insert_nv(DTO_NhanVien nv)
        {
            return dal_nv.insert_nv(nv);
        }
        public bool Insert_TK (string email , string pass)
        {
            string salt = GenerateSalt();
            return dal_nv.Insert_TK(email, HashPassword(pass , salt) , salt) ; 
        }
        public DataTable Load_NV()
        {
            return dal_nv.Load_NV();
        }
    }
}
