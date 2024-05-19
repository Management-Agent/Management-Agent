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
    public partial class SuaQuan : Form
    {
        public SuaQuan()
        {
            InitializeComponent();
            string queryString = "exec datagridview_Quan";
            DataTable data = DataProvider.Instance.ExecuteQuery(queryString);
            dataGridViewQuan.DataSource = data;
        }


        private void load_Quan()
        {
            string queryString = "exec load_Quan";
            DataTable data = DataProvider.Instance.ExecuteQuery(queryString);
            dataGridViewQuan.DataSource = data;
        }
        private void lbMaQuan_Click(object sender, EventArgs e)
        {

        }

        private void txtHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LuuQuan_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtTenQuan.Text))
            {
                string queryString = "exec Update_TenQuan @MaQuan , @TenQuan";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { txtMaQuan.Text, txtTenQuan.Text });
            }

            load_Quan();
        }

        private void SuaQuan_Load(object sender, EventArgs e)
        {
            if (txtMaQuan.Text == "")
            {
                string queryString = "exec datagridview_Quan";
                DataTable data = DataProvider.Instance.ExecuteQuery(queryString);
                dataGridViewQuan.DataSource = data;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTenQuan.Text) && !string.IsNullOrWhiteSpace(txtMaQuan.Text))
            {
                string queryString = "exec Insert_TenQuan @MaQuan , @TenQuan";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { txtMaQuan.Text, txtTenQuan.Text });
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ dữ liệu");
            }
            load_Quan();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaQuan.Text))
            {
                string queryString = "exec Delete_Quan @MaQuan";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { txtMaQuan.Text });
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ dữ liệu");
            }
            load_Quan();
        }
    }
}
