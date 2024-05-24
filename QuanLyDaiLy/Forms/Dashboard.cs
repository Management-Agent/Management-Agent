using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDaiLy.Forms;


namespace QuanLyDaiLy
{
    public partial class Dashboard : Form
    {
        List<ThamSo> thamso = new List<ThamSo>();
        DataAccess db = new DataAccess();
        public Dashboard()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(MatHang matHangForm = new MatHang())
            {
                matHangForm.ShowDialog();
            }
        }

        private void quảnLýĐạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(DanhSachDaiLy danhSachDaiLy = new DanhSachDaiLy())
            {
                danhSachDaiLy.ShowDialog();
            }
        }

        private void phiếuNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(DanhSachPNH phieuNhapHang = new DanhSachPNH())
            {
                phieuNhapHang.ShowDialog();
            }
        }

        private void phiếuXuấtHanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(DanhSachPXH phieuXuatHang = new DanhSachPXH())
            {
                phieuXuatHang.ShowDialog();
            }
        }

        private void phiếuThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(DanhSachPTT phieuThuTien = new DanhSachPTT())
            {
                phieuThuTien.ShowDialog();
            }
        }

        private void doanhSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(BaoCaoDoanhSo baoCaoDoanhSo = new BaoCaoDoanhSo())
            {
                baoCaoDoanhSo.ShowDialog();
            }
        }

        private void côngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(BaoCaoCongNo baoCaoCongNo = new BaoCaoCongNo())
            {
                baoCaoCongNo.ShowDialog();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận thoát phần mềm?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void loạiĐạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(LoaiDaiLy loaiDaiLy = new LoaiDaiLy())
            {
                loaiDaiLy.ShowDialog();
            }
        }

        private void danhSáchQuậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using( SuaQuan  quan = new SuaQuan())
            {
                quan.ShowDialog();
            }
        }
    }
}
