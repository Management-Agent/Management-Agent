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

namespace QuanLyDaiLy.Forms
{
    public partial class PhieuXuatHang : Form
    {
        DataTable dt = new DataTable();
        public PhieuXuatHang()
        {
            InitializeComponent();

        }




        private void btnInsert_Click(object sender, EventArgs e)
        {
            string theDate = dtpNXH.Value.ToString("yyyy-MM-dd");
            string queryString = "exec Insert_PXH @SoPhieuXuat , @MaDaiLy , @MaMatHangXuat , @SoLuongXuat , @DonGiaXuat , @NgayXuatHang , @MaDVT , @TenDVT , @TenMatHang , @ThanhTien";
            int test = DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { tbxSPX.Text, tbxMDL.Text, cbMMHX.SelectedItem.ToString(), tbxSLX.Text, tbxDGX.Text, theDate, cbMDVT.Text, tbxTDVT.Text, tbxTMH.Text, tbxTT.Text });
            if (test > 0)
                MessageBox.Show("Thêm thành công.");
            else
                MessageBox.Show("Thêm không thành công.");
        }
        private void PhieuXuatHang_Load(object sender, EventArgs e)
        {
            cbMMHX.Items.AddRange(new object[] { "MH1", "MH2", "MH3", "MH4", "MH5" });
            cbMDVT.Items.AddRange(new object[] { "1", "2" });
        }

        private void cbMDVT_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbMDVT.SelectedItem.ToString() == "1")
            {
                tbxTDVT.Text = "Dollar";
            }
            else if (cbMDVT.SelectedItem.ToString() == "2")
            {
                tbxTDVT.Text = "VND";
            }

        }

        private void cbMMHX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMMHX.SelectedItem.ToString() == "MH1")
            {
                tbxTMH.Text = "MH1";
            }
            else if (cbMMHX.SelectedItem.ToString() == "MH2")
            {
                tbxTMH.Text = "MH2";
            }
            else if (cbMMHX.SelectedItem.ToString() == "MH3")
            {
                tbxTMH.Text = "MH3";
            }
            else if (cbMMHX.SelectedItem.ToString() == "MH4")
            {
                tbxTMH.Text = "MH4";
            }
            else if (cbMMHX.SelectedItem.ToString() == "MH5")
            {
                tbxTMH.Text = "MH5";
            }
        }

        private void tbcSLX_TextChanged(object sender, EventArgs e)
        {
            if (tbxDGX.Text != "" && tbxSLX.Text != "")
            {
                decimal cost = decimal.Parse(tbxDGX.Text) * int.Parse(tbxSLX.Text);
                tbxTT.Text = cost.ToString("F2");
            }
            if (tbxDGX.Text == "" || tbxSLX.Text == "")
            {
                tbxTT.Text = "";
            }
        }

        private void tbxDGX_TextChanged(object sender, EventArgs e)
        {
            if (tbxDGX.Text != "" && tbxSLX.Text != "")
            {
                decimal cost = decimal.Parse(tbxDGX.Text) * int.Parse(tbxSLX.Text);
                tbxTT.Text = cost.ToString("F2");
            }
            if (tbxDGX.Text == "" || tbxSLX.Text == "")
            {
                tbxTT.Text = "";
            }
        }
    }
}
