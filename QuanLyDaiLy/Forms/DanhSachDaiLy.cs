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
        }


        private void bindingDaiLy()
        {
            TenDaiLyBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "TenDaiLy"));
            SDTBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "DienThoai"));
            LoaiDaiLyBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "TenLoaiDaiLy"));
            TenQuanBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "TenQuan"));
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
    }
}
