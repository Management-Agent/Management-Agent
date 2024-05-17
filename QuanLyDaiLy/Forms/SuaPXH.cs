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
    public partial class SuaPXH : Form
    {
        public SuaPXH()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxSLX.Text))
            {
                string queryString = "exec Update_CT_PXH_SLX @SoPhieuXuat , @MaMatHangXuat , @SoLuongXuat ";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { tbxSPX.Text, tbxMMHX.Text, tbxSPX.Text });
            }
            if (!string.IsNullOrWhiteSpace(tbxDGX.Text))
            {
                string queryString = "exec Update_CT_PXH_DGX @SoPhieuXuat , @MaMatHangXuat , @DonGiaXuat ";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { tbxSPX.Text, tbxMMHX.Text, tbxDGX.Text });
            }
            TraCuuCTPNH(tbxSPX.Text, tbxMMHX.Text);
        }
        private void TraCuuCTPNH(string SPX, string MMHX)
        {
            string queryString = "";

            queryString = "exec Search_CT_PXH @SoPhieuNhap , @MaMatHang ";

            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new object[] { SPX, MMHX });
            dataGridViewCTPXH.DataSource = data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaPXH_Load(object sender, EventArgs e)
        {
            string queryString = "exec Search_CT_PXH_All @SoPhieuXuat";
            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new Object[] { tbxSPX.Text, tbxMMHX.Text});
            dataGridViewCTPXH.DataSource = data;
        }
    }
}
