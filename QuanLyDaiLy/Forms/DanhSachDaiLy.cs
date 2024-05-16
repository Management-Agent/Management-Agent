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
        BindingSource listDaiLy = new BindingSource();

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
            dataGridViewDaiLy.DataSource = listDaiLy;
            RefreshButton_Click(sender, e);
            bindingDaiLy();
            showElementInLoaiDaiLy();
            showElementInQuan();

        }

        private void bindingDaiLy()
        {
            TenDaiLyBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "TenDaiLy", true, DataSourceUpdateMode.Never));
            SDTBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "DienThoai", true, DataSourceUpdateMode.Never));
            LoaiDaiLyComboBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "LoaiDaiLy", true, DataSourceUpdateMode.Never));
            TenQuanComboBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "Quan", true, DataSourceUpdateMode.Never));
            EmailBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "Email", true, DataSourceUpdateMode.Never));
            DiaChiBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            TienNoBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "TongNo", true, DataSourceUpdateMode.Never));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewDaiLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FindBox.Text);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            listDaiLy.DataSource = getListDaiLy();
        }

        private List<DaiLy> getListDaiLy()
        {
            List<DaiLy> list = new List<DaiLy>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetDaiLyInfo");
            foreach (DataRow item in data.Rows)
            {
                DaiLy daiLy = new DaiLy(item);
                list.Add(daiLy);
            }
            return list;
        }

        private List<DaiLy> getListDaiLyBySDT(string DienThoai)
        {
            List<DaiLy> list = new List<DaiLy>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_FindDaiLy @DienThoai", new object[] { DienThoai});
            foreach (DataRow item in data.Rows)
            {
                DaiLy daiLy = new DaiLy(item);
                list.Add(daiLy);
            }
            return list;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                listDaiLy.DataSource = getListDaiLyBySDT(FindBox.Text);
            }
            catch 
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }
    }
}
