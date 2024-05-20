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

namespace QuanLyDaiLy.Forms
{
    public partial class SuaThamSo : Form
    {
        public SuaThamSo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SuaThamSo_Load(object sender, EventArgs e)
        {
            textBoxSoDaiLyToiDa.Text = GetSoDaiLyToiDa().ToString();
            textBoxSoLoaiDaiLy.Text = GetSoLoaiDaiLy().ToString();
            textBoxTiLeDonGia.Text = GetTyLeDonGia().ToString();
            textBoxSoMatHang.Text = GetSoLuongMatHang().ToString();
            textBoxSoDVT.Text = GetSoLuongDVT().ToString();

        }

        private int GetSoLoaiDaiLy()
        {
            string query = @"Select Count(MaDaiLy) from DaiLy";
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result;
        }

        private int GetSoDaiLyToiDa()
        {
            string query = @"Select GiaTri from THAMSO where TenThamSo = 'SoDaiLyToiDa'";
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result;
        }

        private int GetTyLeDonGia()
        {
            string query = @"Select GiaTri from THAMSO where TenThamSo = 'TiLeTinhDonGiaXuat'";
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result;
        }

        private int GetSoLuongMatHang()
        {
            string query = @"Select Count(MaMatHang) from MATHANG";
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result;
        }

        private int GetSoLuongDVT()
        {
            string query = @"Select Count(MaDVT) from DVT";
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int soDaiLyToiDa = int.Parse(textBoxSoDaiLyToiDa.Text);
            if (soDaiLyToiDa < 0)
            {
                MessageBox.Show("So dai ly toi da khong the nho hon 0", "Thong Bao", MessageBoxButtons.OK);
            }
            else
            {

                string query = "UPDATE THAMSO SET GiaTri =" + soDaiLyToiDa.ToString() +
                        "where TenThamSo = 'SoDaiLyToiDa'";
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Thay doi thanh cong", "Thong Bao", MessageBoxButtons.OK);

            }
        }

        private void textBoxSoDaiLyToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ngăn chặn ký tự không hợp lệ
                e.Handled = true;
            }
        }

        private void textBoxTiLeDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ngăn chặn ký tự không hợp lệ
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tyLeDonGia = int.Parse(textBoxSoDaiLyToiDa.Text);
            if (tyLeDonGia < 0)
            {
                MessageBox.Show(" Ty le don gia khong the nho hon 0", "Thong Bao", MessageBoxButtons.OK);
            }
            else
            {

                string query = "UPDATE THAMSO SET GiaTri =" + tyLeDonGia.ToString() +
                        "where TenThamSo = 'TiLeTinhDonGiaXuat'";
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Thay doi thanh cong", "Thong Bao", MessageBoxButtons.OK);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoaiDaiLy loaiDaiLy = new LoaiDaiLy();
            loaiDaiLy.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MatHang matHang = new MatHang();
            matHang.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DonViTinh donViTinh = new DonViTinh();
            donViTinh.ShowDialog();
        }
    }
}
