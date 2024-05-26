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
    public partial class DanhSachPTT : Form
    {
        public DanhSachPTT()
        {
            InitializeComponent();
        }

        private void btnTPTT_Click(object sender, EventArgs e)
        {
            PhieuThuTien p = new PhieuThuTien();
            //this.Hide();
            p.ShowDialog();
            //this.Show();   
        }

        private void btnTCPTT_Click(object sender, EventArgs e)
        {
            String maPhieuThu = tbxTCPTT.Text;
            TraCuuPhieuThu(maPhieuThu);
        }
        private void TraCuuPhieuThu(string maPhieuThu)
        {
            string queryString = "";

            if (maPhieuThu.ToLower() == "all")
            {
                queryString = "exec Search_All_PTT @SoPhieuThu";
            }
            else
            {
                queryString = "exec Search_Info_PTT @SoPhieuThu";
            }

            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new object[] { maPhieuThu });
            dgvDSPTT.DataSource = data;
        }

        private void btnXPTT_Click(object sender, EventArgs e)
        {
            String maPhieuThu = tbxXPTT.Text;
            XoaPhieuThu(maPhieuThu);
        }
        private void XoaPhieuThu(string maPhieuThu)
        {
            string queryString = "exec Delete_Info_PTT @SoPhieuThu";

            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new object[] { maPhieuThu });
            TraCuuPhieuThu("all");
        }

        private void DanhSachPTT_Load(object sender, EventArgs e)
        {

            TraCuuPhieuThu("all");
        }

        private void dgvDSPTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TraCuuPhieuThu("all");
        }
    }
}
