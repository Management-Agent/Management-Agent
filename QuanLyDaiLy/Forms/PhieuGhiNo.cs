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
    public partial class PhieuGhiNo : Form
    {
        public PhieuGhiNo()
        {
            InitializeComponent();
        }

        private void PhieuGhiNo_Load(object sender, EventArgs e)
        {
            string querySelectTenDaiLy = "Select MaDaiLy from DAILY";
            DataTable dsDaiLy = DataProvider.Instance.ExecuteQuery(querySelectTenDaiLy);
            List<string> list = dsDaiLy.Rows.OfType<DataRow>().Select(dr => (string)dr["MaDaiLy"]).ToList();
            comboBoxMaDaiLy.Items.AddRange(list.ToArray());
        }
         
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DienThoaiBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNoDau_TextChanged(object sender, EventArgs e)
        {
            if(textBoxNoDau.Text.Length > 0 && textBoxPhatSinh.Text.Length > 0) 
            {
                int noCuoiValue = int.Parse(textBoxNoDau.Text) + int.Parse(textBoxPhatSinh.Text);
                textBoxNoCuoi.Text = noCuoiValue.ToString();
            }
        }

        private void textBoxPhatSinh_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNoDau.Text.Length > 0 && textBoxPhatSinh.Text.Length > 0)
            {
                int noCuoiValue = int.Parse(textBoxNoDau.Text) + int.Parse(textBoxPhatSinh.Text);
                textBoxNoCuoi.Text = noCuoiValue.ToString();
            }
            else
            {
                textBoxNoCuoi.Text = "";
            }
        }

        private void AddBaoCaoCongNo()
        {
            //Test();
            string maDaiLy = comboBoxMaDaiLy.Text;
            int thang = dateTimePicker1.Value.Month;
            int nam = dateTimePicker1.Value.Year;
            System.Decimal noDau = decimal.Parse(textBoxNoDau.Text);
            System.Decimal phatSinh = decimal.Parse(textBoxPhatSinh.Text);
            SqlParameter errorMessageParam = new SqlParameter("@ErrorMessage", System.Data.SqlDbType.NVarChar, 1000);
            errorMessageParam.Direction = ParameterDirection.Output;
            string errorMessage = string.Empty;
            //
            SqlConnection conn = new SqlConnection(DataProvider.Instance.connectionSTR);
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "USP_AddCongNo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaDaiLy", maDaiLy);
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam", nam);
                cmd.Parameters.AddWithValue("@NoDau", noDau);
                cmd.Parameters.AddWithValue("@PhatSinh", phatSinh);

                SqlParameter para = cmd.Parameters.Add("@ErrorMessage", SqlDbType.NVarChar, 1000);
                para.Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteScalar();

                errorMessage = para.Value.ToString();

                // . . .  
            }
            //

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Them du lieu thanh cong", "Thong bao", MessageBoxButtons.OK);

                this.Close();
            }
        }

        private void ThemDaiLyButton_Click(object sender, EventArgs e)
        {
            AddBaoCaoCongNo();

        }

        private void comboBoxMaDaiLy_TextChanged(object sender, EventArgs e)
        {
            ComboBox maDaiLyBox = (ComboBox)sender;
            if (maDaiLyBox.Text.Length > 0)
            {
                string maDaiLy = maDaiLyBox.Text;
                string query = "Exec USP_GetTenDaiLy @MaDaiLy ";
                string data = DataProvider.Instance.ExecuteScalar(query, new object[] { maDaiLy }).ToString();
                textBoxTenDaiLy.Text = data;
            }
            else
            {
                textBoxTenDaiLy.Text = "";
            }
        }

        private void Test()
        {
            
        }
        
    }
}
