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
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            
            InitializeComponent();
        }
        BUS_SanPham bus_sp = new BUS_SanPham();
        private void CreateControls(DataTable dataTable)
        {
            Panel panel = new Panel();
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);

            int x = 10;
            int y = 10;
            int width = 220 ;
            int height = 110 ;
            int margin = 10;
            int itemsPerRow = 3; // Số lượng items trên mỗi hàng

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];

                Panel itemPanel = new Panel();
                itemPanel.BorderStyle = BorderStyle.FixedSingle;
                itemPanel.SetBounds(x, y, width, height);
                itemPanel.Click += new EventHandler(ItemPanel_Click);

                Label nameLabel = new Label();
                nameLabel.Text = "Mã Sp: " + row["MaSanPham"].ToString();
                nameLabel.AutoSize = true;
                nameLabel.Location = new Point(10, 10);

                Label TenSP = new Label();
                TenSP.Text = "Tên: " + row["TenSanPham"].ToString();
                TenSP.AutoSize = true;
                TenSP.Location = new Point(10, 40);

                Label priceLabel = new Label();
                priceLabel.Text = "Price: " + row["Gia"].ToString();
                priceLabel.AutoSize = true;
                priceLabel.Location = new Point(10, 70);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 100); // Đặt lại kích thước của PictureBox
                pictureBox.Location = new Point(100, 5); // Đặt vị trí của PictureBox
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Click += new EventHandler(PictureBox_Click);

                string imagePath = row["HinhAnh"].ToString();
                string currentDirectory = Application.StartupPath;
                Console.WriteLine("Đường dẫn thư mục hiện tại của ứng dụng: " + currentDirectory);
                if (!string.IsNullOrEmpty(imagePath))
                {
                    pictureBox.Image = Image.FromFile(currentDirectory+@"\" + imagePath);
                }

                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(TenSP);
                itemPanel.Controls.Add(priceLabel);
                itemPanel.Controls.Add(pictureBox);

                panel3.Controls.Add(itemPanel);

                // Tính toán vị trí cho Panel tiếp theo
                if ((i + 1) % itemsPerRow == 0) // Nếu đạt số lượng items trên mỗi hàng
                {
                    x = 10; // Trở về xấu đầu dòng
                    y += height + margin; // Xuống hàng mới
                }
                else
                {
                    x += width + margin; // Tiếp tục xếp vào hàng hiện tại
                }
            }
        }
        private void ItemPanel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            MessageBox.Show("Panel clicked: " + clickedPanel.Controls[0].Text);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            Panel parentPanel = clickedPictureBox.Parent as Panel;
            MessageBox.Show("PictureBox clicked: " + parentPanel.Controls[0].Text);
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightGray;
            panel3.AutoScroll = true;
           // panel3.Dock = DockStyle.Fill;//
            CreateControls(bus_sp.Load_Menu());
        }
    }
}
