using BUS_QLCF;
using DTO_QLCF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaBanCaPhe
{
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();
        }
        private BUS_NhanVien bus_nv = new BUS_NhanVien();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char cha;
            for (int i = 0; i < size; i++)
            {
                cha = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(cha);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public int RandomNumber(int min, int max)
        {
            Random rd = new Random();
            return rd.Next(min, max);
        }
        public void SendMail(string mail, string randompass)//Gửi mail code xác nhận đổi mk về mail
        {
            try
            {

                MailMessage msg = new MailMessage();
                msg.To.Add(mail);
                msg.From = new MailAddress("duongvpd10563@gmail.com");
                msg.Subject = "Bạn vừa tạo tài khoản đây là mật khẩu đăng nhập :";
                msg.Body = "Mật khẩu : " + randompass;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential("duongnvpd10563@gmail.com", "jipazvuqvjhktwxi");
                smtp.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkNull()
        {
            return string.IsNullOrEmpty(txtTenNV.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtCCCD.Text) ||
                string.IsNullOrEmpty(txtDienThoai.Text) ||
                (!rdoNam.Checked && !rdoNu.Checked);

        }
        private bool ValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                MessageBox.Show("Kiểm tra nhập liệu ");
                return;
            }

            if (!ValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Mail sai định dạng");
                return;
            }

            if (bus_nv.IsExistsEmail(txtEmail.Text))
            {
                MessageBox.Show("Mail đã tồn tại");
                return;
            }

            DTO_NhanVien NV = new DTO_NhanVien()
            {
                tenNV = txtTenNV.Text,
                email = txtEmail.Text,
                cccd = txtCCCD.Text,
                gioiTinh = rdoNam.Checked ? "Nam" : "Nữ" , 
                vaiTro = rdoQL.Checked ? 1 : 0 ,
                diaChi = rtxtDiaChi.Text ,
                SoDT = txtDienThoai.Text, 
                ngaySinh = dtpBirth.Value,
            };

            if(bus_nv.insert_nv(NV) )
            {
                MessageBox.Show("Thêm nhân viên thành công , truy cập gmail để nhận mật khẩu đăng nhập");
                StringBuilder sb = new StringBuilder();
                sb.Append(RandomString(2, true));
                sb.Append(RandomNumber(0, 9)); 
                sb.Append(RandomString(3,false));
                sb.Append(RandomNumber(11,99));

                SendMail(NV.email, sb.ToString())  ;
                bus_nv.Insert_TK(NV.email , sb.ToString()) ;
            }
    }
}
}
