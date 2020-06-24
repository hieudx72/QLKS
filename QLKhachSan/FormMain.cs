using QLKhachSan.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLKhachSan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            MainDao md = new MainDao();
            lblTenDN.Text = FormLogin.tenDN;
            lblSPT.Text = md.loadSPT().ToString();
            lblSPDD.Text = md.loadSPDD().ToString();
            lblSPDT.Text = md.loadSPDT().ToString();
            loadImage();
        }

        public void loadImage()
        {
            DataTable dt = new MainDao().DSP();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["MaPhong"].ToString();
                if (row["TinhTrang"].ToString().Equals("Trong"))
                {
                    item.ImageIndex = 0;
                }
                if (row["TinhTrang"].ToString().Equals("Da dat"))
                {
                    item.ImageIndex = 1;
                }
                if (row["TinhTrang"].ToString().Equals("Da thue"))
                {
                    item.ImageIndex = 2;
                }
                lvPhong.Items.Add(item);
            }
        }
        private void mnDoiMatKhau_Click(object sender, EventArgs e)
        {
            new FormDoiMatKhau().Show();
        }
     
        private void mnDatPhong_Click(object sender, EventArgs e)
        {
            new FormDatPhong().Show();
        }

        private void mnThuePhong_Click(object sender, EventArgs e)
        {
            new FormThuePhong().Show();
        }

        private void mnPhong_Click(object sender, EventArgs e)
        {
            if (FormLogin.quyen.Equals("admin"))
            {
                new FormPhong().Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa đủ quyền để thao tác !");
            }
        }

        private void mnThietBiPhong_Click(object sender, EventArgs e)
        {
            if (FormLogin.quyen.Equals("admin"))
            {
                new FormThietBiPhong().Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa đủ quyền để thao tác !");
            }
        }

        private void mnDichVu_Click(object sender, EventArgs e)
        {
            if (FormLogin.quyen.Equals("admin"))
            {
                new FormDichVu().Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa đủ quyền để thao tác !");
            }
        }

        private void mnNhanVien_Click(object sender, EventArgs e)
        {
            if (FormLogin.quyen.Equals("admin"))
            {
                new FormNhanVien().Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa đủ quyền để thao tác !");
            }
        }

        private void mnThongTin_Click(object sender, EventArgs e)
        {
            new FormThongTin().Show();
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show();
        }

        private void mnKhachHang_Click(object sender, EventArgs e)
        {
            new FormKhachHang().Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormMain().Show();
        }
    }
}
