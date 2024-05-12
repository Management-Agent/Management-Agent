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
    public partial class PhieuGhiNo : Form
    {
        public PhieuGhiNo()
        {
            InitializeComponent();
        }

        private void PhieuGhiNo_Load(object sender, EventArgs e)
        {
            string query = "Select TenDaiLy from DAILY";
            DataTable dsDaiLy = DataProvider.Instance.ExecuteQuery(query);
            List<string> list = dsDaiLy.Rows.OfType<DataRow>().Select(dr => (string)dr["TenDaiLy"]).ToList();
            comboBox1.Items.AddRange(list.ToArray());
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
    }
}
