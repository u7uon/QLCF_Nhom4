using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLCF
{
    public  class DAL_SanPham :DBConnect
    {
        public DataTable Load_Menu()
        {
            try
            {
                conn_.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn_;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "Load_SP";

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
