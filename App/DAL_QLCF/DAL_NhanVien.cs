using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLCF
{
    public class DAL_NhanVien : DBConnect
    {
        public bool Login(string email, string password)
        {
            try
            {
                conn_.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn_;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@MatKhau", password);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    return true;
                }
            }
            catch
            {
            }
            finally
            {
                conn_.Close();
            }
            return false;
        }
        public bool getVaiTro(string email)
        {
            try
            {
                conn_.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn_;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "LayVaiTro";
                cmd.Parameters.AddWithValue("@Email", email);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn_.Close();
            }
            return false;
        }
        public bool DoiMatKhau(string email , string oldPass , string newPass)
        {
            try
            {
                conn_.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn_;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "DoiMatKhau";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@MatKhauCu", oldPass);
                cmd.Parameters.AddWithValue("@MatKhauMoi", newPass);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn_.Close();
            }
            return false;
        }
    }
}
