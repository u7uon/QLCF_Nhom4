using BUS_QLCF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaBanCaPhe
{
    public partial class Login : Form
    {

        //testatsdfyatsfd
        public Login()
        {
            InitializeComponent();
        }
        private BUS_NhanVien bus_nv = new BUS_NhanVien();

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
 

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin ");
                return;
            }

            if (bus_nv.Login(txtTenDangNhap.Text, txtMatKhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                TableManagercs frmMain = new TableManagercs(txtTenDangNhap.Text);
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu , vui lòng thử lại");
                txtMatKhau.Clear();
                txtTenDangNhap.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(QuenMatKhau f = new QuenMatKhau())
            {
                f.ShowDialog();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
                
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
              
            }
        }
    }
}
