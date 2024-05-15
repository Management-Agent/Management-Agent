using Dapper;
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


namespace QuanLyDaiLy
{
    public partial class DanhSachDaiLy : Form
    {
        public DanhSachDaiLy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(NewDaiLy newDaiLy = new NewDaiLy())
            {
                newDaiLy.ShowDialog();
            }
        }

        private void DanhSachDaiLy_Load(object sender, EventArgs e)
        {
            //load data
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetDaiLyInfo");
            dataGridViewDaiLy.DataSource = data;
            bindingDaiLy();
            showElementInLoaiDaiLy();
            showElementInQuan();
        }


        private void bindingDaiLy()
        {
            TenDaiLyBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "TenDaiLy"));
            SDTBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "DienThoai"));
            LoaiDaiLyComboBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "TenLoaiDaiLy"));
            TenQuanComboBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "TenQuan"));
            TienNoBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "TongNo"));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewDaiLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show((dataGridViewDaiLy.SelectedColumns.Count).ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void showElementInLoaiDaiLy()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetAllTenLoaiDaiLy");
            LoaiDaiLyComboBox.DataSource = data;
            LoaiDaiLyComboBox.DisplayMember = "TenLoaiDaiLy";
        }
        private void showElementInQuan()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetAllTenQuan");
            TenQuanComboBox.DataSource = data;
            TenQuanComboBox.DisplayMember = "TenQuan";
        }
    }
}
