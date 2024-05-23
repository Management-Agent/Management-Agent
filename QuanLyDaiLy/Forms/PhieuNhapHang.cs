using QuanLyDaiLy.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy
{
    public partial class PhieuNhapHang : Form
    {
        public PhieuNhapHang()
        {
            InitializeComponent();
            showElementInMatHang();
            showElementInDVT();
        }
        private void ThemPNH_Click(object sender, EventArgs e)
        {
            string theDate = NNH.Value.ToString("yyyy-MM-dd");
            string queryString = "exec Insert_PNH @SoPhieuNhap , @MaMatHang , @SoLuongNhap , @DonGiaNhap , @NgayNhapHang , @MaDVT ";
            int test = DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { SPN.Text, MMH.SelectedItem.ToString(), SLN.Text, DGN.Text, theDate, MDVT.Text });
            if (test > 0)
                MessageBox.Show("Thêm thành công.");
            else
                MessageBox.Show("Thêm không thành công.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showElementInMatHang()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetMaMatHang");
            MMH.DataSource = data;
            MMH.DisplayMember = "MaMatHang";
        }
        private void showElementInDVT()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetMaDVT");
            MDVT.DataSource = data;
            MDVT.DisplayMember = "MaDVT";
        }
    }
}
