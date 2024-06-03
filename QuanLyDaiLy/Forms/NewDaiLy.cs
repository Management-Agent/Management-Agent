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
            if(DienThoaiBox.Text == "")
            {
                MessageBox.Show("Thiếu thông tin (số điện thoại) liên hệ.");
                return;
            }
            try
            {
                string undefine = "Undefine";
                string tenDaiLy = TenDaiLyBox.Text; if (tenDaiLy == "") tenDaiLy = undefine;
                string diachi = DiaChiBox.Text; if (diachi == "") diachi = undefine;
                string email = EmailBox.Text; if (email == "") email = undefine;
                string theDate = NgayTiepNhanBox.Value.ToString("yyyy-MM-dd");

                DataTable subData = DataProvider.Instance.ExecuteQuery("exec USP_GetDaiLyInfoThroughMaQuan @MaQuan", new object[] { QuanBox.Text });

                string[] arrayTenDaiLy = subData.AsEnumerable()
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
                    if(name == undefine) { continue; }
                    if(name == tenDaiLy)
                    {
                        MessageBox.Show("Tên đại lý đã tồn tại trong quận này, vui lòng chọn tên khác!");
                        return;
                    }
                }

                string queryString = "exec Insert_DaiLy @TenDaiLy , @MaLoaiDaiLy , @DienThoai , @DiaChi , @Email , @MaQuan , @NgayTiepNhan , @TongNo ";
                int test = DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { tenDaiLy, LoaiDaiLyBox.Text, DienThoaiBox.Text, diachi, email, QuanBox.Text, theDate, 0 });
                if (test != 0) MessageBox.Show("Thêm thành công.");
                else MessageBox.Show("Thêm không thành công.");
            }
            catch
            {
                MessageBox.Show("Thêm không thành công! Vui lòng nhập số điện thoại hợp lệ.");
            }
            
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

        private void HoanTacThongTinButton_Click(object sender, EventArgs e)
        {

        }
    }
}
