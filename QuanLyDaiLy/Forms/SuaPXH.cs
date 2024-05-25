using QuanLyDaiLy.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy.Forms
{
    public partial class SuaPXH : Form
    {
        string soPhieuXuat;
        string maDaiLy;
        string soTienTra;
        string tongTien;
        public SuaPXH(string soPhieu,string maDaiLy ,string soTienTra, string tongTien)
        {
            InitializeComponent();
            soPhieuXuat = soPhieu;
            this.maDaiLy = maDaiLy;
            this.soTienTra = soTienTra;
            this.tongTien = tongTien;
        }

        private void SuaPXH_Load(object sender, EventArgs e)
        {
            

            tbxSPX.Text = soPhieuXuat;
            textBox1.Text = maDaiLy;
            textBox2.Text = soTienTra;
            string so = soPhieuXuat;
            LoadDataForGridView();

            //load text box 
            string query = "exec tongthanhtien @SoPhieuXuat ";
            decimal tongThanhTien;
            var result = DataProvider.Instance.ExecuteQuery(query, new object[] { so });

            string[] myStringArray = result.Rows.Cast<DataRow>()
                        .Select(row => row["ketqua"].ToString())
                        .ToArray();
            if(myStringArray.Length >0)
            {
                if (myStringArray[0] =="")
                {
                    tongThanhTien = 0;
                    
                }
                else
                {
                    tongThanhTien = decimal.Parse(myStringArray[0]);

                }
            }
            else
            {
                tongThanhTien=0;
            }
            textBox3.Text = tongThanhTien.ToString();
        }


        private void LoadDataForGridView()
        {
            string queryString = "Select * from CT_PXH where SoPhieuXuat = " + soPhieuXuat;
            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new Object[] { });
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CT_PXH chiTiet = new CT_PXH(soPhieuXuat,true);
            chiTiet.ShowDialog();

            SuaPXH_Load(sender, e);
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string soPhieuXoa = soPhieuXuat;
            string maMatHang = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string query = "exec delete_ct_pxh @SoPhieuXuat , @MaMatHangXuat ";
            DataProvider.Instance.ExecuteQuery(query,new object[] {soPhieuXoa,maMatHang});

            MessageBox.Show("Xoa du lieu thanh cong", "thong bao", MessageBoxButtons.OK);
            SuaPXH_Load(sender, e);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal sotientramoi = decimal.Parse(textBox2.Text);
            soTienTra = textBox3.Text;
            string query = "exec updatePXH @SoPhieuXuat , @SoTienTra ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { soPhieuXuat,sotientramoi });

        }
    }
}
