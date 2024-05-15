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
        }
        private void ThemPNH_Click(object sender, EventArgs e)
        {
            string theDate = NNH.Value.ToString("yyyy-MM-dd");
            string queryString = "exec Insert_PNH @SoPhieuNhap , @MaMatHang , @SoLuongNhap , @DonGiaNhap , @NgayNhapHang , @MaDVT , @TenDVT , @TenMatHang ";
            int test = DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { SPN.Text, MMH.SelectedItem.ToString(), SLN.Text, DGN.Text, theDate, MDVT.Text, TDVT.Text, TMH.Text });
            if (test > 0)
                MessageBox.Show("Thêm thành công.");
            else
                MessageBox.Show("Thêm không thành công.");
        }

        private void PhieuNhapHang_Load(object sender, EventArgs e)
        {
            MMH.Items.AddRange(new object[] { "MH1", "MH2", "MH3", "MH4", "MH5" });
            MDVT.Items.AddRange(new object[] { "1", "2" });
        }

        private void MDVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MDVT.SelectedItem.ToString() == "1")
            {
                TDVT.Text = "Dollar";
            }
            else if (MDVT.SelectedItem.ToString() == "2")
            {
                TDVT.Text = "VND";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MMH.SelectedItem.ToString() == "MH1") 
            { 
                TMH.Text = "MH1";
            }
            else if (MMH.SelectedItem.ToString() == "MH2")
            {
                TMH.Text = "MH2";
            }
            else if (MMH.SelectedItem.ToString() == "MH3")
            {
                TMH.Text = "MH3";
            }
            else if (MMH.SelectedItem.ToString() == "MH4")
            {
                TMH.Text = "MH4";
            }
            else if (MMH.SelectedItem.ToString() == "MH5")
            {
                TMH.Text = "MH5";
            }
        }
    }
}
