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
    public partial class CT_PXH : Form
    {
        string soPhieuXuat;
        bool isInsert;
        public CT_PXH(string soPhieuXuat,bool isInsert)
        {
            InitializeComponent();
            this.soPhieuXuat = soPhieuXuat;
            this.isInsert = isInsert;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CT_PXH_Load(object sender, EventArgs e)
        {
            textBox1.Text = soPhieuXuat;

            string query = "Select MaMatHang from MATHANG";
            DataTable data =DataProvider.Instance.ExecuteQuery(query);
            string[] maMatHang = data.AsEnumerable()
                     .Select(row => row.Field<string>("MaMatHang"))
                     .ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(maMatHang);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(isInsert)
            {
                string query = "exec USP_insert_CT_PXH @SoPhieuXuat , @MaMatHangXuat , @SoLuongXuat , @DonGiaXuat , @ThanhTien ";
                string maMatHang = comboBox1.Text;
                int soLuong = int.Parse(textBox3.Text);
                decimal donGia = decimal.Parse(textBox4.Text);
                decimal thanhTien = decimal.Parse(textBox5.Text);
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { soPhieuXuat, maMatHang, soLuong, donGia, thanhTien });
                MessageBox.Show("Da them chi tiet xuat hang", "thong bao", MessageBoxButtons.OK);
            }
            else
            {
                string query = "exec USP_update_CT_PXH @SoPhieuXuat , @MaMatHangXuat , @SoLuongXuat , @DonGiaXuat , @ThanhTien ";
                string maMatHang = comboBox1.Text;
                int soLuong = int.Parse(textBox3.Text);
                decimal donGia = decimal.Parse(textBox4.Text);
                decimal thanhTien = decimal.Parse(textBox5.Text);
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { soPhieuXuat, maMatHang, soLuong, donGia, thanhTien });
                MessageBox.Show("Da cap nhat thong tin", "thong bao", MessageBoxButtons.OK);

            }

            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateThanhTien();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            UpdateThanhTien();

        }

        private void UpdateThanhTien()
        {
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                int soLuong = int.Parse(textBox3.Text);
                int donGia = int.Parse(textBox4.Text);
                int thanhTien = soLuong * donGia;
                textBox5.Text = thanhTien.ToString();
            }

        }
    }
}
