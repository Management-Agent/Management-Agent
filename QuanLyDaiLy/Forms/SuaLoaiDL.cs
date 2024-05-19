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
    public partial class SuaLoaiDL : Form
    {
        public SuaLoaiDL()
        {
            InitializeComponent();
            string queryString = "exec datagridview_loaidaily";
            DataTable data = DataProvider.Instance.ExecuteQuery(queryString);
            dataGridViewLoaiDaiLy.DataSource = data;
        }

      

        
        private void txtHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_data(string maLoai)
        {
            string queryString = "exec Search_LoaiDaiLy @MaLoaiDaiLy";
            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new object[] { maLoai });
           dataGridViewLoaiDaiLy.DataSource = data;
        }

        private void LuuLoaiDaiLy_Click(object sender, EventArgs e) 
        {
            
            if (!string.IsNullOrWhiteSpace(txtTenLoaiDaiLy.Text))
            {
                string queryString = "exec Update_LoaiDaiLy_Ten @MaLoaiDaiLy , @TenLoaiDaiLy";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { txtMaLoaiDaiLy.Text, txtTenLoaiDaiLy.Text });
            }
            if (!string.IsNullOrWhiteSpace(txtSoNoToiDa.Text))
            {
                string queryString = "exec Update_LoaiDaiLy_SoNoToiDa @MaLoaiDaiLy , @SoNoToiDa";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { txtMaLoaiDaiLy.Text, txtSoNoToiDa.Text });
            }

            search_data(txtMaLoaiDaiLy.Text);
        }
       
    

        private void SuaLoaiDL_Load(object sender, EventArgs e)
        {
            if (txtMaLoaiDaiLy.Text == "")
            {
                string queryString = "exec datagridview_loaidaily";
                DataTable data = DataProvider.Instance.ExecuteQuery(queryString);
                dataGridViewLoaiDaiLy.DataSource = data;
            }
        }

        private void txtHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSoNoToiDa.Text) && !string.IsNullOrWhiteSpace(txtMaLoaiDaiLy.Text) && !string.IsNullOrWhiteSpace(txtTenLoaiDaiLy.Text))
            {
                string queryString = "exec Insert_LoaiDaiLy @MaLoaiDaiLy , @TenLoaiDaiLy , @SoNoToiDa";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { txtMaLoaiDaiLy.Text, txtTenLoaiDaiLy.Text, txtSoNoToiDa.Text });
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ dữ liệu");
            }
            search_data(txtMaLoaiDaiLy.Text);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaLoaiDaiLy.Text))
            {
                string queryString = "exec Delete_LoaiDaiLy @MaLoaiDaiLy";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { txtMaLoaiDaiLy.Text});
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ dữ liệu");
            }
            search_data(txtMaLoaiDaiLy.Text);
        }

        private void LuuLoaiDaiLy_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTenLoaiDaiLy.Text))
            {
                string queryString = "exec Update_LoaiDaiLy_Ten @MaLoaiDaiLy , @TenLoaiDaiLy";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { txtMaLoaiDaiLy.Text, txtTenLoaiDaiLy.Text });
            }
            if (!string.IsNullOrWhiteSpace(txtSoNoToiDa.Text))
            {
                string queryString = "exec Update_LoaiDaiLy_SoNoToiDa @MaLoaiDaiLy , @SoNoToiDa";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { txtMaLoaiDaiLy.Text, txtSoNoToiDa.Text });
            }

            search_data(txtMaLoaiDaiLy.Text);
        }
    }
}
