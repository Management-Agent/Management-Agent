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
    public partial class PhieuNhapHang : Form
    {
        public PhieuNhapHang()
        {
            InitializeComponent();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            string SPN = SoPhieuNhap.Text;
            string NNH = NgayNhapHang.Text;
            int TT = int.Parse(TongTien.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-QPLRUS8G\\SQLEXPRESS; database = CNPM; integrated = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText= "insert into PHIEUNHAPHANG(SoPhieuNhap, NgayNhapHang, TongTien) values ('" + SPN + "', '" + NNH + "','" + TT + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data save");
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            textBoxPNH.Clear();
            textBoxNNH.Clear();
            textBoxTT.Clear();

        }
    }
}
