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
    public partial class PhieuXuatHang : Form
    {
        DataTable dt = new DataTable();
        public PhieuXuatHang()
        {
            InitializeComponent();
            fill_data();
        }
        void insertDataPXH(string SoPhieuXuat, string MaDaiLy, DateTime NgayXuatHang, Decimal SoTienTra, Decimal TongTien, Decimal ConLai)
        {

            SqlConnection conn = new SqlConnection("Data Source=GNH134\\SQLEXPRESS;Initial Catalog=tester;Integrated Security=True;TrustServerCertificate=True");
            string query1 = "INSERT INTO PHIEUXUATHANG (SoPhieuXuat, MaDaiLy, NgayXuatHang, SoTienTra, TongTien, ConLai) VALUES (@SoPhieuXuat, @MaDaiLy, @NgayXuatHang, @SoTienTra, @TongTien, @ConLai)";
            SqlCommand cmd = new SqlCommand(query1, conn);

            cmd.Parameters.AddWithValue("@TongTien", TongTien);
            cmd.Parameters.AddWithValue("@ConLai", ConLai);
            cmd.Parameters.AddWithValue("@SoPhieuXuat", SoPhieuXuat);
            cmd.Parameters.AddWithValue("@MaDaiLy", MaDaiLy);
            cmd.Parameters.AddWithValue("@NgayXuatHang", NgayXuatHang);
            cmd.Parameters.AddWithValue("@SoTienTra", SoTienTra);
            conn.Open();


            int i = cmd.ExecuteNonQuery();

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
        void insertDataCT_PXH(string SoPhieuXuat, String MaMatHangXuat, int SoLuongXuat, decimal DonGiaXuat, decimal ThanhTien)
        {
            SqlConnection conn2 = new SqlConnection("Data Source=GNH134\\SQLEXPRESS;Initial Catalog=tester;Integrated Security=True;TrustServerCertificate=True");
            string query2 = "INSERT INTO CT_PXH (ThanhTien, DonGiaXuat, SoPhieuXuat, MaMatHangXuat, SoLuongXuat) VAlUES (@ThanhTien, @DonGiaXuat, @SoPhieuXuat, @MaMatHangXuat, @SoLuongXuat)";
            SqlCommand command2 = new SqlCommand(query2, conn2);



            command2.Parameters.AddWithValue("@SoPhieuXuat", SoPhieuXuat);
            command2.Parameters.AddWithValue("@MaMatHangXuat", MaMatHangXuat);
            command2.Parameters.AddWithValue("@SoLuongXuat", SoLuongXuat);
            command2.Parameters.AddWithValue("@DonGiaXuat", DonGiaXuat);
            command2.Parameters.AddWithValue("@ThanhTien", ThanhTien);
            conn2.Open();
            command2.ExecuteNonQuery();


            conn2.Close();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            string SoPhieuXuat = tbxSPX.Text;
            string MaDaiLy = tbxMDL.Text;
            DateTime NgayXuatHang = dtpNXH.Value;
            string MaMatHangXuat = tbxMMHX.Text;
            int SoLuongXuat = int.Parse(tbxSLX.Text);
            Decimal SoTienTra = decimal.Parse(tbxSTT.Text);
            Decimal DonGiaXuat = decimal.Parse(tbxDGX.Text);
            Decimal ThanhTien = decimal.Parse(tbxThanhTien.Text);
            Decimal TongTien = decimal.Parse(tbxTongTien.Text);
            decimal ConLai = decimal.Parse(tbxConLai.Text);

            insertDataPXH(SoPhieuXuat, MaDaiLy, NgayXuatHang, SoTienTra, TongTien, ConLai);
            insertDataCT_PXH(SoPhieuXuat, MaMatHangXuat, SoLuongXuat, DonGiaXuat, ThanhTien);
        }

        private void tbxSLX_TextChanged(object sender, EventArgs e)
        {
            tbxThanhTien.Text = (int.Parse(tbxSLX.Text) * int.Parse(tbxDGX.Text)).ToString();
        }

        private void tbxDGX_TextChanged(object sender, EventArgs e)
        {
            tbxThanhTien.Text = (int.Parse(tbxSLX.Text) * int.Parse(tbxDGX.Text)).ToString();
        }
        void fill_data()
        {
            SqlConnection conn = new SqlConnection("Data Source=GNH134\\SQLEXPRESS;Initial Catalog=tester;Integrated Security=True;TrustServerCertificate=True");
            SqlCommand command = new SqlCommand("select * form CT_PNH", conn);
            string selectquery = "select * from CT_PNH";
            SqlDataAdapter adapter = new SqlDataAdapter(selectquery, conn);
            //can lay dt.Rows[i][1]: MaMatHang va dt.Rows[i][3] DonGiaNhap
            adapter.Fill(dt);
        }

        private void tbxMMHX_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString() == tbxMMHX.Text)
                {
                    tbxDGX.Text = (decimal.Parse(dt.Rows[i][3].ToString()).ToString("F2"));
                }
            }
        }

        private void tbxSTT_TextChanged(object sender, EventArgs e)
        {
            decimal conlai = decimal.Parse(tbxTongTien.Text) - decimal.Parse(tbxSTT.Text);
            conlai = Math.Abs(conlai);
            if (conlai < 0)
            {
                tbxConLai.Text = "Nợ: " + conlai.ToString();
            }
            else
            {
                tbxConLai.Text = "Thừa: " + conlai.ToString();
            }

        }
    }
}
