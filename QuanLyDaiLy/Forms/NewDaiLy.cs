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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyDaiLy
{
    public partial class NewDaiLy : Form
    {
        public NewDaiLy()
        {
            InitializeComponent();
            showElementInLoaiDaiLy();
            showElementInQuan();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string theDate = NgayTiepNhanBox.Value.ToString("yyyy-MM-dd");
            string queryString = "exec Insert_DaiLy @TenDaiLy , @MaLoaiDaiLy , @DienThoai , @DiaChi , @Email , @MaQuan , @NgayTiepNhan , @TongNo ";
            int test = DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { TenDaiLyBox.Text, LoaiDaiLyBox.Text, DienThoaiBox.Text, DiaChiBox.Text, EmailBox.Text, QuanBox.Text, theDate, 0 });
            if (test != 0) MessageBox.Show("Them thanh cong.");
            else MessageBox.Show("Them khong thanh cong.");
        }

        private void LoaiDaiLyBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void showElementInLoaiDaiLy()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetLoaiDaiLy");
            LoaiDaiLyBox.DataSource = data;
            LoaiDaiLyBox.DisplayMember = "MaLoaiDaiLy";
        }
        private void showElementInQuan()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetMaQuan");
            QuanBox.DataSource = data;
            QuanBox.DisplayMember = "MaQuan";
        }

        private void NewDaiLy_Load(object sender, EventArgs e)
        {

        }
    }
}
