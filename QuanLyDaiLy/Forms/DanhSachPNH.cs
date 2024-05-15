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
    public partial class DanhSachPNH : Form
    {
        public DanhSachPNH()
        {
            InitializeComponent();
        }

        private void ThemPNH_Click(object sender, EventArgs e)
        {
            PhieuNhapHang p = new PhieuNhapHang();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maPhieuNhap = SearchPNH.Text;

            TraCuuPhieuNhap(maPhieuNhap);
        }
        private void TraCuuPhieuNhap(string maPhieuNhap)
        {
            string queryString = "";

            if (maPhieuNhap.ToLower() == "all")
            {
                queryString = "exec Search_All_PNH @SoPhieuNhap";
            }
            else
            {
                queryString = "exec Search_Info_PNH @SoPhieuNhap";
            }

            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new object[] { maPhieuNhap });
            dataGridViewPNH.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maPhieuNhap = DeletePNH.Text;

            XoaPhieuNhap(maPhieuNhap);
        }
        private void XoaPhieuNhap(string maPhieuNhap)
        {
            string queryString = "exec Delete_Info_PNH @SoPhieuNhap";

            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new object[] { maPhieuNhap });
            TraCuuPhieuNhap("all");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SuaPNH p = new SuaPNH();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }
    }
}
