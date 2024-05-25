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
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnThemPXH_Click(object sender, EventArgs e)
        {

            string theDate = dtpNXH.Value.ToString("yyyy-MM-dd");
            string query = "exec INSERT_PXH @SoPhieuXuat , @MaDaiLy , @NgayXuatHang , @TongTien , @SoTienTra ";
            decimal tongTien = 0;
           // string queryString = "exec Insert_PXH @SoPhieuXuat , @MaDaiLy , @MaMatHangXuat , @SoLuongXuat , @DonGiaXuat , @SoTienTra , @NgayXuatHang , @MaDVT ";
            int test = DataProvider.Instance.ExecuteNonQuery(query, new object[] { textBox1.Text, tbxMDL.Text,theDate,tongTien,decimal.Parse(tbxSTT.Text) });
            if (test > 0)
                MessageBox.Show("Thêm thành công.");
            else
                MessageBox.Show("Thêm không thành công.");
        }

        
    }
}
