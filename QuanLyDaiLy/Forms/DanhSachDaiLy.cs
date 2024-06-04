
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
            MaDaiLyBox.DataBindings.Add(new Binding("text", dataGridViewDaiLy.DataSource, "MaDaiLy", true, DataSourceUpdateMode.Never));
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
            try
            {
                DataProvider.Instance.ExecuteNonQuery("exec Delete_DAILY @MaDaiLy", new object[] { MaDaiLyBox.Text });
                MessageBox.Show("Xóa thành công!");
                refreshList();
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void showElementInLoaiDaiLy()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetLoaiDaiLy");
            LoaiDaiLyComboBox.DataSource = data;
            LoaiDaiLyComboBox.DisplayMember = "MaLoaiDaiLy";
        }
        private void showElementInQuan()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetMaQuan");
            TenQuanComboBox.DataSource = data;
            TenQuanComboBox.DisplayMember = "MaQuan";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void refreshList()
        {
            listDaiLy.DataSource = getListDaiLy();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            refreshList();
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

        private List<DaiLy> getListDaiLyBySDT(string TenDaiLy)
        {
            List<DaiLy> list = new List<DaiLy>();
            string query = string.Format("SELECT * FROM DAILY where dbo.fuConvertToUnsign1(TenDaiLy) like N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", TenDaiLy);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
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

        private void modifyButton_Click(object sender, EventArgs e)
        {
            DataTable subData = DataProvider.Instance.ExecuteQuery("exec USP_GetDaiLyInfoThroughMaQuan @MaQuan", new object[] { TenQuanComboBox.Text });
            string[] arrayTenDaiLy;
            if(subData.Rows.Count != 0)
            {
                arrayTenDaiLy = subData.AsEnumerable()
                .Select(row => row.Field<string>("TenDaiLy"))
                .ToArray();
                string query = @"Select GiaTri from THAMSO where TenThamSo = 'SoDaiLyToiDa'";
                int SoDaiLyToiDa = (int)DataProvider.Instance.ExecuteScalar(query);

                if (arrayTenDaiLy.Length >= SoDaiLyToiDa)
                {
                    MessageBox.Show("Số đại lý trong quận này đã đạt tối đa!");
                    return;
                }

                foreach (string name in arrayTenDaiLy)
                {
                    if (name == "Undefine")
                    { continue; }
                    if (name == TenDaiLyBox.Text)
                    {
                        MessageBox.Show("Tên đại lý đã tồn tại trong quận này, vui lòng chọn tên khác!");
                        return;
                    }
                }
            }
            try
            {
                DataProvider.Instance.ExecuteNonQuery("exec Update_DAILY @MaDaiLy , @TenDaiLy , @MaLoaiDaiLy , @DienThoai , @Email , @MaQuan", new object[] { MaDaiLyBox.Text, TenDaiLyBox.Text, LoaiDaiLyComboBox.Text, SDTBox.Text, EmailBox.Text, TenQuanComboBox.Text });
                MessageBox.Show("Chỉnh sửa thành công!");
                refreshList();
            }
            catch
            {
                MessageBox.Show("Chỉnh sửa không thành công!");
            }
        }
    }
}
