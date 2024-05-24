using QuanLyDaiLy.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy.Forms
{
    public partial class PhieuXuatHang : Form
    {
        public PhieuXuatHang()
        {
            InitializeComponent();
            showElementInMatHang();
            showElementInDVT();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnThemPXH_Click(object sender, EventArgs e)
        {

            string theDate = dtpNXH.Value.ToString("yyyy-MM-dd");
            string queryString = "exec Insert_PXH @SoPhieuXuat , @MaDaiLy , @MaMatHangXuat , @SoLuongXuat , @DonGiaXuat , @SoTienTra , @NgayXuatHang , @MaDVT ";
            int test = DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { tbxSPX.Text, tbxMDL.Text, cbMMH.Text, long.Parse( tbxSLX.Text), decimal.Parse(tbxDGX.Text),decimal.Parse(tbxSTT.Text) ,theDate, cbMDVT.Text });
            if (test > 0)
                MessageBox.Show("Thêm thành công.");
            else
                MessageBox.Show("Thêm không thành công.");
        }

        private void showElementInMatHang()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetMaMatHang");
            cbMMH.DataSource = data;
            cbMMH.DisplayMember = "MaMatHang";
        }
        private void showElementInDVT()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetMaDVT");
            cbMDVT.DataSource = data;
            cbMDVT.DisplayMember = "MaDVT";
        }
    }
}
