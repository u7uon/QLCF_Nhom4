using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace DAL_QLCF
{
    public class DBConnect
    {
        public SqlConnection conn_ = new SqlConnection ("Data Source=LAPTOP-H769HCI6;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False"); 
        
    }
}
