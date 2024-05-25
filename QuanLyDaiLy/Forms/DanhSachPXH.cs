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
            string query = "Select * from PHIEUXUATHANG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dgvPXH.DataSource = data;
        }

        private void btnTCPXH_Click(object sender, EventArgs e)
        {
            string maPhieuXuat = tbxTCPXH.Text;
            TraCuuPhieuXuat(maPhieuXuat);
        }

        private void btnXPXH_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPXH.SelectedRows[0];
            string soPhieuXuat = row.Cells[0].Value.ToString();


            string query = "exec deletePXH @SoPhieuXuat ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { soPhieuXuat });
            DanhSachPXH_Load(sender, e);

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
            DanhSachPXH_Load(sender, e);

        }

        private void btnSPXH_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPXH.SelectedRows[0];
            string soPhieuXuat = row.Cells[0].Value.ToString();
            string maDaiLy = row.Cells[1].Value.ToString();
            string soTienTra = row.Cells[4].Value.ToString();
            string tongTien = row.Cells[3].Value.ToString();
            SuaPXH p = new SuaPXH(soPhieuXuat, maDaiLy, soTienTra, tongTien);
           
            p.ShowDialog();

            DanhSachPXH_Load(sender,e);
            
        }
    }
}
