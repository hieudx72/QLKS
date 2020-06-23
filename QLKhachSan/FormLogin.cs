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
    public partial class FormLogin : Form
    {
        public static string tenDN;
        public static string matKhau;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool c = new LoginDao().check(txtTenDN.Text, txtMatKhau.Text);
            if(c == true)
            {
                this.Hide();           
                tenDN = txtTenDN.Text;
                matKhau = txtMatKhau.Text;
                new FormMain().Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !");
            }

        }
       
    }
}
