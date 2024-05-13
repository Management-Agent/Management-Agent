using QuanLyDaiLy.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public bool login(string username, string password)
        {
            return LoginAccount.Instance.login(username, password);
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;
            if(login(username, password))
            {
                this.Hide();
                DanhSachDaiLy danhSachDaiLy = new DanhSachDaiLy();
                danhSachDaiLy.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!");
            }
        }
    }
}
