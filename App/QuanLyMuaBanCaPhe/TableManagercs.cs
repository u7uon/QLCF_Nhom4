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
        public TableManagercs()
        {
            InitializeComponent();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thông_tin_cá_nhân T = new Thông_tin_cá_nhân();
            T.ShowDialog();
        }

        private void quảnLýNhapKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlynhapkho nk = new Quanlynhapkho();
            nk.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order order = new order();
            order.ShowDialog();
        }

        private void xemDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDoanhThu doanhThu = new XemDoanhThu();
            doanhThu.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlynhanvien nv = new Quanlynhanvien();
            nv.ShowDialog();
        }

        private void quảnLýMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyMenu menu = new QuanLyMenu();
            menu.ShowDialog();
        }

        private void TableManagercs_Load(object sender, EventArgs e)
        {

        }
    }
}
