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
        public static string quyen;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            LoginDao login = new LoginDao();
            bool c = login.check(txtTenDN.Text, txtMatKhau.Text);
            if(c == true)
            {
                this.Hide();           
                tenDN = txtTenDN.Text;
                matKhau = txtMatKhau.Text;
                new FormMain().Show();

                DataTable dt = login.quyen(tenDN);
                DataRow dr = dt.Rows[0];
                int d = Int32.Parse(dr["idChucVu"].ToString());
                if(d == 1)
                {
                    quyen = "admin";
                }
                else
                {
                    quyen = "nhanvien";
                }
              
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !");
            }

        }
       
    }
}
