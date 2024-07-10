using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLCF;

namespace QuanLyMuaBanCaPhe
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        int countdown ; 
        private string rdCode; 
        private BUS_NhanVien bus_nv = new BUS_NhanVien();
        private string RandomCode()
        {
            Random rd = new Random();
            return rd.Next(11111, 99999).ToString();
        }

        public void SendMail(string mail, string verifiCode)//Gửi mail code xác nhận đổi mk về mail
        {
            try
            {

                MailMessage msg = new MailMessage();
                msg.To.Add(mail);
                msg.From = new MailAddress("duongvpd10563@gmail.com");
                msg.Subject = "Mã xác nhận đổi mật khẩu";
                msg.Body = "Mã xác nhận của bạn : " + verifiCode;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential("duongnvpd10563@gmail.com", "jipazvuqvjhktwxi");
                smtp.Send(msg);

                MessageBox.Show("Mã xác nhận đã được gửi ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool checkNull()
        {
            return txtConfirm.Text == "" || txtEmail.Text == "" || txtConfirm.Text == "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập email");
                return;
            }

            if (!bus_nv.IsExistsEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không tồn tại , vui lòng nhập lại");
                return;
            }
            
            //Gửi mã xác nhận về mail
            rdCode = RandomCode();
            SendMail(txtEmail.Text, rdCode);

            //Đếm ngược 30s để gửi mã khác
            countdown = 30;
            timer1.Start();
            button1.Enabled = false;
            button1.Text = $"Gửi lại mã sau {countdown}s";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if(!rdCode.Equals(txtVerifiCode.Text))
            {
                MessageBox.Show("Mã xác nhận sai , vui lòng kiểm tra");
                return;
            }

            if (!txtNewPass.Text.Equals(txtConfirm.Text))
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp"); 
                return;
            }

            if(bus_nv.SetNewPass(txtEmail.Text, txtNewPass.Text))
            {
                MessageBox.Show("Đã cập nhật mật khẩu mới , vui lòng đăng nhập lại"); 
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại , vui lòng thử lại sau");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            rdCode = ""; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown--;

            if (countdown > 0)
            {
                button1.Text = $"Gửi lại mã sau {countdown}s";
            }
            else
            {
                timer1.Stop();
                button1.Enabled = true;
                button1.Text = "Gửi mã xác nhận";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtNewPass.PasswordChar = '\0';
                txtConfirm.PasswordChar = '\0';
            }
            else
            {
                txtNewPass.PasswordChar = '*'; 
                txtConfirm.PasswordChar = '*';
            }
        }
    }
}
