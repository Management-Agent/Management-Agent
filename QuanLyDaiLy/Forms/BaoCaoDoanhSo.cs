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
    public partial class BaoCaoDoanhSo : Form
    {
        public BaoCaoDoanhSo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string thang_bc = comboBox1.SelectedItem.ToString();
            string querystring = "exec BCDS_month @Thang"
            DataTable data = DataProvider.Instance.ExecuteQuery(querystring, new object[] {"Thang"});
            dataGridViewBCDS.DataSource = data; 
        }
    }
}
