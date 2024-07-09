using BUS_QLCF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaBanCaPhe
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        private bool isBlank()
        {
            return txtDangNhap.Text == "" || txtMatKhau.Text == "" || txtNewpassword.Text == "" || textBox1.Text == "";
        }
        public bool isSuccess = false;
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (isBlank())
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                return;
            }

            if (!txtNewpassword.Text.Equals(textBox1.Text))
            {
                MessageBox.Show("Khẩu mới và mật khẩu xác nhận không trùng nhau");
                return;
            }

            if (bus_nv.DoiMatKhau(txtDangNhap.Text, txtMatKhau.Text, txtNewpassword.Text))
            {
                MessageBox.Show("Đổi mật khẩu thành công, Vui lòng đăng nhập lại ");
                this.isSuccess = true;
                this.Close();
            }
            else
                MessageBox.Show("Đổi mật khẩu thất bại , vui lòng kiểm tra thông tin"); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
