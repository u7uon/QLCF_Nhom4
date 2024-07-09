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
    public partial class TableManagercs : Form
    {
        public TableManagercs(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        private BUS_NhanVien bus_nv = new BUS_NhanVien();

        private string email;
        public bool isAdmin;
 


        private void LoggedIn(bool status)
        {
            if (status)
            {
                menuStripAdmin.Visible = isAdmin;
            }
            else 
            {
                Login frmLogin = new Login();
                frmLogin.Show();
                this.Close();
            }
        }
        void ChangeForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            form.Show();
        }
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
            if (frm.isSuccess)
            {
                frm.Close();
                LoggedIn(false);
            }
        }

        private void quảnLýNhapKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new frmQLKho());
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmOrder());
        }

        private void xemDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new frmThongke());
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new frmQLNV());
        }

        private void quảnLýMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new frmQlMenu());
        }

        private void TableManagercs_Load(object sender, EventArgs e)
        {
            LoggedIn(true);
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggedIn(false);
        }
    }
}
