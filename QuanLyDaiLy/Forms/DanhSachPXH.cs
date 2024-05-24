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
using System.Web;
using System.Windows.Forms;
namespace QuanLyDaiLy.Forms
{
    public partial class DanhSachPXH : Form
    {
        public DanhSachPXH()
        {
            InitializeComponent();
        }
        private void TraCuuPhieuXuat(string maPhieuXuat)
        {
            string queryString = "";

            if (maPhieuXuat.ToLower() == "all")
            {
                queryString = "exec Search_All_PXH @SoPhieuXuat";
            }
            else
            {
                queryString = "exec Search_Info_PXH @SoPhieuXuat";
            }

            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new object[] { maPhieuXuat });
            dgvPXH.DataSource = data;
        }

        private void DanhSachPXH_Load(object sender, EventArgs e)
        {
            if(tbxTCPXH.Text == "")
            {
                string queryString = "EXEC Search_All_PXH @SoPhieuXuat";
                DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new object[] {tbxTCPXH.Text});
                dgvPXH.DataSource = data;
            }
        }

        private void btnTCPXH_Click(object sender, EventArgs e)
        {
            string maPhieuXuat = tbxTCPXH.Text;
            TraCuuPhieuXuat(maPhieuXuat);
        }

        private void btnXPXH_Click(object sender, EventArgs e)
        {
            string maPhieuXuat = tbxXPXH.Text;
            XoaPhieuXuat(maPhieuXuat);

        }
        private void XoaPhieuXuat(string maPhieuXuat)
        {
            string queryString = "exec Delete_Info_PXH @SoPhieuXuat";

            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new object[] { maPhieuXuat });
            TraCuuPhieuXuat("all");
        }

        private void btnTPXH_Click(object sender, EventArgs e)
        {
            PhieuXuatHang p = new PhieuXuatHang();
            //this.Hide();
            p.ShowDialog();
            //this.Show();
        }

        private void btnSPXH_Click(object sender, EventArgs e)
        {
            SuaPXH p = new SuaPXH();
            //this.Hide(); 
            p.Show();
            //this.Show();
        }
    }
}
