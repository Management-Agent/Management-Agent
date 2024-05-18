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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private void TraCuuCTPNH(string SPN, string MMH)
        {
            string queryString = "";

            queryString = "exec Search_CT_PNH @SoPhieuNhap , @MaMatHang ";

            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new object[] { SPN, MMH });
            dataGridViewCTPNH.DataSource = data;
        }
        private void ThemPNH_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SLN.Text))
            {
                string queryString = "exec Update_CT_PNH_SLN @SoPhieuNhap , @MaMatHang , @SoLuongNhap ";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { SearchSPN.Text, SearchMMH.Text, SLN.Text });
            }
            if (!string.IsNullOrWhiteSpace(DGN.Text))
            {
                string queryString = "exec Update_CT_PNH_DGN @SoPhieuNhap , @MaMatHang , @DonGiaNhap ";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { SearchSPN.Text, SearchMMH.Text, DGN.Text });
            }
            if (!string.IsNullOrWhiteSpace(DVT.Text))
            {
                string queryString = "exec Update_CT_PNH_DVT @SoPhieuNhap , @MaMatHang , @MaDonViTinh ";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { SearchSPN.Text, SearchMMH.Text, DVT.Text });
            }
            TraCuuCTPNH(SearchSPN.Text, SearchMMH.Text);
        }

        private void SuaPNH_Load(object sender, EventArgs e)
        {
            if (SearchSPN.Text == "")
            {
                string queryString = "";
                queryString = "exec Search_CT_PNH_All @SoPhieuNhap";
                DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new object[] { SearchSPN.Text, SearchMMH.Text });
                dataGridViewCTPNH.DataSource = data;
            }
        }
    }
}
