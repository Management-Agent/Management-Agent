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
    public partial class SuaPNH : Form
    {
        public SuaPNH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string SPN = SearchSPN.Text;
            string MMH = SearchMMH.Text;

            TraCuuCTPNH(SPN, MMH);
        }
        private void TraCuuCTPNH(string SPN, string MMH)
        {
            string queryString = "";
            queryString = "exec Search_CT_PNH @SoPhieuNhap , @MaMatHang ";

            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new object[] { SPN, MMH });
            dataGridViewCTPNH.DataSource = data;
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            // Lấy các giá trị cần cập nhật từ các ô chỉnh sửa khác
        }
        private void UpdateData(string soPhieuNhap, string maMatHang, string soLuong)
        {
            string queryString = "UPDATE CT_PNH SET SoLuong = @SoLuong WHERE SoPhieuNhap = @SoPhieuNhap AND MaMatHang = @MaMatHang";
            DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { soLuong, soPhieuNhap, maMatHang });
        }

        //private void ThemPNH_Click(object sender, EventArgs e)
        //{
        //    DataGridViewRow editedRow = dataGridViewCTPNH.Rows[RowIndex];
        //    string soPhieuNhap = editedRow.Cells["SoPhieuNhap"].Value.ToString();
        //    string maMatHang = editedRow.Cells["MaMatHang"].Value.ToString();
        //    string soLuong = editedRow.Cells["SoLuong"].Value.ToString();
        //    UpdateData(soPhieuNhap, maMatHang, soLuong);
        //}
    }
}
