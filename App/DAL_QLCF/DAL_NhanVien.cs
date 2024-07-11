using DTO_QLCF;
using System;
using System.Collections.Generic;
using System.Data;
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

        public string getSalt(string email)
        {
            try
            {
                conn_.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn_;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "getSalt";
                    cmd.Parameters.AddWithValue("@Email", email);

                    return Convert.ToString(cmd.ExecuteScalar());
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn_.Close();
            }
            return null;
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
                if (Convert.ToInt16(cmd.ExecuteScalar()) == 1)
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
        public bool DoiMatKhau(string email, string oldPass, string newPass , string Salt)
        {
            try
            {
                conn_.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    ;
                    cmd.Connection = conn_;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "DoiMatKhau";
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@MatKhauCu", oldPass);
                    cmd.Parameters.AddWithValue("@MatKhauMoi", newPass);
                    cmd.Parameters.AddWithValue("@Salt", Salt);
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        return true;
                    }
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                conn_.Close();
            }
            return false;
        }
        public bool setNewPass(string email, string newPass , string Salt)
        {
            try
            {
                conn_.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn_;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "setNewPass";
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", newPass);
                    cmd.Parameters.AddWithValue("@salt", Salt);
                    
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }

                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn_.Close();
            }
            return false;
        }
        public bool IsExistsEmail(string email)
        {
            try
            {
                conn_.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn_;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "checkEmail";
                    cmd.Parameters.AddWithValue("@email", email);

                    ;
                    if (Convert.ToInt16(cmd.ExecuteScalar()) == 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn_.Close();
            }
            return false;
        }
        public bool insert_nv(DTO_NhanVien nv)
        {
            try
            {
                conn_.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn_;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "insert_NhanVien";
                    cmd.Parameters.AddWithValue("@Email", nv.email);
                    cmd.Parameters.AddWithValue("@TenNV", nv.tenNV);
                    cmd.Parameters.AddWithValue("@SoDienThoai", nv.SoDT);
                    cmd.Parameters.AddWithValue("@DiaChi", nv.diaChi);
                    cmd.Parameters.AddWithValue("@GioiTinh", nv.gioiTinh);
                    cmd.Parameters.AddWithValue("@CCCD", nv.cccd);
                    cmd.Parameters.AddWithValue("@NgaySinh", nv.ngaySinh);
                    cmd.Parameters.AddWithValue("@VaiTro", nv.vaiTro);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn_.Close();
            }
            return false;
        }

        public bool Insert_TK(string email , string hashedPass , string salt)
        {
            try
            {
                conn_.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn_;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "inset_TK";
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@HashedPass", hashedPass);
                    cmd.Parameters.AddWithValue("@Salt", salt);
                   

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn_.Close();
            }
            return false;
        }
        public DataTable Load_NV()
        {
            try
            {
                conn_.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn_;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "DanhSachNV";
                    
                    DataTable data = new DataTable();
                    data.Load(cmd.ExecuteReader()); 

                   return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn_.Close();
            }
            return null;
        }
    }
}
