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
    public partial class PhieuThuTien : Form
    {
        public PhieuThuTien()
        {
            InitializeComponent();
        }
        void insertData(string SoPhieuThu, string MaDaiLy, DateTime NgayThuTien, decimal SoTienThu)
        {
            SqlConnection conn = new SqlConnection(DataProvider.Instance.connectionSTR);
            string query = "INSERT INTO PHIEUTHUTIEN (SoPhieuThu, MaDaiLy, NgayThuTien, SoTienThu) VALUES (@SoPhieuThu, @MaDaiLy, @NgayThuTien, @SoTienThu)";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@SoPhieuThu", SoPhieuThu);
            command.Parameters.AddWithValue("@MaDaiLy", MaDaiLy);
            command.Parameters.AddWithValue("@NgayThuTien", NgayThuTien);
            command.Parameters.AddWithValue("@SoTienThu", SoTienThu);
            conn.Open();

            int i = command.ExecuteNonQuery();

            if (i > 0)
            {
                Console.WriteLine("Data inserted successfully.");
            }
            else
            {
                Console.WriteLine("No rows inserted.");
            }

            conn.Close();

        }

        private void btnInsertPTT_Click(object sender, EventArgs e)
        {
            string SoPhieuThu = tbxSPT.Text;
            DateTime NgayThuTien = dtbNTT.Value;
            string MaDaiLy = tbxMDL.Text;
            decimal SoTienThu = decimal.Parse(tbxSTT.Text);
            insertData(SoPhieuThu, MaDaiLy, NgayThuTien, SoTienThu);
        }
    }
}
